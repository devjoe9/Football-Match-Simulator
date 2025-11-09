using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //adds MySQL features

namespace Football_Match_Simulator
{
    public partial class formSimSetup : Form
    {
        //initialises a dictionary of tactic names paired with two multiplier values (the first for attacking strength, the second for defensive strength)
        static Dictionary<string, Tuple<double, double>> tacticsDict = new Dictionary<string, Tuple<double, double>>
        {
            { "Attacking", new Tuple<double, double>(1.3, 1.3) },
            { "Direct", new Tuple<double, double>(1.15, 1.15) },
            { "Normal", new Tuple<double, double>(1, 1) },
            { "Patient", new Tuple<double, double>(0.85, 0.85) },
            { "Defensive", new Tuple<double, double>(0.7, 0.7) }
        };
        //initialises a dictionary of morale options paired with two multiplier values (the first for attacking strength, the second for defensive strength)
        static Dictionary<string, Tuple<double, double>> moraleDict = new Dictionary<string, Tuple<double, double>>
        {
            { "Very high", new Tuple<double, double>(1.2, 0.8) },
            { "High", new Tuple<double, double>(1.1, 0.9) },
            { "Normal", new Tuple<double, double>(1, 1) },
            { "Low", new Tuple<double, double>(0.9, 1.1) },
            { "Very low", new Tuple<double, double>(0.8, 1.2) }
        };

        //initialises a collection of keys from moraleDict and a collection of keys from moraleKeys
        Dictionary<string, Tuple<double, double>>.KeyCollection tactKeys = tacticsDict.Keys;
        Dictionary<string, Tuple<double, double>>.KeyCollection moraleKeys = moraleDict.Keys;

        //initialises linked lists globally because they will be needed by different methods in this form	
        LinkedList<string> hPlayerNames = new LinkedList<string>();
        LinkedList<double> hPlayerRatings = new LinkedList<double>();
        LinkedList<string> hPlayerPos = new LinkedList<string>();

        LinkedList<string> aPlayerNames = new LinkedList<string>();
        LinkedList<double> aPlayerRatings = new LinkedList<double>();
        LinkedList<string> aPlayerPos = new LinkedList<string>();

        public string userLeague, userHTeam, userATeam, userHTactic, userATactic, userHMorale, userAMorale, likelyHScorer, likelyAScorer, likelyHAssister, likelyAAssister;
        public string[] userHTeamSheetNames, userATeamSheetNames;
        public bool userFormBias;
        public int userNumSims;
        public double hXG, aXG, hXWinProb, aXWinProb, xDrawProb;
        public int[,] occurenceArray;

        public formSimSetup()
        {
            InitializeComponent(); //required method for windows forms

            //adds each key from tactKeys into two drop down menus (one for home team, one for away team)
            foreach (string s in tactKeys)
            {
                comboBoxHTactic.Items.Add(s);
                comboBoxATactic.Items.Add(s);
            }

            //adds each key from moraleKeys into two drop down menus (one for home team, one for away team)
            foreach (string s in moraleKeys)
            {
                comboBoxHMorale.Items.Add(s);
                comboBoxAMorale.Items.Add(s);
            }

            //sets the default selection in these drop down menus to be the item at index 2 (in this case 'Normal')
            comboBoxHTactic.SelectedIndex = 2;
            comboBoxATactic.SelectedIndex = 2;
            comboBoxHMorale.SelectedIndex = 2;
            comboBoxAMorale.SelectedIndex = 2;

            LinkedList<string> leagueNames = new LinkedList<string>(GetLeagueNamesFromDB());

            //adds each league name to a drop down menu
            for (int i = 0; i < leagueNames.Count(); i++)
            {
                comboBoxLeague.Items.Add(leagueNames.ElementAt(i));
            }
        }


        //----------------------------\\
        //---METHODS FOR VALIDATION---\\
        //----------------------------\\


        private static bool IsSelected(object selection) // object selection refers to a selection made in a drop down menu
        {
            if (selection == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsValidNumSims(string text)
        {
            try
            {
                int numSims = int.Parse(text); //attempts to convert input to integer; this is why try and catch is used as failure to convert causes an exception

                if (numSims > 1000000 || numSims < 1)
                {
                    MessageBox.Show("Input for 'Number of simulations' is out of range");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                if (text == "")
                {
                    MessageBox.Show("No input given for 'Number of simulations'");
                }
                else
                {
                    MessageBox.Show("Invalid input given for 'Number of simulations'");
                }

                return false;
            }
        }

        private bool HasNoDupes(object[] teamSheet)
        {
            bool valid = true;
            int gkCount = 0;

            for (int i = 0; i < teamSheet.Length; i++)
            {
                for (int j = i + 1; j < teamSheet.Length; j++) //j = i + 1 so that the same comparisons aren't made multiple times
                {
                    if (teamSheet[i] == teamSheet[j])
                    {
                        valid = false;
                        MessageBox.Show("Duplicate player found: " + teamSheet[i].ToString()); //tells the user which player has been duplicated
                    }
                }

                if (teamSheet[i].ToString().Contains("-GK-")) //if the player in the element is a GK (goalkeeper)
                {
                    gkCount += 1;
                }
            }

            if (gkCount != 1)
            {
                valid = false;
                MessageBox.Show("The selected team sheets must have exactly one GK");
            }

            return valid;
        }


        //---------------------------------\\
        //---METHODS FOR DATABASE ACCESS---\\
        //---------------------------------\\


        public static MySqlConnection ConnectToDB() //a required function to connect to the database
        {
            MySqlConnection conSQL = new MySqlConnection();

            //MySql Connection string for local MySql Server - the PC I am working on
            //'localhost' picks up the current machine
            conSQL.ConnectionString = @"server=localhost; uid=root; database=football_database";

            return conSQL;
        }

        public static LinkedList<string> GetLeagueNamesFromDB()
        {
            MySqlConnection connect = ConnectToDB(); //fetches the connection string

            //SQL SELECT query
            string commandText = "SELECT LeagueName " +
                "FROM league " +
                "ORDER BY LeagueID";

            MySqlDataReader myDataReader; //used to read data from the database

            LinkedList<string> namesFromDB = new LinkedList<string>();

            using (connect)
            {
                MySqlCommand selectDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                try //tries to run the query, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    myDataReader = selectDataCommand.ExecuteReader(); //executes the command

                    while (myDataReader.Read()) //while there is data to be read from the returned table; data is read one row at a time
                    {
                        namesFromDB.AddLast(myDataReader.GetString(0)); //adds the value in the first column (index 0) of the row from the resulting table to the end of the linked list
                    }

                    myDataReader.Close(); //closes the stream
                    connect.Close(); //closes the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return namesFromDB;
        }

        public static LinkedList<string> GetTeamNamesFromDB(string leagueName)
        {
            MySqlConnection connect = ConnectToDB(); //fetches the connection string

            //SQL SELECT query
            string commandText = "SELECT TeamName " +
                "FROM Team, League " +
                "WHERE Team.LeagueID = League.LeagueID AND League.LeagueName = @userLeague " +
                "ORDER BY TeamName";

            MySqlDataReader myDataReader; //used to read data from the database

            LinkedList<string> namesFromDB = new LinkedList<string>();

            using (connect)
            {
                MySqlCommand selectDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                selectDataCommand.Parameters.Add("@userLeague", MySqlDbType.VarChar); //gives the expected data type of this placeholder in the SQL statement
                selectDataCommand.Parameters["@userLeague"].Value = leagueName; //gives the value for this placeholder

                try //tries to run the query, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    myDataReader = selectDataCommand.ExecuteReader(); //executes the command

                    while (myDataReader.Read()) //while there is data to be read from the returned table; data is read one row at a time
                    {
                        namesFromDB.AddLast(myDataReader.GetString(0));  //adds the value in the first column (index 0) of the row from the resulting table to the end of the linked list
                    }

                    myDataReader.Close(); //closes the stream
                    connect.Close(); //closes the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return namesFromDB;
        }

        private void GetPlayerInfoFromDB(string team, ref LinkedList<string> PlayerNames, ref LinkedList<double> PlayerRating, ref LinkedList<string> PlayerPos)
        {
            MySqlConnection connect = ConnectToDB(); //fetches the connection string

            //SQL SELECT query
            string commandText = "SELECT PlayerName, Rating, Position " +
                "FROM Player, Team " +
                "WHERE Player.TeamID = Team.TeamID AND Team.TeamName = @userTeam " +
                "ORDER BY Position, Rating DESC";

            MySqlDataReader myDataReader; //used to read data from the database

            using (connect)
            {
                MySqlCommand selectDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                selectDataCommand.Parameters.Add("@userTeam", MySqlDbType.VarChar); //gives the expected data type of this placeholder in the SQL statement
                selectDataCommand.Parameters["@userTeam"].Value = team; //gives the value for this placeholder

                try //tries to run the query, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    myDataReader = selectDataCommand.ExecuteReader(); //executes the command

                    while (myDataReader.Read()) //while there is data to be read from the returned table; data is read one row at a time
                    {
                        //adds the value from the specified column index of the current row to the end of these linked lists
                        PlayerNames.AddLast(myDataReader.GetString(0));
                        PlayerRating.AddLast(Math.Round(myDataReader.GetFloat(1), 2)); //rounds the values from the column of index 1 to two decimal places before adding to the linkedlist
                        PlayerPos.AddLast(myDataReader.GetString(2));
                    }

                    myDataReader.Close(); //closes the stream
                    connect.Close(); //closes the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private Tuple<double, double> GetAvgGoalsFromDB(string commandText, string name)
        {
            MySqlConnection connect = ConnectToDB(); //fetches the connection string
            MySqlDataReader myDataReader; //used to read data from the database

            double goalsFor = -1;
            double goalsAgainst = -1;

            using (connect)
            {
                MySqlCommand selectDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                //rather than having seperate functions for team and league, where the only difference would be the name of the placeholder in the SQL query, I have used selection to detect both placeholders
                //placeholders in the SQL statement are given an expected data type and value
                if (commandText.Contains("@userTeam"))
                {
                    selectDataCommand.Parameters.Add("@userTeam", MySqlDbType.VarChar);
                    selectDataCommand.Parameters["@userTeam"].Value = name;
                }
                else if (commandText.Contains("@userLeague"))
                {
                    selectDataCommand.Parameters.Add("@userLeague", MySqlDbType.VarChar);
                    selectDataCommand.Parameters["@userLeague"].Value = name;
                }

                try //tries to run the query, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    myDataReader = selectDataCommand.ExecuteReader(); //executes the command
                    myDataReader.Read(); //reads the first row of the returned table

                    //values at column index 0 and 1 are rounded to two decimal places and assigned to two variables
                    goalsFor = Math.Round(myDataReader.GetFloat(0), 2);
                    goalsAgainst = Math.Round(myDataReader.GetFloat(1), 2);

                    myDataReader.Close(); //closes the stream
                    connect.Close(); //closes the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return Tuple.Create(goalsFor, goalsAgainst);
        }

        private double GetTeamRatingFromDB(string teamName)
        {
            MySqlConnection connect = ConnectToDB(); //fetches the connection string

            //SQL SELECT query
            string commandText = "SELECT TeamRating " +
                "FROM Team " +
                "WHERE Team.TeamName = @userTeam ";

            MySqlDataReader myDataReader; //used to read data from the database

            double teamRating = -1;

            using (connect)
            {
                MySqlCommand selectDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                selectDataCommand.Parameters.Add("@userTeam", MySqlDbType.VarChar); //gives the expected data type of this placeholder in the SQL statement
                selectDataCommand.Parameters["@userTeam"].Value = teamName; //gives the value for this placeholder

                try //tries to run the query, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    myDataReader = selectDataCommand.ExecuteReader(); //executes the command
                    myDataReader.Read(); //reads the first row of the returned table
                    teamRating = myDataReader.GetDouble(0); //assigns the value in the first column of the returned table to a variable

                    myDataReader.Close(); //closes the stream
                    connect.Close(); //closes the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return teamRating;
        }

        public string GetTeamAbrrev(string team)
        {
            MySqlConnection connect = ConnectToDB(); //fetches the connection string

            //SQL SELECT query
            string commandText = "SELECT TeamID " +
                "FROM Team " +
                "WHERE Team.TeamName = @userTeam ";

            MySqlDataReader myDataReader; //used to read data from the database

            string abbrev = "";

            using (connect)
            {
                MySqlCommand selectDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                selectDataCommand.Parameters.Add("@userTeam", MySqlDbType.VarChar); //gives the expected data type of this placeholder in the SQL statement
                selectDataCommand.Parameters["@userTeam"].Value = team; //gives the value for this placeholder

                try //tries to run the query, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    myDataReader = selectDataCommand.ExecuteReader(); //executes the command
                    myDataReader.Read(); //reads the first row of the returned table
                    abbrev = myDataReader.GetString(0); //assigns the value in the first column of the returned table to a variable

                    myDataReader.Close(); //closes the stream
                    connect.Close(); //closes the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return abbrev;
        }

        private string GetMostLikelyPlayer(string commandText, string[] teamSheetPlayers)
        {
            MySqlConnection connect = ConnectToDB(); //fetches the connection string
            MySqlDataReader myDataReader; //used to read data from the database

            string playerName = "";

            using (connect)
            {
                MySqlCommand selectDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                //placeholders in the SQL query are given an expected data type and value
                selectDataCommand.Parameters.Add("@userP1", MySqlDbType.VarChar);
                selectDataCommand.Parameters["@userp1"].Value = teamSheetPlayers[0];
                selectDataCommand.Parameters.Add("@userP2", MySqlDbType.VarChar);
                selectDataCommand.Parameters["@userp2"].Value = teamSheetPlayers[1];
                selectDataCommand.Parameters.Add("@userP3", MySqlDbType.VarChar);
                selectDataCommand.Parameters["@userp3"].Value = teamSheetPlayers[2];
                selectDataCommand.Parameters.Add("@userP4", MySqlDbType.VarChar);
                selectDataCommand.Parameters["@userp4"].Value = teamSheetPlayers[3];
                selectDataCommand.Parameters.Add("@userP5", MySqlDbType.VarChar);
                selectDataCommand.Parameters["@userp5"].Value = teamSheetPlayers[4];
                selectDataCommand.Parameters.Add("@userP6", MySqlDbType.VarChar);
                selectDataCommand.Parameters["@userp6"].Value = teamSheetPlayers[5];
                selectDataCommand.Parameters.Add("@userP7", MySqlDbType.VarChar);
                selectDataCommand.Parameters["@userp7"].Value = teamSheetPlayers[6];
                selectDataCommand.Parameters.Add("@userP8", MySqlDbType.VarChar);
                selectDataCommand.Parameters["@userp8"].Value = teamSheetPlayers[7];
                selectDataCommand.Parameters.Add("@userP9", MySqlDbType.VarChar);
                selectDataCommand.Parameters["@userp9"].Value = teamSheetPlayers[8];
                selectDataCommand.Parameters.Add("@userP10", MySqlDbType.VarChar);
                selectDataCommand.Parameters["@userp10"].Value = teamSheetPlayers[9];
                selectDataCommand.Parameters.Add("@userP11", MySqlDbType.VarChar);
                selectDataCommand.Parameters["@userp11"].Value = teamSheetPlayers[10];

                try //tries to run the query, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    myDataReader = selectDataCommand.ExecuteReader(); //executes the command
                    myDataReader.Read(); //reads the first row of the returned table
                    playerName = myDataReader.GetString(0); //assigns the value in the first column to a variable

                    myDataReader.Close(); //closes the stream
                    connect.Close(); //closes the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return playerName;
        }


        //----------------------------------\\
        //---METHODS FOR MATCH SIMULATION---\\
        //----------------------------------\\


        private void CalcPosRatings(int index, LinkedList<double> playerRatings, LinkedList<string> playerPos,
            ref double teamAtk, ref double teamMid, ref double teamDef, ref double teamGk,
            ref int atkCount, ref int midCount, ref int defCount)
        {
            //selection to determine the position of a player
            if (playerPos.ElementAt(index) == "ATK")
            {
                teamAtk += playerRatings.ElementAt(index); //tallies the total rating of players with position 'ATK'
                atkCount += 1; //tallies the total number of players with position 'ATK'
            }
            else if (playerPos.ElementAt(index) == "MID")
            {
                teamMid += playerRatings.ElementAt(index); //tallies the total rating of players with position 'MID'
                midCount += 1; //tallies the total number of players with position 'MID'
            }
            else if (playerPos.ElementAt(index) == "DEF")
            {
                teamDef += playerRatings.ElementAt(index); //tallies the total rating of players with position 'DEF'
                defCount += 1; //tallies the total number of players with position 'DEF'
            }
            else
            {
                teamGk = playerRatings.ElementAt(index); //assigns the rating of the player with position 'GK' to a variable
                //no need to tally number of goalkeepers as there will always be only one
            }
        }

        private Tuple<Tuple<double, double>, Tuple<double, double>> CalcStrengthMultipliers()
        {
            double hAtkMultiplier = 1, hDefMultiplier = 1, hTeamAtk = 0, hTeamMid = 0, hTeamDef = 0, hTeamGk = 0, userHTeamRating,
                aAtkMultiplier = 1, aDefMultiplier = 1, aTeamAtk = 0, aTeamMid = 0, aTeamDef = 0, aTeamGk = 0, userATeamRating;
            int hAtkCount = 0, hMidCount = 0, hDefCount = 0,
                aAtkCount = 0, aMidCount = 0, aDefCount = 0;
            int[] hTeamSheetIndexes = new int[] { comboBoxHTeamP1.SelectedIndex, comboBoxHTeamP2.SelectedIndex, comboBoxHTeamP3.SelectedIndex, comboBoxHTeamP4.SelectedIndex, comboBoxHTeamP5.SelectedIndex, comboBoxHTeamP6.SelectedIndex, comboBoxHTeamP7.SelectedIndex, comboBoxHTeamP8.SelectedIndex, comboBoxHTeamP9.SelectedIndex, comboBoxHTeamP10.SelectedIndex, comboBoxHTeamP11.SelectedIndex };
            int[] aTeamSheetIndexes = new int[] { comboBoxATeamP1.SelectedIndex, comboBoxATeamP2.SelectedIndex, comboBoxATeamP3.SelectedIndex, comboBoxATeamP4.SelectedIndex, comboBoxATeamP5.SelectedIndex, comboBoxATeamP6.SelectedIndex, comboBoxATeamP7.SelectedIndex, comboBoxATeamP8.SelectedIndex, comboBoxATeamP9.SelectedIndex, comboBoxATeamP10.SelectedIndex, comboBoxATeamP11.SelectedIndex };
           
            foreach (int index in hTeamSheetIndexes)
            {
                //the procedure CalcPosRatings is called for all 11 selected home team players
                CalcPosRatings(index, hPlayerRatings, hPlayerPos, ref hTeamAtk, ref hTeamMid, ref hTeamDef, ref hTeamGk,
                ref hAtkCount, ref hMidCount, ref hDefCount);
            }

            foreach (int index in aTeamSheetIndexes)
            {
                //the procedure CalcPosRatings is called for all 11 selected home team players
                CalcPosRatings(index, aPlayerRatings, aPlayerPos, ref aTeamAtk, ref aTeamMid, ref aTeamDef, ref aTeamGk,
                ref aAtkCount, ref aMidCount, ref aDefCount);
            }
           
            //selection prevents dividing by 0 
            if (hAtkCount != 0)
            {
                hTeamAtk /= hAtkCount; //calculates average rating of home players with position 'ATK'
            }
            if (hMidCount != 0)
            {
                hTeamMid /= hMidCount; //calculates average rating of home players with position 'MID'
            }
            if (hDefCount != 0)
            {
                hTeamDef /= hDefCount; //calculates average rating of home players with position 'DEF'
            }

            userHTeamRating = (hTeamAtk + hTeamMid + hTeamDef + hTeamGk) / 4; //calculates average rating of the home team sheet

            //selection prevents dividing by 0
            if (aAtkCount != 0)
            {
                aTeamAtk /= aAtkCount; //calculates average rating of away players with position 'ATK'
            }
            if (aMidCount != 0)
            {
                aTeamMid /= aMidCount; //calculates average rating of away players with position 'ATK'
            }
            if (aDefCount != 0)
            {
                aTeamDef /= aDefCount; //calculates average rating of away players with position 'ATK'
            }

            userATeamRating = (aTeamAtk + aTeamMid + aTeamDef + aTeamGk) / 4; //calculates average rating of the away team sheet

            double hTeamRating = GetTeamRatingFromDB(userHTeam);
            double aTeamRating = GetTeamRatingFromDB(userATeam);

            //calculates the ratio of the user's selected team sheet to the teams' most used team sheet
            double hTeamRatingRatio = userHTeamRating / hTeamRating;
            double aTeamRatingRatio = userATeamRating / aTeamRating;

            //calculates the multipliers used for both teams' attacking and defensive strength for the xG
            //variable selections are keys used to access multiplier values from the corresponding dictionary

            //seperating tuple dictionary values for easier comprehension
            double hTacticAtkMulti = tacticsDict[userHTactic].Item1, hTacticDefMulti = tacticsDict[userHTactic].Item2,
                hMoraleAtkMulti = moraleDict[userHMorale].Item1, hMoraleDefMulti = moraleDict[userHMorale].Item2,
                aTacticAtkMulti = tacticsDict[userATactic].Item1, aTacticDefMulti = tacticsDict[userATactic].Item2,
                aMoraleAtkMulti = moraleDict[userAMorale].Item1, aMoraleDefMulti = moraleDict[userAMorale].Item2;

            hAtkMultiplier *= hTacticAtkMulti * hMoraleAtkMulti * hTeamRatingRatio;
            hDefMultiplier *= hTacticDefMulti * hMoraleDefMulti / hTeamRatingRatio;
            aAtkMultiplier *= aTacticAtkMulti * aMoraleAtkMulti * aTeamRatingRatio;
            aDefMultiplier *= aTacticDefMulti * aMoraleDefMulti / aTeamRatingRatio;

            return Tuple.Create(Tuple.Create(hAtkMultiplier, hDefMultiplier), Tuple.Create(aAtkMultiplier, aDefMultiplier));
        }

        private Tuple<double, double> CalcXG()
        {
            Tuple<Tuple<double, double>, Tuple<double, double>> atkDefstrengthMultipliers = CalcStrengthMultipliers();

            double hXg, aXg, hAtkStrength, hDefStrength, aAtkStrength, aDefStrength,
                //seperating the nested tuples for easier comprehension
                hAtkMultiplier = atkDefstrengthMultipliers.Item1.Item1, hDefMultiplier = atkDefstrengthMultipliers.Item1.Item2,
                aAtkMultiplier = atkDefstrengthMultipliers.Item2.Item1, aDefMultiplier = atkDefstrengthMultipliers.Item2.Item2;

            Tuple<double, double> leagueAvgHandAGoals = GetAvgGoalsFromDB
                ("SELECT sum(HGoalsScored) / sum(HGamesPlayed), sum(AGoalsScored) / sum(AGamesPlayed) " +
                "FROM Team, League " +
                "WHERE Team.LeagueID = League.LeagueID AND LeagueName = @userLeague",
                userLeague);

            //seperating the tuple returned from GetAvgGoalsFromDB for easier comprehension
            double leagueAvgHGoals = leagueAvgHandAGoals.Item1, leagueAvgAGoals = leagueAvgHandAGoals.Item2;

            Tuple<double, double> hAvgGoals = new Tuple<double, double>(-1, -1);
            Tuple<double, double> aAvgGoals = new Tuple<double, double>(-1, -1);

            //selection used as different SQL queries are used to get the average goals, depending on whether or not the user selected to include 'Recent form bias'
            if (checkBoxFormBias.Checked)
            {
                hAvgGoals = GetAvgGoalsFromDB
                    ("SELECT avg(HGoals), avg(AGoals) " +
                    "FROM " +
                    "(SELECT HGoals, AGoals " +
                    "FROM previousgames " +
                    "WHERE previousgames.HTeam = @userTeam " +
                    "ORDER BY DatePlayed DESC " +
                    "LIMIT 5) previousgames;",
                    userHTeam);

                aAvgGoals = GetAvgGoalsFromDB
                    ("SELECT avg(AGoals), avg(HGoals) " +
                    "FROM " +
                    "(SELECT AGoals, HGoals " +
                    "FROM previousgames " +
                    "WHERE previousgames.ATeam = @userTeam " +
                    "ORDER BY DatePlayed DESC " +
                    "LIMIT 5) previousgames;",
                    userATeam);
            }
            else
            {
                hAvgGoals = GetAvgGoalsFromDB
                ("SELECT HGoalsScored / HGamesPlayed, HGoalsConceded / HGamesPlayed " +
                "FROM Team " +
                "WHERE Team.TeamName = @userTeam",
                userHTeam);

                aAvgGoals = GetAvgGoalsFromDB
                ("SELECT AGoalsScored / AGamesPlayed, AGoalsConceded / AGamesPlayed " +
                "FROM Team " +
                "WHERE Team.TeamName = @userTeam",
                userATeam);
            }

            //seperating the tuple returned from GetAvgGoalsFromDB for easier comprehension
            double hAvgGoalsScored = hAvgGoals.Item1, hAvgGoalsConceded = hAvgGoals.Item2;
            double aAvgGoalsScored = aAvgGoals.Item1, aAvgGoalsConceded = aAvgGoals.Item2;

            hAtkStrength = (hAvgGoalsScored / leagueAvgHGoals) * hAtkMultiplier;
            hDefStrength = (hAvgGoalsConceded / leagueAvgAGoals) * hDefMultiplier;
            aAtkStrength = (aAvgGoalsScored / leagueAvgAGoals) * aAtkMultiplier;
            aDefStrength = (aAvgGoalsConceded / leagueAvgHGoals) * aDefMultiplier;

            hXg = hAtkStrength * aDefStrength * leagueAvgHGoals;
            aXg = aAtkStrength * hDefStrength * leagueAvgAGoals;

            return Tuple.Create(hXg, aXg);
        }

        private double PoissonDist(int numGoals, double xG) //implementation of the Poisson distribution formula
        {
            double top = Math.Pow(xG, numGoals) * Math.Exp(-xG);
            double bottom = Factorial(numGoals);
            double prob = top / bottom;

            return prob;
        }

        private double Factorial(int numGoals)
        {
            if (numGoals == 1 || numGoals == 0)
            {
                return 1;
            }
            else
            {
                return numGoals * Factorial(numGoals - 1); //recursion to calculate factorial
            }
        }

        private double[,] CalcScorelineProbs()
        {
            double[,] scorelineProbsArray = new double[10, 10];

            //calculates probability of each scoreline from 0-0 to 9-9 and stores each probability in the corresponding cell of the 2d array
            //each index in the first dimension represents the number of home goals, and each index in the second dimension represents the number of away goals
            for (int i = 0; i < scorelineProbsArray.GetLength(0); i++)
            {
                for (int j = 0; j < scorelineProbsArray.GetLength(1); j++)
                {
                    scorelineProbsArray[i, j] = PoissonDist(i, hXG) * PoissonDist(j, aXG);
                }
            }

            return scorelineProbsArray;
        }

        private double[] AccumulateScorelineProbs(double[,] scorelineProbsArray)
        {
            double[] cumulativeArray = new double[100];
            int counter = 0;

            //accumulates the probabilities stored in the array scoreLineProbs
            for (int i = 0; i < scorelineProbsArray.GetLength(0); i++)
            {
                for (int j = 0; j < scorelineProbsArray.GetLength(1); j++)
                {
                    //selection prevents 'index out of range' exception when counter holds the value 0
                    if (counter != 0)
                    {
                        cumulativeArray[counter] += cumulativeArray[counter - 1] + scorelineProbsArray[i, j];

                    }
                    else 
                    {
                        cumulativeArray[0] = scorelineProbsArray[0, 0]; //this line can be put outside by letting i start at 1, but doing so means that all score-lines where the home team scores 0 are ignored
                    }

                    counter += 1;
                }
            }

            return cumulativeArray;
        }

        private int[,] GenerateScorelines(double[,] scorelineProbsArray)
        {
            int counter = 0;
            occurenceArray = new int[10, 10];
            Random rand = new Random();

            double[] cumulativeArray = AccumulateScorelineProbs(scorelineProbsArray);

            while (counter != userNumSims)
            {
                double randomNum = rand.NextDouble(); //generates a random floating point number where 0 <= randomNum < 1
                int index = Array.BinarySearch(cumulativeArray, randomNum); //searches the cumulativeArray for the randomly generated number

                //if the element isn't found, the method returns the bitwise complement of the index of the first element that is larger than the random number
                if (index < 0)
                {
                    index = ~index; //apply bitwise complement to reverse the bitwise complement returned by BinarySearch
                    if (index == 100) //if randomNum is larger than all elements in the array, the method returns the bitwise complement of (the index of the last element + 1)
                    {
                        index -= 1; //changes the value to be the last index in the array rather than the (last index + 1)
                    }
                }

                //changes the index to the score-line it represents
                int randHGoals = index / 10, randAGoals = index % 10;
                occurenceArray[randHGoals, randAGoals] += 1; //keeps track of how many times each score-line is randomly selected
                counter += 1;
            }

            return occurenceArray;
        }

        private void CalcXProbs(double[,] scorelineProbsArray)
        {
            hXWinProb = 0;
            aXWinProb = 0;
            xDrawProb = 0;

            for (int i = 0; i < scorelineProbsArray.GetLength(0); i++)
            {
                for (int j = 0; j < scorelineProbsArray.GetLength(1); j++)
                {
                    //separately adds up all probabilities in scorelineProbs where the home team wins, away team wins, and a draw occurs
                    if (i > j)
                    {
                        hXWinProb += scorelineProbsArray[i, j];
                    }
                    else if (i < j)
                    {
                        aXWinProb += scorelineProbsArray[i, j];
                    }
                    else
                    {
                        xDrawProb += scorelineProbsArray[i, j];
                    }
                }
            }
        }

        public static Tuple<int, int> GetHighestOccScoreline(int[,] occurenceArray)
        {
            int highestOccHGoals = 0, highestOccAGoals = 0;

            //finds the score-line which was randomly selected the most times
            for (int i = 0; i < occurenceArray.GetLength(0); i++)
            {
                for (int j = 0; j < occurenceArray.GetLength(1); j++)
                {
                    if (occurenceArray[i, j] > occurenceArray[highestOccHGoals, highestOccAGoals])
                    {
                        highestOccHGoals = i;
                        highestOccAGoals = j;
                    }
                }
            }
            return Tuple.Create(highestOccHGoals, highestOccAGoals);
        }

        //--------------------------------------------------\\
        //---METHODS FOR THE CONTROLS IN THE WINDOWS FORM---\\
        //--------------------------------------------------\\


        //this method is called whenever the selection in its drop down menu changes
        private void comboBoxLeague_SelectedIndexChanged(object sender, EventArgs e) //this method is called whenever the selection in its drop down menu changes
        {
            userLeague = comboBoxLeague.SelectedItem.ToString();
            LinkedList<string> teamNames = new LinkedList<string>(GetTeamNamesFromDB(userLeague));

            //clears the items in these drop down menus whenever the league selection is changed
            comboBoxHTeam.Items.Clear();
            comboBoxATeam.Items.Clear();

            for (int i = 0; i < teamNames.Count(); i++)
            {
                //adds the fetched team names to these drop down menus
                comboBoxHTeam.Items.Add(teamNames.ElementAt(i));
                comboBoxATeam.Items.Add(teamNames.ElementAt(i));
            }

            panelTeams.Visible = true; //makes the team selections visible
        }

        //this method is called whenever the selection in its drop down menu changes
        private void comboBoxHTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            userHTeam = comboBoxHTeam.SelectedItem.ToString();

            if (IsSelected(comboBoxATeam.SelectedItem) && comboBoxHTeam.SelectedItem != comboBoxATeam.SelectedItem)
            {
                //the user can only select variables and team sheets when both the home and away team selections are made and the selections are different
                panelVariables.Visible = true;
                panelHTeamSheet.Visible = true;
                panelATeamSheet.Visible = true;
            }
            else
            {
                panelVariables.Visible = false;
                panelHTeamSheet.Visible = false;
                panelATeamSheet.Visible = false;
            }

            //clears the items in these drop menus whenever the home team selection is changed
            comboBoxHTeamP1.Items.Clear();
            comboBoxHTeamP2.Items.Clear();
            comboBoxHTeamP3.Items.Clear();
            comboBoxHTeamP4.Items.Clear();
            comboBoxHTeamP5.Items.Clear();
            comboBoxHTeamP6.Items.Clear();
            comboBoxHTeamP7.Items.Clear();
            comboBoxHTeamP8.Items.Clear();
            comboBoxHTeamP9.Items.Clear();
            comboBoxHTeamP10.Items.Clear();
            comboBoxHTeamP11.Items.Clear();
            hPlayerNames.Clear();
            hPlayerRatings.Clear();
            hPlayerPos.Clear();

            GetPlayerInfoFromDB(userHTeam, ref hPlayerNames, ref hPlayerRatings, ref hPlayerPos);

            for (int i = 0; i < hPlayerNames.Count; i++)
            {
                string line = hPlayerNames.ElementAt(i) + "-" + hPlayerPos.ElementAt(i) + "-" + hPlayerRatings.ElementAt(i); //puts information about a player into a single string

                //adds player information into these drop down menus
                comboBoxHTeamP1.Items.Add(line);
                comboBoxHTeamP2.Items.Add(line);
                comboBoxHTeamP3.Items.Add(line);
                comboBoxHTeamP4.Items.Add(line);
                comboBoxHTeamP5.Items.Add(line);
                comboBoxHTeamP6.Items.Add(line);
                comboBoxHTeamP7.Items.Add(line);
                comboBoxHTeamP8.Items.Add(line);
                comboBoxHTeamP9.Items.Add(line);
                comboBoxHTeamP10.Items.Add(line);
                comboBoxHTeamP11.Items.Add(line);
            }
        }

        //this method is called whenever the selection in its drop down menu changes
        private void comboBoxATeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            userATeam = comboBoxATeam.SelectedItem.ToString();

            if (IsSelected(comboBoxHTeam.SelectedItem) && comboBoxHTeam.SelectedItem != comboBoxATeam.SelectedItem)
            {
                //the user can only select variables and team sheets when both the home and away team selections are made and the selections are different
                panelVariables.Visible = true;
                panelHTeamSheet.Visible = true;
                panelATeamSheet.Visible = true;
            }
            else
            {
                panelVariables.Visible = false;
                panelHTeamSheet.Visible = false;
                panelATeamSheet.Visible = false;
            }

            //clears the items in these drop menus whenever the home team selection is changed
            comboBoxATeamP1.Items.Clear();
            comboBoxATeamP2.Items.Clear();
            comboBoxATeamP3.Items.Clear();
            comboBoxATeamP4.Items.Clear();
            comboBoxATeamP5.Items.Clear();
            comboBoxATeamP6.Items.Clear();
            comboBoxATeamP7.Items.Clear();
            comboBoxATeamP8.Items.Clear();
            comboBoxATeamP9.Items.Clear();
            comboBoxATeamP10.Items.Clear();
            comboBoxATeamP11.Items.Clear();
            aPlayerNames.Clear();
            aPlayerRatings.Clear();
            aPlayerPos.Clear();

            GetPlayerInfoFromDB(userATeam, ref aPlayerNames, ref aPlayerRatings, ref aPlayerPos);

            for (int i = 0; i < aPlayerNames.Count; i++)
            {
                string line = aPlayerRatings.ElementAt(i) + "-" + aPlayerPos.ElementAt(i) + "-" + aPlayerNames.ElementAt(i); //puts information about a player into a single string

                //adds player information into these drop down menus
                comboBoxATeamP1.Items.Add(line);
                comboBoxATeamP2.Items.Add(line);
                comboBoxATeamP3.Items.Add(line);
                comboBoxATeamP4.Items.Add(line);
                comboBoxATeamP5.Items.Add(line);
                comboBoxATeamP6.Items.Add(line);
                comboBoxATeamP7.Items.Add(line);
                comboBoxATeamP8.Items.Add(line);
                comboBoxATeamP9.Items.Add(line);
                comboBoxATeamP10.Items.Add(line);
                comboBoxATeamP11.Items.Add(line);
            }
        }

        //this method is called whenever the selection in its drop down menu changes
        private void comboBoxHTactic_SelectedIndexChanged(object sender, EventArgs e)
        {
            userHTactic = comboBoxHTactic.SelectedItem.ToString();
        }

        //this method is called whenever the selection in its drop down menu changes
        private void comboBoxATactic_SelectedIndexChanged(object sender, EventArgs e)
        {
            userATactic = comboBoxATactic.SelectedItem.ToString();
        }

        //this method is called whenever the selection in its drop down menu changes
        private void comboBoxHMorale_SelectedIndexChanged(object sender, EventArgs e)
        {
            userHMorale = comboBoxHMorale.SelectedItem.ToString();
        }

        //this method is called whenever the selection in its drop down menu changes
        private void comboBoxAMorale_SelectedIndexChanged(object sender, EventArgs e)
        {
            userAMorale = comboBoxAMorale.SelectedItem.ToString();
        }

        //this method is called whenever its button is clicked
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide(); //this form is hidden
            formHome homeScreen = new formHome();
            homeScreen.Closed += (s, args) => this.Close(); //this form is closed when the homeScreen form is closed
            homeScreen.Show(); //displays homeScreen
        }

        //this method is called whenever its button is clicked
        private void buttonSimulate_Click(object sender, EventArgs e)
        {
            if (IsSelected(comboBoxHTeamP1.SelectedItem) && IsSelected(comboBoxHTeamP2.SelectedItem) && IsSelected(comboBoxHTeamP3.SelectedItem) &&
                IsSelected(comboBoxHTeamP4.SelectedItem) && IsSelected(comboBoxHTeamP5.SelectedItem) && IsSelected(comboBoxHTeamP6.SelectedItem) &&
                IsSelected(comboBoxHTeamP7.SelectedItem) && IsSelected(comboBoxHTeamP8.SelectedItem) && IsSelected(comboBoxHTeamP9.SelectedItem) &&
                IsSelected(comboBoxHTeamP10.SelectedItem) && IsSelected(comboBoxHTeamP11.SelectedItem) && IsSelected(comboBoxATeamP1.SelectedItem) &&
                IsSelected(comboBoxATeamP2.SelectedItem) && IsSelected(comboBoxATeamP3.SelectedItem) && IsSelected(comboBoxATeamP4.SelectedItem) &&
                IsSelected(comboBoxATeamP5.SelectedItem) && IsSelected(comboBoxATeamP6.SelectedItem) && IsSelected(comboBoxATeamP7.SelectedItem) &&
                IsSelected(comboBoxATeamP8.SelectedItem) && IsSelected(comboBoxATeamP9.SelectedItem) && IsSelected(comboBoxATeamP10.SelectedItem) &&
                IsSelected(comboBoxATeamP11.SelectedItem))
            {
                if (IsValidNumSims(textboxNumSims.Text))
                {
                    userNumSims = int.Parse(textboxNumSims.Text);

                    //the home and away team sheet selections are stored in arrays
                    object[] userHTeamSheet =
                        { comboBoxHTeamP1.SelectedItem, comboBoxHTeamP2.SelectedItem, comboBoxHTeamP3.SelectedItem, comboBoxHTeamP4.SelectedItem,
                        comboBoxHTeamP5.SelectedItem, comboBoxHTeamP6.SelectedItem, comboBoxHTeamP7.SelectedItem, comboBoxHTeamP8.SelectedItem,
                        comboBoxHTeamP9.SelectedItem, comboBoxHTeamP10.SelectedItem, comboBoxHTeamP11.SelectedItem };

                    object[] userATeamSheet =
                        { comboBoxATeamP1.SelectedItem, comboBoxATeamP2.SelectedItem, comboBoxATeamP3.SelectedItem, comboBoxATeamP4.SelectedItem,
                        comboBoxATeamP5.SelectedItem, comboBoxATeamP6.SelectedItem, comboBoxATeamP7.SelectedItem, comboBoxATeamP8.SelectedItem,
                        comboBoxATeamP9.SelectedItem, comboBoxATeamP10.SelectedItem, comboBoxATeamP11.SelectedItem };

                    if (HasNoDupes(userHTeamSheet) && HasNoDupes(userATeamSheet))
                    {
                        userFormBias = checkBoxFormBias.Checked;

                        //arrays that hold the names all players in the home and away team sheets
                        userHTeamSheetNames = new string[]
                        {
                            hPlayerNames.ElementAt(comboBoxHTeamP1.SelectedIndex),
                            hPlayerNames.ElementAt(comboBoxHTeamP2.SelectedIndex),
                            hPlayerNames.ElementAt(comboBoxHTeamP3.SelectedIndex),
                            hPlayerNames.ElementAt(comboBoxHTeamP4.SelectedIndex),
                            hPlayerNames.ElementAt(comboBoxHTeamP5.SelectedIndex),
                            hPlayerNames.ElementAt(comboBoxHTeamP6.SelectedIndex),
                            hPlayerNames.ElementAt(comboBoxHTeamP7.SelectedIndex),
                            hPlayerNames.ElementAt(comboBoxHTeamP8.SelectedIndex),
                            hPlayerNames.ElementAt(comboBoxHTeamP9.SelectedIndex),
                            hPlayerNames.ElementAt(comboBoxHTeamP10.SelectedIndex),
                            hPlayerNames.ElementAt(comboBoxHTeamP11.SelectedIndex),
                        };
                        userATeamSheetNames = new string[]
                        {
                            aPlayerNames.ElementAt(comboBoxATeamP1.SelectedIndex),
                            aPlayerNames.ElementAt(comboBoxATeamP2.SelectedIndex),
                            aPlayerNames.ElementAt(comboBoxATeamP3.SelectedIndex),
                            aPlayerNames.ElementAt(comboBoxATeamP4.SelectedIndex),
                            aPlayerNames.ElementAt(comboBoxATeamP5.SelectedIndex),
                            aPlayerNames.ElementAt(comboBoxATeamP6.SelectedIndex),
                            aPlayerNames.ElementAt(comboBoxATeamP7.SelectedIndex),
                            aPlayerNames.ElementAt(comboBoxATeamP8.SelectedIndex),
                            aPlayerNames.ElementAt(comboBoxATeamP9.SelectedIndex),
                            aPlayerNames.ElementAt(comboBoxATeamP10.SelectedIndex),
                            aPlayerNames.ElementAt(comboBoxATeamP11.SelectedIndex),
                        };

                        likelyHScorer = GetMostLikelyPlayer
                            ("SELECT PlayerName " +
                            "FROM player WHERE Goals > 0 AND (Player.PlayerName = @userP1 OR Player.PlayerName = @userP2 OR Player.PlayerName = @userP3 OR Player.PlayerName = @userP4 OR Player.PlayerName = @userP5 OR Player.PlayerName = @userP6 OR Player.PlayerName = @userP7 OR Player.PlayerName = @userP8 OR Player.PlayerName = @userP9 OR Player.PlayerName = @userP10 OR Player.PlayerName = @userP11) " +
                            "ORDER BY MinsPlayed / Goals", userHTeamSheetNames);
                        likelyAScorer = GetMostLikelyPlayer
                            ("SELECT PlayerName " +
                            "FROM player WHERE Goals > 0 AND (Player.PlayerName = @userP1 OR Player.PlayerName = @userP2 OR Player.PlayerName = @userP3 OR Player.PlayerName = @userP4 OR Player.PlayerName = @userP5 OR Player.PlayerName = @userP6 OR Player.PlayerName = @userP7 OR Player.PlayerName = @userP8 OR Player.PlayerName = @userP9 OR Player.PlayerName = @userP10 OR Player.PlayerName = @userP11) " +
                            "ORDER BY MinsPlayed / Goals", userATeamSheetNames);
                        likelyHAssister = GetMostLikelyPlayer
                            ("SELECT PlayerName " +
                            "FROM player WHERE Assists > 0 AND (Player.PlayerName = @userP1 OR Player.PlayerName = @userP2 OR Player.PlayerName = @userP3 OR Player.PlayerName = @userP4 OR Player.PlayerName = @userP5 OR Player.PlayerName = @userP6 OR Player.PlayerName = @userP7 OR Player.PlayerName = @userP8 OR Player.PlayerName = @userP9 OR Player.PlayerName = @userP10 OR Player.PlayerName = @userP11) " +
                            "ORDER BY MinsPlayed / Assists", userHTeamSheetNames);
                        likelyAAssister = GetMostLikelyPlayer
                            ("SELECT PlayerName " +
                            "FROM player WHERE Assists > 0 AND (Player.PlayerName = @userP1 OR Player.PlayerName = @userP2 OR Player.PlayerName = @userP3 OR Player.PlayerName = @userP4 OR Player.PlayerName = @userP5 OR Player.PlayerName = @userP6 OR Player.PlayerName = @userP7 OR Player.PlayerName = @userP8 OR Player.PlayerName = @userP9 OR Player.PlayerName = @userP10 OR Player.PlayerName = @userP11) " +
                            "ORDER BY MinsPlayed / Assists", userATeamSheetNames);

                        Tuple<double, double> hAndAXG = CalcXG();

                        //seperating the tuple returned from CalcXG
                        hXG = hAndAXG.Item1;
                        aXG = hAndAXG.Item2;

                        //

                        double[,] scorelineProbsArray = CalcScorelineProbs();
                        occurenceArray = GenerateScorelines(scorelineProbsArray);
                        CalcXProbs(scorelineProbsArray);

                        //

                        formSimResults simResultsScreen = new formSimResults();

                        if (checkBoxSkipPlay.Checked)
                        {
                            this.Hide(); //hides the current form
                            simResultsScreen.Show(); //displays simResultsScreen
                            simResultsScreen.FormClosing += simResultsScreen.SimResultsScreen_FormClosing; //before simResultsScreen is closed, the procedure SimResultsScreen_FormCosing is called
                        }
                        else
                        {
                            Tuple<int, int> highestOccScoreline = GetHighestOccScoreline(occurenceArray);
                            //separating the tuple for easier comprehension
                            int highestOccHGoals = highestOccScoreline.Item1, highestOccAGoals = highestOccScoreline.Item2;

                            string hTeamAbbrev = GetTeamAbrrev(userHTeam);
                            string aTeamAbbrev = GetTeamAbrrev(userATeam);

                            this.Hide(); //hides the current form
                            formPlayback playbackScreen = new formPlayback(highestOccHGoals, highestOccAGoals, hTeamAbbrev, aTeamAbbrev);
                            playbackScreen.Show(); //displays playbackScreen
                            playbackScreen.FormClosed += (s, args) => simResultsScreen.Show(); //after playbackScreen is closed, control is passed to simResultsScreen and is displayed
                            simResultsScreen.FormClosing += simResultsScreen.SimResultsScreen_FormClosing; //before simResultsScreen is closed, the procedure SimResultsScreen_FormCosing is called

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Not all selections have been made");
            }
        }


        //--------------------------------------------------\\
        //---UNUSED CONTROL METHODS THAT CAN'T BE DELETED---\\
        //--------------------------------------------------\\


        private void panelTeams_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxFormBias_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void textboxNumSims_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxATeamP1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxATeamP3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxATeamP4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxATeamP5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxATeamP6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxATeamP7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxATeamP8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxATeamP9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxATeamP10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxATeamP11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelTitleATactic_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxSkipPlay_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
