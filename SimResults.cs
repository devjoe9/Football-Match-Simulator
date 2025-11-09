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
    public partial class formSimResults : Form
    {
        formSimSetup simSetupScreen = Application.OpenForms.OfType<formSimSetup>().Last(); //initialises the still-open form simSetupScreen in this form to allow it to use its public variables

        bool forceClose = true, resultsSaved = false;
        double simHWinProb, simDrawProb, simAWinProb;
        string[] scorelineArray;
        int[] scorelineArrayOccurences;

        public formSimResults()
        {
            InitializeComponent(); //required method for windows forms

            //

            PlotBarChart();
            PlotPieChart();

            //

            //labels are given text
            labelNumSims.Text += simSetupScreen.userNumSims;
            labelHTeamName.Text = simSetupScreen.userHTeam;
            labelATeamName.Text = simSetupScreen.userATeam;
            labelHxG.Text = Math.Round(simSetupScreen.hXG, 2).ToString();
            labelAxG.Text = Math.Round(simSetupScreen.aXG, 2).ToString();
            labelHScorer.Text = simSetupScreen.likelyHScorer;
            labelAScorer.Text = simSetupScreen.likelyAScorer;
            labelHAssister.Text = simSetupScreen.likelyHAssister;
            labelAAssister.Text = simSetupScreen.likelyAAssister;

            //
            
            int[,] copyOccurenceArray = new int[10, 10];
            //copies all elements of occurenceArray into a copy array (doing copyOccurenceArray = simSetupScreen.OccurenceArray doesn't directly copy)
            for (int i = 0; i < copyOccurenceArray.GetLength(0); i++)
            {
                for (int j = 0; j < copyOccurenceArray.GetLength(1); j++)
                {
                    copyOccurenceArray[i, j] = simSetupScreen.occurenceArray[i, j];
                }
            }

            scorelineArray = new string[5];
            scorelineArrayOccurences = new int[5];
            int numScorelines, loopNum = 0, highestOccTotalGoals = 0;

            //a maximum of five score-lines from the simulation(s) will be displayed separately and saved
            if (simSetupScreen.userNumSims >= 5)
            {
                numScorelines = 5;
            }
            else
            {
                numScorelines = simSetupScreen.userNumSims;
            }

            while (loopNum != numScorelines)
            {
                Tuple<int, int> highestOccScoreline = formSimSetup.GetHighestOccScoreline(copyOccurenceArray);
                int highestOccHGoals = highestOccScoreline.Item1, highestOccAGoals = highestOccScoreline.Item2;

                if (loopNum == 0)
                {
                    highestOccTotalGoals = highestOccHGoals + highestOccAGoals; //keeps track of the total goals of the most occuring score-line
                }
                scorelineArray[loopNum] = highestOccHGoals + "-" + highestOccAGoals; //adds the score-line in string form to the array
                scorelineArrayOccurences[loopNum] = copyOccurenceArray[highestOccHGoals, highestOccAGoals]; //adds the occurences of the corresponding score-line to the array
                copyOccurenceArray[highestOccHGoals, highestOccAGoals] = 0; //sets the occurences of the score-line in the copy array to 0 to be able to run the same loop and find the next most occuring score-line
                loopNum += 1;
            }

            //labels are given text
            if (highestOccTotalGoals == 0)
            {
                labelOvers.Text += "N/A"; //'Overs' cannot be negative
            }
            else
            {
                labelOvers.Text += (highestOccTotalGoals - 0.5).ToString();
            }
            labelUnders.Text += (highestOccTotalGoals + 0.5).ToString();
            labelScoreline1.Text = scorelineArray[0];
            labelScoreline2.Text = scorelineArray[1];
            labelScoreline3.Text = scorelineArray[2];
            labelScoreline4.Text = scorelineArray[3];
            labelScoreline5.Text = scorelineArray[4];
            //the text for these labels are the occurences as a percentage of the total number of simulations
            //converted to double to ensure division returns a decimal number rather than rounding
            labelOccurPercent1.Text = (Convert.ToDouble(scorelineArrayOccurences[0]) / simSetupScreen.userNumSims * 100).ToString();
            labelOccurPercent2.Text = (Convert.ToDouble(scorelineArrayOccurences[1]) / simSetupScreen.userNumSims * 100).ToString();
            labelOccurPercent3.Text = (Convert.ToDouble(scorelineArrayOccurences[2]) / simSetupScreen.userNumSims * 100).ToString();
            labelOccurPercent4.Text = (Convert.ToDouble(scorelineArrayOccurences[3]) / simSetupScreen.userNumSims * 100).ToString();
            labelOccurPercent5.Text = (Convert.ToDouble(scorelineArrayOccurences[4]) / simSetupScreen.userNumSims * 100).ToString();
        }

        public void SimResultsScreen_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (forceClose)
            {
                simSetupScreen.Close();
            }
        }


        //---------------------------------\\
        //---METHODS FOR DATABASE ACCESS---\\
        //---------------------------------\\


        private string GetPlayerIDFromDB(string playerName)
        {
            MySqlConnection connect = formSimSetup.ConnectToDB(); //fetches the connection string

            //SQL SELECT query
            string commandText = "SELECT PlayerID " +
                "FROM player " +
                "WHERE player.PlayerName = @userPlayerName";

            MySqlDataReader myDataReader; //used to read data from the database

            string playerID = "";

            using (connect)
            {
                MySqlCommand selectDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                selectDataCommand.Parameters.Add("@userPlayerName", MySqlDbType.VarChar); //gives the expected data type of this placeholder in the SQL statement
                selectDataCommand.Parameters["@userPlayerName"].Value = playerName; //gives the value for this placeholder

                try  //tries to run the query, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    myDataReader = selectDataCommand.ExecuteReader(); //executes the command
                    myDataReader.Read(); //reads the first row of the returned table
                    playerID = myDataReader.GetString(0); //assigns the value in the first column to a variable

                    myDataReader.Close(); //closes the stream
                    connect.Close(); //closes the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return playerID;
        }

        private void InsertIntoTablesimscorelines(string[] scorelineArray, int[] scorelineArrayOccurences)
        {
            MySqlConnection connect = formSimSetup.ConnectToDB(); //fetches the connection string

            //SQL INSERT INTO statement
            string commandText = "INSERT INTO simscorelines(1stLikelyScore, 1stOccurences, 2ndLikelyScore, 2ndOccurences, 3rdLikelyScore, 3rdOccurences, 4thLikelyScore, 4thOccurences, 5thLikelyScore, 5thOccurences) " +
                "VALUES (@scoreline1, @occurences1, @scoreline2, @occurences2, @scoreline3, @occurences3, @scoreline4, @occurences4, @scoreline5, @occurences5)";

            using (connect)
            {
                MySqlCommand insertDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                //placeholders in the SQL statement are given an expected data type and value
                insertDataCommand.Parameters.Add("@scoreline1", MySqlDbType.VarChar);
                insertDataCommand.Parameters["@scoreline1"].Value = scorelineArray[0];
                insertDataCommand.Parameters.Add("@occurences1", MySqlDbType.Int32);
                insertDataCommand.Parameters["@occurences1"].Value = scorelineArrayOccurences[0];

                insertDataCommand.Parameters.Add("@scoreline2", MySqlDbType.VarChar);
                insertDataCommand.Parameters["@scoreline2"].Value = scorelineArray[1];
                insertDataCommand.Parameters.Add("@occurences2", MySqlDbType.Int32);
                insertDataCommand.Parameters["@occurences2"].Value = scorelineArrayOccurences[1];

                insertDataCommand.Parameters.Add("@scoreline3", MySqlDbType.VarChar);
                insertDataCommand.Parameters["@scoreline3"].Value = scorelineArray[2];
                insertDataCommand.Parameters.Add("@occurences3", MySqlDbType.Int32);
                insertDataCommand.Parameters["@occurences3"].Value = scorelineArrayOccurences[2];

                insertDataCommand.Parameters.Add("@scoreline4", MySqlDbType.VarChar);
                insertDataCommand.Parameters["@scoreline4"].Value = scorelineArray[3];
                insertDataCommand.Parameters.Add("@occurences4", MySqlDbType.Int32);
                insertDataCommand.Parameters["@occurences4"].Value = scorelineArrayOccurences[3];

                insertDataCommand.Parameters.Add("@scoreline5", MySqlDbType.VarChar);
                insertDataCommand.Parameters["@scoreline5"].Value = scorelineArray[4];
                insertDataCommand.Parameters.Add("@occurences5", MySqlDbType.Int32);
                insertDataCommand.Parameters["@occurences5"].Value = scorelineArrayOccurences[4];

                try //tries to run the SQL statement, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    insertDataCommand.ExecuteReader(); //executes the command

                    connect.Close(); //closes the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connect == null)
                    {
                        MessageBox.Show("Failed to save");
                    }
                }
            }
        }

        private void InsertIntoTableresult()
        {
            MySqlConnection connect = formSimSetup.ConnectToDB(); //fetches the connection

            //SQL INSERT INTO statement
            string commandText = "INSERT INTO result(HTeam, ATeam, SimsRun, HTactic, ATactic, RecentFormBias, HMorale, AMorale, HxG, AxG, HxWinProb, xDrawProb, AxWinProb, SimHWinProb, SimDrawProb, SimAWinProb, DateSimmed, SimScorelinesID) " +
                "VALUES(@userHTeam, @userATeam, @userSimsRun, @userHTactic, @userATactic, @userRecentFormBias, @userHMorale, @userAMorale, @hXG, @aXG, @hXWinProb, @xDrawProb, @aXWinProb, @simHWinProb, @simDrawProb, @simAWinProb, @date, LAST_INSERT_ID())";

            using (connect)
            {
                MySqlCommand insertDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                //placeholders in the SQL statement are given an expected data type and value
                insertDataCommand.Parameters.Add("@userHTeam", MySqlDbType.VarChar);
                insertDataCommand.Parameters["@userHTeam"].Value = simSetupScreen.userHTeam;

                insertDataCommand.Parameters.Add("@userATeam", MySqlDbType.VarChar);
                insertDataCommand.Parameters["@userATeam"].Value = simSetupScreen.userATeam;

                insertDataCommand.Parameters.Add("@userSimsRun", MySqlDbType.Int32);
                insertDataCommand.Parameters["@userSimsRun"].Value = simSetupScreen.userNumSims;

                insertDataCommand.Parameters.Add("@userHTactic", MySqlDbType.VarChar);
                insertDataCommand.Parameters["@userHTactic"].Value = simSetupScreen.userHTactic;

                insertDataCommand.Parameters.Add("@userATactic", MySqlDbType.VarChar);
                insertDataCommand.Parameters["@userATactic"].Value = simSetupScreen.userATactic;

                insertDataCommand.Parameters.Add("@userRecentFormBias", MySqlDbType.Bit);
                insertDataCommand.Parameters["@userRecentFormBias"].Value = simSetupScreen.userFormBias;

                insertDataCommand.Parameters.Add("@userHMorale", MySqlDbType.VarChar);
                insertDataCommand.Parameters["@userHMorale"].Value = simSetupScreen.userHMorale;

                insertDataCommand.Parameters.Add("@userAMorale", MySqlDbType.VarChar);
                insertDataCommand.Parameters["@userAMorale"].Value = simSetupScreen.userAMorale;

                insertDataCommand.Parameters.Add("@hXG", MySqlDbType.Float);
                insertDataCommand.Parameters["@hXG"].Value = simSetupScreen.hXG;

                insertDataCommand.Parameters.Add("@aXG", MySqlDbType.Float);
                insertDataCommand.Parameters["@aXG"].Value = simSetupScreen.aXG;

                insertDataCommand.Parameters.Add("@hXWinProb", MySqlDbType.Float);
                insertDataCommand.Parameters["@hXwinProb"].Value = simSetupScreen.hXWinProb;

                insertDataCommand.Parameters.Add("@xDrawProb", MySqlDbType.Float);
                insertDataCommand.Parameters["@xDrawProb"].Value = simSetupScreen.xDrawProb;

                insertDataCommand.Parameters.Add("aXWinProb", MySqlDbType.Float);
                insertDataCommand.Parameters["@aXwinProb"].Value = simSetupScreen.aXWinProb;

                insertDataCommand.Parameters.Add("@simHWinProb", MySqlDbType.Float);
                insertDataCommand.Parameters["@simHWinProb"].Value = simHWinProb;

                insertDataCommand.Parameters.Add("@simDrawProb", MySqlDbType.Float);
                insertDataCommand.Parameters["@simDrawProb"].Value = simDrawProb;

                insertDataCommand.Parameters.Add("@simAWinProb", MySqlDbType.Float);
                insertDataCommand.Parameters["@simAWinProb"].Value = simAWinProb;

                insertDataCommand.Parameters.Add("@date", MySqlDbType.Date);
                insertDataCommand.Parameters["@date"].Value = DateTime.Now.ToString("yyyy-MM-dd");

                try //tries to run the SQL statement, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the conenction to the database
                    insertDataCommand.ExecuteReader(); // executes the command

                    connect.Close(); //closes the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connect == null)
                    {
                        MessageBox.Show("Failed to save");
                    }
                }
            }
        }

        private void InsertIntoTableteamresult(string teamAbbrev)
        {
            MySqlConnection connect = formSimSetup.ConnectToDB(); //fetches the connection string

            //SQL INSERT INTO statement
            string commandText = "INSERT INTO teamresult " +
                "VALUES(@teamID, LAST_INSERT_ID())";

            using (connect)
            {
                MySqlCommand insertDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                insertDataCommand.Parameters.Add("@teamID", MySqlDbType.VarChar); //gives the expected data type of this placeholder in the SQL statement
                insertDataCommand.Parameters["@teamID"].Value = teamAbbrev; //gives the value for this placeholder

                try //tries to run the SQL statement, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    insertDataCommand.ExecuteReader(); //executes the command
                    
                    connect.Close(); //closes the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connect == null)
                    {
                        MessageBox.Show("Failed to save");
                    }
                }
            }
        }

        private void InsertIntoTableplayerresult(string playerID, string playerName)
        {
            MySqlConnection connect = formSimSetup.ConnectToDB(); //fetches the connection string

            //SQL INSERT INTO statement
            string commandText = "INSERT INTO playerresult " +
                "VALUES(@playerID, LAST_INSERT_ID(), @mostLikelyScorer, @mostLikelyAssister)";

            using (connect)
            {
                MySqlCommand insertDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to execute in the database

                //placeholders in the SQL query are given an expected data type and value
                insertDataCommand.Parameters.Add("@playerID", MySqlDbType.VarChar);
                insertDataCommand.Parameters["@playerID"].Value = playerID;

                insertDataCommand.Parameters.Add("@mostLikelyScorer", MySqlDbType.Bit);
                if (playerName == simSetupScreen.likelyHScorer || playerName == simSetupScreen.likelyAScorer) //if a player is the most likely to score, the value in the corresponding field will be true, otherwise false
                {
                    insertDataCommand.Parameters["@mostLikelyScorer"].Value = true;
                }
                else
                {
                    insertDataCommand.Parameters["@mostLikelyScorer"].Value = false;
                }

                insertDataCommand.Parameters.Add("@mostLikelyAssister", MySqlDbType.Bit);
                if (playerName == simSetupScreen.likelyHAssister || playerName == simSetupScreen.likelyAAssister) //if a player is the most likely to assist, the value in the corresponding field will be true, otherwise false
                {
                    insertDataCommand.Parameters["@mostLikelyAssister"].Value = true;
                }
                else
                {
                    insertDataCommand.Parameters["@mostLikelyAssister"].Value = false;
                }

                try //tries to run the SQL statement, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    insertDataCommand.ExecuteReader(); //executes the command

                    connect.Close(); //closes the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connect == null)
                    {
                        MessageBox.Show("Failed to save");
                    }
                }
            }
        }


        //
        //
        //


        private void PlotBarChart()
        {
            simHWinProb = 0;
            simDrawProb = 0;
            simAWinProb = 0;

            for (int i = 0; i < simSetupScreen.occurenceArray.GetLength(0); i++)
            {
                for (int j = 0; j < simSetupScreen.occurenceArray.GetLength(1); j++)
                {
                    //separately adds up all occurences in occurenceArray where the home team wins, away team wins, and a draw occurs
                    if (i > j)
                    {
                        simHWinProb += simSetupScreen.occurenceArray[i, j];
                    }
                    else if (i < j)
                    {
                        simAWinProb += simSetupScreen.occurenceArray[i, j];
                    }
                    else
                    {
                        simDrawProb += simSetupScreen.occurenceArray[i, j];
                    }
                }
            }

            //converts these values to percentages of the total number of simulations run
            simHWinProb = (simHWinProb / simSetupScreen.userNumSims) * 100;
            simDrawProb = (simDrawProb / simSetupScreen.userNumSims) * 100;
            simAWinProb = (simAWinProb / simSetupScreen.userNumSims) * 100;

            //adds bars to the bar chart and labels the bars with their y-value (labels rounded to two decimal places)
            //bars for simulation occurences:
            chartWinDrawProb.Series["Simulation occurences"].Points.AddXY("Home win", simHWinProb);
            chartWinDrawProb.Series["Simulation occurences"].Points[0].Label = Math.Round(simHWinProb, 2).ToString();

            chartWinDrawProb.Series["Simulation occurences"].Points.AddXY("Draw", simDrawProb);
            chartWinDrawProb.Series["Simulation occurences"].Points[1].Label = Math.Round(simDrawProb, 2).ToString();

            chartWinDrawProb.Series["Simulation occurences"].Points.AddXY("Away win", simAWinProb);
            chartWinDrawProb.Series["Simulation occurences"].Points[2].Label = Math.Round(simAWinProb, 2).ToString();

            //bars for expected probability (probabilities converted to percentages):
            chartWinDrawProb.Series["Expected probability"].Points.AddXY("Home win", simSetupScreen.hXWinProb * 100);
            chartWinDrawProb.Series["Expected probability"].Points[0].Label = Math.Round(simSetupScreen.hXWinProb * 100, 2).ToString();

            chartWinDrawProb.Series["Expected probability"].Points.AddXY("Draw", simSetupScreen.xDrawProb * 100);
            chartWinDrawProb.Series["Expected probability"].Points[1].Label = Math.Round(simSetupScreen.xDrawProb * 100, 2).ToString();

            chartWinDrawProb.Series["Expected probability"].Points.AddXY("Away win", simSetupScreen.aXWinProb * 100);
            chartWinDrawProb.Series["Expected probability"].Points[2].Label = Math.Round(simSetupScreen.aXWinProb * 100, 2).ToString();
        }

        private void PlotPieChart()
        {
            int chartedOccurences = 0;

            for (int i = 0; i < simSetupScreen.occurenceArray.GetLength(0); i++)
            {
                for (int j = 0; j < simSetupScreen.occurenceArray.GetLength(1); j++)
                {
                    if (simSetupScreen.occurenceArray[i, j] >= simSetupScreen.userNumSims * 0.025) //if the score-line occured at least 2.5% of the time
                    {
                        string scoreline = i.ToString() + "-" + j.ToString(); //creates a string representing a score-line
                        chartScorelines.Series["Scorelines"].Points.AddXY(scoreline, simSetupScreen.occurenceArray[i, j]); //adds a point to the pie chart with x-value: scoreline and y-value: number of occurences 
                        chartedOccurences += simSetupScreen.occurenceArray[i, j]; //keeps track of how many simulations have been put on the chart
                    }
                }
            }

            if (chartedOccurences != simSetupScreen.userNumSims)
            {
                chartScorelines.Series["Scorelines"].Points.AddXY("other", simSetupScreen.userNumSims - chartedOccurences); //adds a point to the pie chart showing how many occurences were not put on the chart
            }
        }


        //--------------------------------------------------\\
        //---METHODS FOR THE CONTROLS IN THE WINDOWS FORM---\\
        //--------------------------------------------------\\


        //this method is called whenever its button is clicked
        private void buttonSaveResults_Click(object sender, EventArgs e)
        {
            if (!resultsSaved) //prevents the user repeatedly saving the current simulation results
            {
                string hTeamAbbrev = simSetupScreen.GetTeamAbrrev(simSetupScreen.userHTeam);
                string aTeamAbbrev = simSetupScreen.GetTeamAbrrev(simSetupScreen.userATeam);

                //the simulation results and settings/variables are saved into the database
                InsertIntoTablesimscorelines(scorelineArray, scorelineArrayOccurences);
                InsertIntoTableresult();
                InsertIntoTableteamresult(hTeamAbbrev);
                InsertIntoTableteamresult(aTeamAbbrev);

                for (int i = 0; i < simSetupScreen.userHTeamSheetNames.Length; i++)
                {
                    InsertIntoTableplayerresult(GetPlayerIDFromDB(simSetupScreen.userHTeamSheetNames[i]), simSetupScreen.userHTeamSheetNames[i]);
                    InsertIntoTableplayerresult(GetPlayerIDFromDB(simSetupScreen.userATeamSheetNames[i]), simSetupScreen.userATeamSheetNames[i]);
                }

                MessageBox.Show("Finished saving");
                resultsSaved = true;
            }
            else
            {
                MessageBox.Show("Results already saved");
            }
        }

        //this method is called whenever its button is clicked
        private void buttonGoHomeScreen_Click(object sender, EventArgs e)
        {
            forceClose = true; //this allows simSetupScreen to close
            this.Hide(); //hides the current form
            formHome homeScreen = new formHome();
            homeScreen.Closed += (s, args) => this.Close(); //this form is closed when homeScreen is closed
            homeScreen.Show(); //displays homeScreen
        }

        //this method is called whenever its button is clicked
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            forceClose = false; //this prevents simSetupScreen from closing
            simSetupScreen.Show(); //re-displays simSetupScreen
            this.Close(); //closes this form
        }
    }
}
