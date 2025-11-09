using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Match_Simulator
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent(); //required method for windows forms
        }

        //this method is called whenever its button is clicked
        private void buttonGoToSimSetup_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides the current form
            formSimSetup simSetupScreen = new formSimSetup();
            simSetupScreen.Closed += (s, args) => this.Close(); //this form is closed when simSetupScreen is closed
            simSetupScreen.Show(); //displays simSetupScreen
        }

        //this method is called whenever its button is clicked
        private void buttonGoToCompare_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides the current form
            formCompareResults compareResultsScreen = new formCompareResults();
            compareResultsScreen.Closed += (s, args) => this.Close(); //this form is closed when compareResultsScreen is closed
            compareResultsScreen.Show(); //displays compareResultsScreen
        }


        //UNUSED CONTROL METHODS THAT CAN'T BE DELETED

        private void formHome_Load(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        
    }
}
