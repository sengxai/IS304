using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SengYangAmortizationScheduleProject
{
    public partial class frmAmortizationSchedule : Form
    {
        /*** Class Variables ***/
        decimal decInterestRate;
        double dblNumberOfMonths;
        double dblInterestFactor;
        decimal decMonthlyPayment;
        decimal decMonthlyInterest;
        decimal decMonthlyPrincipal;
        public frmAmortizationSchedule()
        {
            InitializeComponent();
        }

        private void frmAmortizationSchedule_Load(object sender, EventArgs e)
        {
            /*** Local Variable ***/
            int intYears = 30;

            //adds amount of years to the combo box years
            for(int intCounter = 1; intCounter <= intYears; intCounter++)
            {
                cboYears.Items.Add(intCounter);
            }

            //adds the interest rates to combo box
            for (double intCounter = 10; intCounter <= 2000; intCounter = intCounter + 10 )
            {
                float floValue = Convert.ToInt32(intCounter) / 10000f;
                cboInterestRate.Items.Add(floValue.ToString("P"));
            }
        }

        private void btnCalculatePayment_Click(object sender, EventArgs e)
        {
            /*** Local Variables ***/
            decimal decAnnualInterestRate;
            double dblNumYears;
            string strDec = cboInterestRate.Text;
            decimal decLoanAmount;
            decimal decTotalInterest = 0.0m;
            double decN = 0;


            /*** Gets local time***/
            DateTime lastDate = DateTime.Now;

            //clears the listbox
            lstOutput.Items.Clear();

            //Formatted listbox and shows the headers
            lstOutput.Items.Add(String.Format("{0,3}{1,25}{2,17}{3,24}{4,28}{5,19}", "Month", "Payment", "Interest", "Principal", "Total Interest", "Balance"));


            if (txtLoanAmount.Text != "")//checks to see if loan amount is empty or not
            {
                //decLoanAmount is the balance that the user is requesting to loan
                decLoanAmount = Convert.ToDecimal(txtLoanAmount.Text);

                if (decLoanAmount >= 1 && decLoanAmount <= 999999) //checks to see if loan amount requested is between 1 and 999999
                { 
                    if(cboYears.SelectedIndex != -1) //checks to see if user has selected a loan period
                    {
                        //gets user input of years and gets how many months(n)
                        dblNumYears = Convert.ToInt32(cboYears.Text);
                        dblNumberOfMonths = dblNumYears * 12;

                        if (cboInterestRate.SelectedIndex != -1) // checks to see if user has selected an interest rate
                        {
                            //gets user input and replaces '%' sign with an empty string so it just gets the numbers only
                            //which can be easily converted into a decimal without the % sign interferring
                            decAnnualInterestRate = Convert.ToDecimal(cboInterestRate.Text.Replace("%", "")) / 100;

                            //Then calculates monthly interest rate(r)
                            decInterestRate = decAnnualInterestRate / 12.0m; 

                            //Calculates interest factor(IF)
                            decN = 1.0 + Convert.ToDouble(decInterestRate); //decN is the 'N' Power
                            dblInterestFactor = (1 - Math.Pow(decN, -dblNumberOfMonths)) / Convert.ToDouble(decInterestRate); // This is the calculation of Interest Factor
                            
                            
                            //calculates monthly payment(Pa)
                            decMonthlyPayment = decLoanAmount / Convert.ToDecimal(dblInterestFactor);

                            /* iterates through the number of months so it can do
                             * all the calculations and display it at the same time.
                             * */

                            for (int i = 1; i <= dblNumberOfMonths; i++)
                            {
                                //calculates monthly interest(MI)
                                decMonthlyInterest = decLoanAmount * decInterestRate;

                                //calculates monthly principal(MP)
                                decMonthlyPrincipal = decMonthlyPayment - decMonthlyInterest;

                                //updates the balance
                                decLoanAmount = decLoanAmount - decMonthlyPrincipal;

                                //calculates total interest paid.
                                decTotalInterest = decMonthlyInterest + decTotalInterest;

                                //displays onto the listbox
                                lstOutput.Items.Add(String.Format("{0,-3}{1,16}{2,17}{3,19}{4,25}{5,25}", lastDate.AddMonths(i).ToString("MM/dd/yyyy"), decMonthlyPayment.ToString("C"), decMonthlyInterest.ToString("C"), decMonthlyPrincipal.ToString("C"), decTotalInterest.ToString("C"), decLoanAmount.ToString("C")));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter in an interest rate!", "Error");
                            cboInterestRate.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a loan period!", "Error");
                        cboYears.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a loan amount between 1 and 999,999!", "Error");
                    txtLoanAmount.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter in a loan amount!", "Error");
                txtLoanAmount.Focus();
            }

        }

    }
}
