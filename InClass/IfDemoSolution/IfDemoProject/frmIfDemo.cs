using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfDemoProject
{
    public partial class frmIfDemo : Form
    {
        public frmIfDemo()
        {
            InitializeComponent();
        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            string strTeamName;
            string strForecast;

            strTeamName = txtTeamName.Text;

            strTeamName = strTeamName.ToUpper();

            if(strTeamName == "PACKERS")
            {
                strForecast = "Super Bowl THIS time!";
            }
            else if( strTeamName == "Vikings")
            {
                strForecast = "Second in the division again";
            }
            else if( strTeamName == "Bears")
            {
                strForecast = "Give'em a hug!";
            }
            else
            {
                strForecast = "Is that a football team?";
            }

            lblForecast.Text = strForecast;
        }

        private void lblForecast_Click(object sender, EventArgs e)
        {

        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            int intGuess;
            string strFeedback = "";

            intGuess = Convert.ToInt32(txtGuess.Text);

            if(intGuess < 1 || intGuess > 20)
            {
                strFeedback = "Choose an Integer between 0 and 21";
                txtGuess.Focus();
            }
            else
            {
                if(intGuess == 13)
                {
                    strFeedback = "Congratulations! You win a free game!";
                }
                else if( intGuess > 13 && intGuess < 16)
                {
                    strFeedback = "Just a little bit higher. Guess a little bit lower";
                }
                else if (intGuess < 13 && intGuess > 10)
                {
                    strFeedback = "Just a little be lower. Guess a little bit higher";
                }
                else if (intGuess < 11)
                {
                    strFeedback = "Way too low! Guess higher.";
                }
                else if (intGuess > 15)
                {
                    strFeedback = "Way too high! Guess Lower.";
                }
                
            }

            lblFeedback.Text = strFeedback;
        }
    }
}
