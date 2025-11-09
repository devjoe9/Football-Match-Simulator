using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //adds sound features

namespace Football_Match_Simulator
{
    public partial class formPlayback : Form
    {
        int[] mins = new int[90];

        public formPlayback(int hGoals, int aGoals, string hTeamAbbrev, string aTeamAbbrev)
        {
            this.BackgroundImage = Properties.Resources.football_pitch; //sets the background image for the form
            this.BackgroundImageLayout = ImageLayout.Stretch; //stretches the background image to fit the form

            InitializeComponent(); //required method for windows forms

            //labels are given text
            labelHTeam.Text = hTeamAbbrev;
            labelATeam.Text = aTeamAbbrev;
            labelMatchClock.Text = "0";
            labelHGoals.Text = "0";
            labelAGoals.Text = "0";

            AssignGoalsToMins(ref mins, hGoals, "home");
            AssignGoalsToMins(ref mins, aGoals, "away");
        }

        private void AssignGoalsToMins(ref int[] mins, int goals, string type)
        {
            bool valid = false;
            Random rand = new Random();

            for (int i = 1; i <= goals; i++)
            {
                while (!valid)
                {
                    int randomNum = rand.Next(1, 90); //a number between 1 and 90 but not including 90 is selected
                    if (mins[randomNum] == 0) //if a goal isn't already assigned to that minute
                    {
                        if (type == "home")
                        {
                            mins[randomNum] = 1; //home goals are represented by the number 1
                        }
                        else if (type == "away")
                        {
                            mins[randomNum] = -1; //away goals are represented by the number -1
                        }
                        valid = true;
                    }
                }
                valid = false;
            }
        }

        private void PlayGoalSound()
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.football_goal_sound_effect);
            audio.Play(); //plays the audio file
        }

        private void PlayHalfTimeWhistleSound()
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.half_time_whistle_sound_effect);
            audio.Play(); //plays the audio file
        }

        private void PlayFullTimeWhistleSound()
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.full_time_whistle_sound_effect);
            audio.Play(); //plays the audio file
        }

        //this method is called whenever its button is clicked
        private void buttonStartPlayback_Click(object sender, EventArgs e)
        {
            buttonStartPlayback.Visible = false; //hides the button
            panelMatchDisplay.Visible = true; //shows the match display
            clockMatch.Start(); //starts the clock clockMatch
        }


        //--------------------------------------------------\\
        //---METHODS FOR THE CONTROLS IN THE WINDOWS FORM---\\
        //--------------------------------------------------\\


        //this method is called whenever its clock ticks
        private void clockMatch_Tick(object sender, EventArgs e)
        {
            int minute = int.Parse(labelMatchClock.Text) + 1; //assigns the current minute of labelMatchClock to a variable and adds 1
            if (minute <= 90)
            {
                labelMatchClock.Text = minute.ToString(); //changes the text (minute) of labelMatchClock
                if (mins[minute - 1] == 1) //if there is a home goal assigned to the current minute
                {
                    int goals = int.Parse(labelHGoals.Text) + 1; //assigns the current text of labelHGoals to a variable and adds 1
                    labelHGoals.Text = goals.ToString(); //changes the text (number of goals) of labelHGoals
                    clockMatch.Stop(); //stops the clock clockMatch
                    labelGoal.Visible = true; //displays a 'GOAL'
                    PlayGoalSound();
                    clockGoalPause.Start(); //starts the clock clockGoalPause
                }
                else if (mins[minute - 1] == -1) //if there is an away goal assigned to the current minute
                {
                    int goals = int.Parse(labelAGoals.Text) + 1; //assigns the current text of labelAGoals to a variable and adds 1
                    labelAGoals.Text = goals.ToString(); //changes the text (number of goals) of labelAGoals
                    clockMatch.Stop(); //stops the clock clockMatch
                    labelGoal.Visible = true; //displays a 'GOAL' label
                    PlayGoalSound();
                    clockGoalPause.Start(); //starts the clock clockGoalPause
                }
            }

            if (minute == 45)
            {
                clockMatch.Stop(); //stops the clock clockMatch
                labelHalfTime.Visible = true; //displays a 'Half-time' label
                PlayHalfTimeWhistleSound();
                clockHalfTimePause.Start(); //starts the clock clockHalfTimePause
            }
            else if (minute == 90)
            {
                clockMatch.Stop(); //stops the clock clockMatch
                labelFullTime.Visible = true; //displays a 'Full-time' label
                PlayFullTimeWhistleSound();
                buttonGoToResults.Visible = true; //allows the user to exit the playback and see the results of the simulation(s)
            }
        }

        //this method is called whenever its clock ticks
        private void clockGoalPause_Tick(object sender, EventArgs e)
        {
            labelGoal.Visible = false; //hides this label
            clockGoalPause.Stop(); //stops this clock
            clockMatch.Start(); //starts this clock
        }

        //this method is called whenever its clock ticks
        private void clockHalfTimePause_Tick(object sender, EventArgs e)
        {
            labelHalfTime.Visible = false; //hides this label
            clockHalfTimePause.Stop(); //stops this clock
            clockMatch.Start(); //starts this clock
        }

        //this method is called whenever its button is pressed
        private void buttonGoToResults_Click(object sender, EventArgs e)
        {
            this.Close(); //closes this form
        }


        //--------------------------------------------------\\
        //---UNUSED CONTROL METHODS THAT CAN'T BE DELETED---\\
        //--------------------------------------------------\\


        private void formPlayback_Load(object sender, EventArgs e)
        {

        }

        private void panelMatchDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelGoal_Click(object sender, EventArgs e)
        {

        }
    }
}
