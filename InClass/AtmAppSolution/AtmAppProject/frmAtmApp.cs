using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmAppProject
{
    public partial class frmAtmApp : Form
    {
        private decimal decWithdrawn = 0.00m;
        private decimal decTwenty = 20.00m;
        private decimal decFourty = 40.00m;
        private decimal decOneHundred = 100.00m;
        private decimal decTwoHundred = 200.00m;

        public frmAtmApp()
        {
            InitializeComponent();
        }

        private void rdbChecking_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbChecking.Checked == true)
            {
                grpWithdrawlAmount.Enabled = true;
                
            }
            else
            {
                grpWithdrawlAmount.Enabled = false;
            }
            
        }

        private void rdbSaving_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSaving.Checked == true)
            {
                grpWithdrawlAmount.Enabled = true;
            }
            else
            {
                grpWithdrawlAmount.Enabled = false;
            }
        }

        private void rdbWithTwenty_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWithTwenty.Checked == true)
            {
                decWithdrawn = decTwenty;
            }
            else 
            {
                decWithdrawn = 0.00m;
            }
            lblWithdrawlAmt.Text = decWithdrawn.ToString("C");
        }


        private void rdbWithFourty_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWithFourty.Checked == true)
            {
                decWithdrawn = decFourty;
            }
            else
            {
                decWithdrawn = 0.00m;
            }
            lblWithdrawlAmt.Text = decWithdrawn.ToString("C");
        }

        private void rdbWithHundred_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWithHundred.Checked == true)
            {
                decWithdrawn = decOneHundred;
            }
            else
            {
                decWithdrawn = 0.00m;
            }
            lblWithdrawlAmt.Text = decWithdrawn.ToString("C");
        }

        private void rdbWithTwoHundred_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWithTwoHundred.Checked == true)
            {
                decWithdrawn = decTwoHundred;
            }
            else
            {
                decWithdrawn = 0.00m;
            }
            lblWithdrawlAmt.Text = decWithdrawn.ToString("C");
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            string strOutput;
            if (rdbChecking.Checked == true)
                {
                if (rdbWithTwenty.Checked == true || rdbWithFourty.Checked == true || rdbWithHundred.Checked == true || rdbWithTwoHundred.Checked == true)
                {
                    strOutput = "Withdrew " + lblWithdrawlAmt.Text + " from " + rdbChecking.Text + " account.";
                }
                else
                {
                    strOutput = "Please select a withdrawl amount.";
                }
            }
            else if (rdbSaving.Checked == true)
            {
                if (rdbWithTwenty.Checked == true || rdbWithFourty.Checked == true || rdbWithHundred.Checked == true || rdbWithTwoHundred.Checked == true)
                {
                    strOutput = "Withdrew " + lblWithdrawlAmt.Text + " from " + rdbSaving.Text + " account.";
                }
                else
                {
                    strOutput = "Please select a withdrawl amount.";
                }
            }
            else
            {
                strOutput = "Select an account.";
            }

            lblOutput.Text = strOutput;
            lblWithdrawlAmt.Text = "";
            rdbChecking.Checked = false;
            rdbSaving.Checked = false;
            rdbWithTwenty.Checked = false;
            rdbWithFourty.Checked = false;
            rdbWithHundred.Checked = false;
            rdbWithTwoHundred.Checked = false;

        }

        private void frmAtmApp_Load(object sender, EventArgs e)
        {
            rdbChecking.Checked = false;
            grpWithdrawlAmount.Enabled = false;
        }
    }
}
