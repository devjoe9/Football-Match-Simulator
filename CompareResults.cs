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
    public partial class formCompareResults : Form
    {
        LinkedList<int> ResultIDList;
        LinkedList<string> simHTeamList;
        LinkedList<string> simATeamList;
        LinkedList<string> LikelyScore1stList;
        LinkedList<int> SimsRunList;

        public formCompareResults()
        {
            InitializeComponent(); //required method for windows forms

            LinkedList<string> leagueNames = new LinkedList<string>(formSimSetup.GetLeagueNamesFromDB());

            //adds each league name to a drop down menu
            for (int i = 0; i < leagueNames.Count(); i++)
            {
                comboBoxSelectLeague.Items.Add(leagueNames.ElementAt(i));
            }
        }


        //---------------------------------\\
        //---METHODS FOR DATABASE ACCESS---\\
        //---------------------------------\\


        private void GetSimmedResultsFromDB(string commandText, string leagueName, string team1, string team2, 
            ref LinkedList<int> ResultIDList, ref LinkedList<string> simHTeamList, ref LinkedList<string> simATeamList, ref LinkedList<string> LikelyScore1stList, ref LinkedList<double> simHXGList, ref LinkedList<double> simAXGList, ref LinkedList<int> SimsRunList, ref LinkedList<DateTime> DateSimmedList)
        {
            MySqlConnection connect = formSimSetup.ConnectToDB(); //fetches the connection string
            MySqlDataReader myDataReader; //used to read data from the database
            
            using (connect)
            {
                MySqlCommand selectDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                selectDataCommand.Parameters.Add("@userLeague", MySqlDbType.VarChar); //gives the expected data type of this placeholder in the SQL statement
                selectDataCommand.Parameters["@userLeague"].Value = leagueName; //gives the value for this placeholder

                //the SQL query will differ depending on whether the user chose 0, 1, or 2 specific teams to get results about
                if (team1 != null && team2 != null)
                {
                    //if two teams are selected, the query will have two additional placeholders
                    selectDataCommand.Parameters.Add("@userTeam1", MySqlDbType.VarChar);
                    selectDataCommand.Parameters["@userTeam1"].Value = team1;
                    selectDataCommand.Parameters.Add("@userTeam2", MySqlDbType.VarChar);
                    selectDataCommand.Parameters["@userTeam2"].Value = team2;
                }
                else if (team1 != null)
                {
                    //if only team1 is selected, the query will have an additional placeholder which will be given the value team1
                    selectDataCommand.Parameters.Add("@userTeam", MySqlDbType.VarChar);
                    selectDataCommand.Parameters["@userTeam"].Value = team1;
                }
                else if (team2 != null)
                {
                    //if only team2 is selected, the query will have an additional placeholder which will be given the value team2
                    selectDataCommand.Parameters.Add("@userTeam", MySqlDbType.VarChar);
                    selectDataCommand.Parameters["@userTeam"].Value = team2;
                }

                try //tries to run the query, and exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    myDataReader = selectDataCommand.ExecuteReader(); //executes the command

                    while (myDataReader.Read()) //while there is data to be read from the returned table; data is read one row at a time
                    {
                        //adds the value from the specified column index of the current row to the end of these linked lists
                        ResultIDList.AddLast(myDataReader.GetInt32(0));
                        simHTeamList.AddLast(myDataReader.GetString(1));
                        simATeamList.AddLast(myDataReader.GetString(2));
                        LikelyScore1stList.AddLast(myDataReader.GetString(3));
                        simHXGList.AddLast(myDataReader.GetDouble(4));
                        simAXGList.AddLast(myDataReader.GetDouble(5));
                        SimsRunList.AddLast(myDataReader.GetInt32(6));
                        DateSimmedList.AddLast(myDataReader.GetDateTime(7));
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

        private void GetRealResultsFromDB(string commandText, string leagueName, string team1, string team2, 
            ref LinkedList<string> realHTeamList, ref LinkedList<string> realATeamList, ref LinkedList<int> HGoalsList, ref LinkedList<int> AGoalsList, ref LinkedList<double> realHXGList, ref LinkedList<double> realAXGList, ref LinkedList<DateTime> DatePlayedList)
        {
            MySqlConnection connect = formSimSetup.ConnectToDB(); //fetches the connection string
            MySqlDataReader myDataReader; //used to read data from the database

            using (connect)
            {
                MySqlCommand selectDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to be executed in the database

                selectDataCommand.Parameters.Add("@userLeague", MySqlDbType.VarChar); //gives the expedted value of this placeholder in the SQL statement
                selectDataCommand.Parameters["@userLeague"].Value = leagueName; //gives the value for this placeholder

                //the SQL query will differ depending on whether the user chose 0, 1, or 2 specific teams to get results about
                if (team1 != null && team2 != null)
                {
                    //if two teams are selected, the query will have two additional placeholders
                    selectDataCommand.Parameters.Add("@userTeam1", MySqlDbType.VarChar);
                    selectDataCommand.Parameters["@userTeam1"].Value = team1;
                    selectDataCommand.Parameters.Add("@userTeam2", MySqlDbType.VarChar);
                    selectDataCommand.Parameters["@userTeam2"].Value = team2;
                }
                else if (team1 != null)
                {
                    //if only team1 is selected, the query will have an additional placeholder which will be given the value team1
                    selectDataCommand.Parameters.Add("@userTeam", MySqlDbType.VarChar);
                    selectDataCommand.Parameters["@userTeam"].Value = team1;
                }
                else if (team2 != null)
                {
                    //if only team2 is selected, the query will have an additional placeholder which will be given the value team2
                    selectDataCommand.Parameters.Add("@userTeam", MySqlDbType.VarChar);
                    selectDataCommand.Parameters["@userTeam"].Value = team2;
                }

                try //tries to run the query, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    myDataReader = selectDataCommand.ExecuteReader(); //executes the command

                    while (myDataReader.Read()) //while there is data to be read from the returned table; data is read one row at a time
                    {
                        //adds the value from the specified column index of the current row to the end of these linked lists
                        realHTeamList.AddLast(myDataReader.GetString(0));
                        realATeamList.AddLast(myDataReader.GetString(1));
                        HGoalsList.AddLast(myDataReader.GetInt32(2));
                        AGoalsList.AddLast(myDataReader.GetInt32(3));
                        realHXGList.AddLast(myDataReader.GetDouble(4));
                        realAXGList.AddLast(myDataReader.GetDouble(5));
                        DatePlayedList.AddLast(myDataReader.GetDateTime(6));
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


        //--------------------------------------------------\\
        //---METHODS FOR THE CONTROLS IN THE WINDOWS FORM---\\
        //--------------------------------------------------\\


        //this method is called whenever the selection in its drop down menu changes
        private void comboBoxSelectLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userLeague = comboBoxSelectLeague.SelectedItem.ToString();
            LinkedList<string> teamNames = new LinkedList<string>(formSimSetup.GetTeamNamesFromDB(userLeague));

            //clears the items in these drop down menus
            comboBoxSelectTeam1.Items.Clear();
            comboBoxSelectTeam2.Items.Clear();

            //adds the default selection 'All' to these drop down menus
            comboBoxSelectTeam1.Items.Add("All");
            comboBoxSelectTeam1.SelectedIndex = 0;
            comboBoxSelectTeam2.Items.Add("All");
            comboBoxSelectTeam2.SelectedIndex = 0;

            for (int i = 0; i < teamNames.Count(); i++)
            {
                //adds the fetched team names to these drop down menus
                comboBoxSelectTeam1.Items.Add(teamNames.ElementAt(i));
                comboBoxSelectTeam2.Items.Add(teamNames.ElementAt(i));
            }

            panelTeamsAndGetResults.Visible = true; //makes the team selections and 'Get results' button visible
        }

        //this method is called whenever its button is clicked
        private void buttonGetResults_Click(object sender, EventArgs e)
        {
            //displays the real and simulated results to the user
            panelRealResults.Visible = true;
            panelSimResults.Visible = true;

            ResultIDList = new LinkedList<int>();
            simHTeamList = new LinkedList<string>();
            simATeamList = new LinkedList<string>();
            LikelyScore1stList = new LinkedList<string>();
            LinkedList<double> simHXGList = new LinkedList<double>();
            LinkedList<double> simAXGList = new LinkedList<double>();
            SimsRunList = new LinkedList<int>();
            LinkedList<DateTime> DateSimmedList = new LinkedList<DateTime>();

            LinkedList<string> realHTeamList = new LinkedList<string>();
            LinkedList<string> realATeamList = new LinkedList<string>();
            LinkedList<int> HGoalsList = new LinkedList<int>();
            LinkedList<int> AGoalsList = new LinkedList<int>();
            LinkedList<double> realHXGList = new LinkedList<double>();
            LinkedList<double> realAXGList = new LinkedList<double>();
            LinkedList<DateTime> DatePlayedList = new LinkedList<DateTime>();

            string userTeam1, userTeam2, userLeague = comboBoxSelectLeague.SelectedItem.ToString();

            //if the selection is 'All', the variable is given the value 'null'.
            if (comboBoxSelectTeam1.SelectedIndex == 0)
            {
                userTeam1 = null;
            }
            else
            {
                userTeam1 = comboBoxSelectTeam1.SelectedItem.ToString();
            }

            if (comboBoxSelectTeam2.SelectedIndex == 0)
            {
                userTeam2 = null;
            }
            else
            {
                userTeam2 = comboBoxSelectTeam2.SelectedItem.ToString();
            }

            //different SQL queries are run depending on whether the user selected 0, 1, or 2 specific teams
            if (userTeam1 != null && userTeam2 != null)
            {
                GetSimmedResultsFromDB
                    ("SELECT result.ResultID, HTeam, ATeam, 1stLikelyScore, HxG, AxG, SimsRun, DateSimmed " +
                    "FROM team, result, teamresult, simscorelines " +
                    "WHERE team.TeamID = teamresult.TeamID AND teamresult.ResultID = result.ResultID AND result.SimScorelinesID = simscorelines.SimScorelinesID AND ((result.HTeam = @userTeam1 AND result.ATeam = @userTeam2) OR (result.HTeam = @userTeam2 AND result.ATeam = @userTeam1)) " +
                    "GROUP BY ResultID " +
                    "ORDER BY DateSimmed DESC", userLeague, userTeam1, userTeam2, ref ResultIDList, ref simHTeamList, ref simATeamList, ref LikelyScore1stList, ref simHXGList, ref simAXGList, ref SimsRunList, ref DateSimmedList);

                GetRealResultsFromDB
                    ("SELECT HTeam, ATeam, HGoals, AGoals, HxG, AxG, DatePlayed " +
                    "FROM previousgames, previousgamesteam, team " +
                    "WHERE team.TeamID = previousgamesteam.TeamID AND previousgamesteam.PreviousGamesID = previousgames.PreviousGamesID AND ((previousgames.HTeam = @userTeam1 AND previousgames.ATeam = @userTeam2) OR (previousgames.HTeam = @userTeam2 AND previousgames.ATeam = @userTeam1)) " +
                    "GROUP BY previousgames.PreviousGamesID " +
                    "ORDER BY DatePlayed DESC", userLeague, userTeam1, userTeam2, ref realHTeamList, ref realATeamList, ref HGoalsList, ref AGoalsList, ref realHXGList, ref realAXGList, ref DatePlayedList);
            }
            else if (userTeam1 != null || userTeam2 != null)
            {
                GetSimmedResultsFromDB
                    ("SELECT result.ResultID, HTeam, ATeam, 1stLikelyScore, HxG, AxG, SimsRun, DateSimmed " +
                    "FROM team, result, teamresult, simscorelines " +
                    "WHERE team.TeamName = @userTeam AND team.TeamID = teamresult.TeamID AND teamresult.ResultID = Result.ResultID AND result.SimScorelinesID = simscorelines.SimScorelinesID " +
                    "ORDER BY DateSimmed DESC", userLeague, userTeam1, userTeam2, ref ResultIDList, ref simHTeamList, ref simATeamList, ref LikelyScore1stList, ref simHXGList, ref simAXGList, ref SimsRunList, ref DateSimmedList);
                GetRealResultsFromDB
                    ("SELECT HTeam, ATeam, HGoals, AGoals, HxG, AxG, DatePlayed " +
                    "FROM previousgames, previousgamesteam, team " +
                    "WHERE team.TeamName = @userTeam AND team.TeamID = previousgamesteam.TeamID AND previousgamesteam.PreviousGamesID = previousgames.PreviousGamesID " +
                    "ORDER BY DatePlayed DESC", userLeague, userTeam1, userTeam2, ref realHTeamList, ref realATeamList, ref HGoalsList, ref AGoalsList, ref realHXGList, ref realAXGList, ref DatePlayedList);
            }
            else
            {
                GetSimmedResultsFromDB
                    ("SELECT result.ResultID, HTeam, ATeam, 1stLikelyScore, HxG, AxG, SimsRun, DateSimmed " +
                    "FROM team, result, teamresult, simscorelines, league " +
                    "WHERE league.LeagueName = @userLeague AND league.LeagueID = team.LeagueID AND team.TeamID = teamresult.TeamID AND teamresult.ResultID = result.ResultID AND result.SimScorelinesID = simscorelines.SimScorelinesID " +
                    "GROUP BY ResultID " +
                    "ORDER BY DateSimmed DESC", userLeague, userTeam1, userTeam2, ref ResultIDList, ref simHTeamList, ref simATeamList, ref LikelyScore1stList, ref simHXGList, ref simAXGList, ref SimsRunList, ref DateSimmedList);

                GetRealResultsFromDB("SELECT HTeam, ATeam, HGoals, AGoals, HxG, AxG, DatePlayed " +
                    "FROM previousgames, previousgamesteam, team, league " +
                    "WHERE league.LeagueName = @userLeague AND league.LeagueID = team.LeagueID AND team.TeamID = previousgamesteam.TeamID AND previousgamesteam.PreviousGamesID = previousgames.PreviousGamesID " +
                    "GROUP BY previousgames.PreviousGamesID " +
                    "ORDER BY DatePlayed DESC", userLeague, userTeam1, userTeam2, ref realHTeamList, ref realATeamList, ref HGoalsList, ref AGoalsList, ref realHXGList, ref realAXGList, ref DatePlayedList);
            }

            //clears the data grids
            dataGridSimResults.Rows.Clear();
            dataGridRealResults.Rows.Clear();

            for (int i = 0; i < ResultIDList.Count; i++)
            {
                //information about the simulated results are added to the data grid
                dataGridSimResults.Rows.Add("More", ResultIDList.ElementAt(i), simHTeamList.ElementAt(i), simATeamList.ElementAt(i), LikelyScore1stList.ElementAt(i), Math.Round(simHXGList.ElementAt(i), 2), Math.Round(simAXGList.ElementAt(i), 2), SimsRunList.ElementAt(i), DateSimmedList.ElementAt(i).ToString("yyyy-MM-dd"));
            }

            for (int i = 0; i < realHTeamList.Count; i++)
            {
                string scoreline = HGoalsList.ElementAt(i) + "-" + AGoalsList.ElementAt(i); //creates a string representing the score-line
                
                //information about the real results are added to the data grid
                dataGridRealResults.Rows.Add(realHTeamList.ElementAt(i), realATeamList.ElementAt(i), scoreline, Math.Round(realHXGList.ElementAt(i), 2), Math.Round(realAXGList.ElementAt(i), 2), DatePlayedList.ElementAt(i).ToString("yyyy-MM-dd")); //the DateTime element is formatted and the xG values are rounded to two decimal places
            }
        }

        //this method is called whenever its button is clicked
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide(); //this form is hidden
            formHome homeScreen = new formHome();
            homeScreen.Closed += (s, args) => this.Close(); //this form is closed when the homeScreen form is closed
            homeScreen.Show(); //displays homeScreen
        }

        //this method is called whenever one of the cells in its data grid is clicked
        private void dataGridSimResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //if the selected cell is in the first column
            {
                if (e.RowIndex >= 0) //if the selected cell is in a row that isn't the title row
                {
                    formMoreDetailsPopup moreDetailsPopup = new formMoreDetailsPopup(ResultIDList.ElementAt(e.RowIndex), simHTeamList.ElementAt(e.RowIndex), simATeamList.ElementAt(e.RowIndex), LikelyScore1stList.ElementAt(e.RowIndex), SimsRunList.ElementAt(e.RowIndex));
                    moreDetailsPopup.Show(); //displays moreDetailsPopUp
                    this.Closed += (s, args) => moreDetailsPopup.Close(); //when this form closes, moreDetailsPopup closes
                }
            }
        }
    }
}
