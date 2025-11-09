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
    public partial class formMoreDetailsPopup : Form
    {
        public formMoreDetailsPopup(int ResultID, string hTeamName, string aTeamName, string likelyScore1st, int numSims)
        {
            InitializeComponent(); //required method for windows forms

            GetResultsScorelinesDetailsFromDB(ResultID, likelyScore1st, numSims);

            LinkedList<string> hPlayerNameList = new LinkedList<string>();
            LinkedList<double> hPlayerRatingList = new LinkedList<double>();
            LinkedList<string> hPlayerPosList = new LinkedList<string>();

            LinkedList<string> aPlayerNameList = new LinkedList<string>();
            LinkedList<double> aPlayerRatingList = new LinkedList<double>();
            LinkedList<string> aPlayerPosList = new LinkedList<string>();

            GetTeamSheetFromDB(ResultID, hTeamName, ref hPlayerNameList, ref hPlayerRatingList, ref hPlayerPosList, ref labelHScorer, ref labelHAssister);
            GetTeamSheetFromDB(ResultID, aTeamName, ref aPlayerNameList, ref aPlayerRatingList, ref aPlayerPosList, ref labelAScorer, ref labelAAssister);

            for (int i = 0; i < hPlayerNameList.Count; i++)
            {
                //information about the players in the team sheets are added to the data grid
                //player ratings are rounded to two decimal places
                dataGridHTeamSheet.Rows.Add(hPlayerNameList.ElementAt(i), Math.Round(hPlayerRatingList.ElementAt(i), 2), hPlayerPosList.ElementAt(i));
                dataGridATeamSheet.Rows.Add(aPlayerNameList.ElementAt(i), Math.Round(aPlayerRatingList.ElementAt(i), 2), aPlayerPosList.ElementAt(i));
            }
        }


        //---------------------------------\\
        //---METHODS FOR DATABASE ACCESS---\\
        //---------------------------------\\


        private void GetResultsScorelinesDetailsFromDB(int ResultID, string likelyScore1st, int numSims)
        {
            MySqlConnection connect = formSimSetup.ConnectToDB(); //fetches the connection string

            //SQL SELECT query
            string commandText = "SELECT HTactic, ATactic, RecentFormBias, HMorale, AMorale, HxWinProb, xDrawProb, AxWinProb, SimHWinProb, SimDrawProb, SimAWinProb, 1stOccurences, 2ndLikelyScore, 2ndOccurences, 3rdLikelyScore, 3rdOccurences, 4thLikelyScore, 4thOccurences, 5thLikelyScore, 5thOccurences " +
                "FROM result, simscorelines " +
                "WHERE result.ResultID = @ResultID AND result.SimScorelinesID = simscorelines.SimScorelinesID";

            MySqlDataReader myDataReader; //used to read data from the database
           
            using (connect)
            {
                MySqlCommand selectDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to be executed in the database

                selectDataCommand.Parameters.Add("@ResultID", MySqlDbType.Int32); //gives the expected data type for this placeholder in the SQL statement
                selectDataCommand.Parameters["@ResultID"].Value = ResultID; //gives the value for this placeholder

                try //tries to run the query, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    myDataReader = selectDataCommand.ExecuteReader(); //executes the commmand
                    myDataReader.Read(); //reads the first row of the returned table

                    //the text for these labels is set as the values in the first and second column
                    labelHTeamTact.Text = myDataReader.GetString(0);
                    labelATeamTact.Text = myDataReader.GetString(1);

                    //the text for this label is set depending on the value of the third column
                    if (myDataReader.GetBoolean(2) == true)
                    {
                        labelFormBias.Text = "Yes";
                    }
                    else
                    {
                        labelFormBias.Text = "No";
                    }

                    //the text for these labels is set as the values in the fourth and fifth column
                    labelHTeamMorale.Text = myDataReader.GetString(3);
                    labelATeamMorale.Text = myDataReader.GetString(4);

                    //adds bars to the bar chart using values from the sixth column to the eleveneth. The values are converted to percentages and rounded to two decimal places. The bars are also labelled with these percentages
                    chartWinDrawProb.Series["Expected probability"].Points.AddXY("Home win", myDataReader.GetDouble(5) * 100);
                    chartWinDrawProb.Series["Expected probability"].Points[0].Label = Math.Round(myDataReader.GetDouble(5) * 100, 2).ToString();

                    chartWinDrawProb.Series["Expected probability"].Points.AddXY("Draw", myDataReader.GetDouble(6) * 100);
                    chartWinDrawProb.Series["Expected probability"].Points[1].Label = Math.Round(myDataReader.GetDouble(6) * 100, 2).ToString();

                    chartWinDrawProb.Series["Expected probability"].Points.AddXY("Away win", myDataReader.GetDouble(7) * 100);
                    chartWinDrawProb.Series["Expected probability"].Points[2].Label = Math.Round(myDataReader.GetDouble(7) * 100, 2).ToString();

                    chartWinDrawProb.Series["Simulation occurences"].Points.AddXY("Home win", myDataReader.GetDouble(8));
                    chartWinDrawProb.Series["Simulation occurences"].Points[0].Label = Math.Round(myDataReader.GetDouble(8), 2).ToString();

                    chartWinDrawProb.Series["Simulation occurences"].Points.AddXY("Draw", myDataReader.GetDouble(9));
                    chartWinDrawProb.Series["Simulation occurences"].Points[1].Label = Math.Round(myDataReader.GetDouble(9), 2).ToString();

                    chartWinDrawProb.Series["Simulation occurences"].Points.AddXY("Away win", myDataReader.GetDouble(10));
                    chartWinDrawProb.Series["Simulation occurences"].Points[2].Label = Math.Round(myDataReader.GetDouble(10), 2).ToString();

                    //adds points to the pie chart with x-value: score-line and y-value: number of occurences
                    chartScorelines.Series["Scorelines"].Points.AddXY(likelyScore1st, myDataReader.GetInt32(11));

                    chartScorelines.Series["Scorelines"].Points.AddXY(myDataReader.GetString(12), myDataReader.GetInt32(13));

                    chartScorelines.Series["Scorelines"].Points.AddXY(myDataReader.GetString(14), myDataReader.GetInt32(15));

                    chartScorelines.Series["Scorelines"].Points.AddXY(myDataReader.GetString(16), myDataReader.GetInt32(17));

                    chartScorelines.Series["Scorelines"].Points.AddXY(myDataReader.GetString(18), myDataReader.GetInt32(19));

                    //adds up the occurences of the five score-lines from the database
                    int chartedOccurences = myDataReader.GetInt32(11) + myDataReader.GetInt32(13) + myDataReader.GetInt32(15) + myDataReader.GetInt32(17) + myDataReader.GetInt32(19);
                    if (chartedOccurences != numSims)
                    {
                        chartScorelines.Series["Scorelines"].Points.AddXY("other", numSims - chartedOccurences); //adds a point to the pie chart showing how many occurences were not put on the chart
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

        private void GetTeamSheetFromDB(int ResultID, string teamName, 
            ref LinkedList<string> PlayerNameList, ref LinkedList<double> RatingList, ref LinkedList<string> PositionList, ref Label labelScorer, ref Label labelAssister)
        {
            MySqlConnection connect = formSimSetup.ConnectToDB(); //fetches the connection string

            //SQL SELECT query
            string commandText = "SELECT PlayerName, Rating, Position, MostLikelyScorer, MostLikelyAssister " +
               "FROM player, playerresult, team " +
               "WHERE playerresult.ResultID = @ResultID AND playerresult.PlayerID = player.PlayerID AND player.TeamID = team.TeamID AND Team.TeamName = @userTeam " +
               "ORDER BY Position, Rating DESC";

            MySqlDataReader myDataReader; //used to read data from the database
           
            using (connect)
            {
                MySqlCommand selectDataCommand = new MySqlCommand(commandText, connect); //represents the SQL statement to be executed in the database

                //placeholders in the SQL statement are given an expected data type and value
                selectDataCommand.Parameters.Add("@ResultID", MySqlDbType.Int32);
                selectDataCommand.Parameters["@ResultID"].Value = ResultID;

                selectDataCommand.Parameters.Add("@userTeam", MySqlDbType.VarChar);
                selectDataCommand.Parameters["@userTeam"].Value = teamName;

                try //tries to run the query, any exceptions or issues will be caught
                {
                    connect.Open(); //opens the connection to the database
                    myDataReader = selectDataCommand.ExecuteReader(); //executes the command
                    
                    while(myDataReader.Read()) //while there is data to be read from the returned table; data is read one row at a time
                    {
                        //adds the value from the specified column index of the current row to the end of these linked lists
                        PlayerNameList.AddLast(myDataReader.GetString(0));
                        RatingList.AddLast(myDataReader.GetDouble(1));
                        PositionList.AddLast(myDataReader.GetString(2));

                        //if a player is the most likely scorer, the text in the label is set to their name
                        if (myDataReader.GetBoolean(3) == true)
                        {
                            labelScorer.Text = myDataReader.GetString(0);
                        }

                        //if a player is the most likely assister, the text in the label is set to their name
                        if (myDataReader.GetBoolean(4) == true)
                        {
                            labelAssister.Text = myDataReader.GetString(0);
                        }
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
    }
}
