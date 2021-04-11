/***
 *  Seng Yang
 *  Wind Chill Calculator Assignment
 *  Class: IS-304
 *  This program is used to calculate the wind chill by using
 *  air temperature and wind speed.
 ***/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SengYangWindChillCalculatorProject
{
    public partial class frmWindChillCalculator : Form
    {
        public frmWindChillCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*** Local Constant ***/

            const double dblPower = 0.16;

            /*** Local Variables ***/

            double dblAirTemperature;
            double dblWindSpeed;
            double dblWindChill = 0.0;
            string strFrostbiteTime = "";

            /*** User input ***/

            dblAirTemperature = Convert.ToDouble(txtTemperature.Text);
            dblWindSpeed = Convert.ToDouble(txtWindSpeed.Text);

            /*** If temperature is less than 50.0 degrees
             *   and wind speed is greater than or equal to 3 miles per hour
             *   then do the calculation for wind chill 
             ***/
            if(dblAirTemperature <= 50.0 && dblWindSpeed >= 3.0)
            {
                /*** Calculates the wind chill with the formula provided ***/
                dblWindChill = 35.74 + 0.6215 * Convert.ToDouble(dblAirTemperature) - 35.75 *(Math.Pow(Convert.ToDouble(dblWindSpeed), dblPower)) + 0.4275 * Convert.ToDouble(dblAirTemperature) * (Math.Pow(Convert.ToDouble(dblWindSpeed), dblPower));

                if (dblWindChill < -17.0 && dblWindChill > -34.9)       //If the wind chill is between -17.0 and -34.9 degrees then display frostbite status.
                {
                    strFrostbiteTime = "Frostbite occurs in 30 minutes.";
                }
                else if(dblWindChill < -35.0 && dblWindChill > -59.9)   //If the wind chill is between -35.0 and -59.9 degrees then display frostbite status.
                {
                    strFrostbiteTime = "Frostbite occurs in 10 minutes.";
                }
                else if(dblWindChill < -60.0)                           //If the wind chill is less than -60.0 degrees then display frostbite status
                {
                    strFrostbiteTime = "Frostbite occurs in 5 minutes.";
                }
            }
            /*** Else if the air temperature is greater than 50.0 degrees and the
             *   wind chill is less than 3.0 mph then
             *   message box pops up telling the user to enter more than
             *   3 mph and try again. With it focusing back on the
             *   wind chill textbox.
             ***/
            else if(dblAirTemperature <= 50.0 && dblWindChill < 3.0)
            {
                MessageBox.Show("Wind speed must be greater than 3 miles/hour. Try again");
                txtWindSpeed.Focus();
            }
            /*** Else if the air temperature is greater than
             *   50 degrees then the wind chill is equal to
             *   the air temperature as stated in the assignment specs.
             *   Also I made it display a status that no wind chill
             *   because in reality there is no wind chill if the temperature
             *   is greater than 50.
             ***/
            else if(dblAirTemperature > 50.0)
            {
                dblWindChill = Convert.ToDouble(dblAirTemperature);
                strFrostbiteTime = "No wind chill.";
            }

            /*** This is when I set the output of the
             *   wind chill to whatever was calculated
             *   and the status of frostbite.
             ***/
            lblWindChill.Text = dblWindChill.ToString("#0.0");
            lblFrostbiteIndicator.Text = strFrostbiteTime;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
