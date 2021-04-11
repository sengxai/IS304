using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SengYangBuildingSuppliesInvoiceProject
{
    public partial class frmBuildingSuppliesInvoice : Form
    {

        public frmBuildingSuppliesInvoice()
        {
            InitializeComponent();
        }

        private void frmBuildingSuppliesInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*** Local Variables ***/
            int intTwoBySixLumberQuantity = 0;
            int intTwoByFourLumberQuantity = 0;
            int intFourByEightHalfQuantity = 0;
            int intFourByEightFiveEigthsQuantity = 0;
            int intNailsQuantity = 0;
            int intBradsQuantity = 0;
            int intScrewQuantity = 0;
            int intHammerQuantity = 0;
            int intDrillBitsQuantity = 0;
            int intStapleGunQuantity = 0;

            decimal decTwoBySixLumberPrice = 3.95m;
            decimal decTwoByFourLumberPrice = 2.75m;
            decimal decFourByEightHalfPrice = 7.50m;
            decimal decFourByEightFiveEigthsPrice = 8.50m;
            decimal decNailsPrice = 5.75m;
            decimal decBradsPrice = 6.95m;
            decimal decScrewPrice = 5.95m;
            decimal decHammerPrice = 17.95m;
            decimal decDrillBitsPrice = 5.95m;
            decimal decStapleGunPrice = 8.95m;

            decimal decTwoByFourTotalCost;
            decimal decTwoBySixTotalCost;
            decimal decFourByEightHalfTotalCost;
            decimal decFourByEightFiveEigthsTotalCost;
            decimal decNailsTotalCost;
            decimal decBradsTotalCost;
            decimal decScrewTotalCost;
            decimal decHammerTotalCost;
            decimal decDrillBitsTotalCost;
            decimal decStapleGunTotalCost;

            decimal decSubTotal;
            decimal decTotalTax;
            decimal decTotalPrice;

            /*** Validating user input to see if its a number or not***/
            if (ValidatingUserInput(txtTwoBySixQuantity, txtTwoByFourQuantity, txtFourByEightHalfPlyQuantity,
                txtFourByEightFiveEigthsPlyQuantity, txtNailsQuantity, txtBradsQuantity, txtScrewsQuantity,
                txtHammerQuantity, txtDrillBitsQuantity, txtStapleGunQuantity))
            {
                /*** INPUT ***/

                //Then get the userinput and convert it into an integer and store it as an integer
                intTwoBySixLumberQuantity = Convert.ToInt32(txtTwoBySixQuantity.Text);
                intTwoByFourLumberQuantity = Convert.ToInt32(txtTwoByFourQuantity.Text);
                intFourByEightHalfQuantity = Convert.ToInt32(txtFourByEightHalfPlyQuantity.Text);
                intFourByEightFiveEigthsQuantity = Convert.ToInt32(txtFourByEightFiveEigthsPlyQuantity.Text);
                intNailsQuantity = Convert.ToInt32(txtNailsQuantity.Text);
                intBradsQuantity = Convert.ToInt32(txtBradsQuantity.Text);
                intScrewQuantity = Convert.ToInt32(txtScrewsQuantity.Text);
                intHammerQuantity = Convert.ToInt32(txtHammerQuantity.Text);
                intDrillBitsQuantity = Convert.ToInt32(txtDrillBitsQuantity.Text);
                intStapleGunQuantity = Convert.ToInt32(txtStapleGunQuantity.Text);


                /*** PROCESSING ***/

                /***CalculatePrice(int ..., decimal ...)
                 * This method returns the total price of the quantity given
                 * Calculates the cost of each items
                 */
                decTwoByFourTotalCost = CalculatePrice(intTwoByFourLumberQuantity, decTwoByFourLumberPrice);
                decTwoBySixTotalCost = CalculatePrice(intTwoBySixLumberQuantity, decTwoBySixLumberPrice);
                decFourByEightHalfTotalCost = CalculatePrice(intFourByEightHalfQuantity, decFourByEightHalfPrice);
                decFourByEightFiveEigthsTotalCost = CalculatePrice(intFourByEightFiveEigthsQuantity, decFourByEightFiveEigthsPrice);
                decNailsTotalCost = CalculatePrice(intNailsQuantity, decNailsPrice);
                decBradsTotalCost = CalculatePrice(intBradsQuantity, decBradsPrice);
                decScrewTotalCost = CalculatePrice(intScrewQuantity, decScrewPrice);
                decHammerTotalCost = CalculatePrice(intHammerQuantity, decHammerPrice);
                decDrillBitsTotalCost = CalculatePrice(intDrillBitsQuantity, decDrillBitsPrice);
                decStapleGunTotalCost = CalculatePrice(intStapleGunQuantity, decStapleGunPrice);

                //This calculates the subtotal by taking in the total cost of each item
                decSubTotal = CalculateSubTotal(decTwoByFourTotalCost, decTwoBySixTotalCost, decFourByEightHalfTotalCost, decFourByEightFiveEigthsTotalCost,
                                    decNailsTotalCost, decBradsTotalCost, decScrewTotalCost, decHammerTotalCost, decDrillBitsTotalCost, decStapleGunTotalCost);

                //This calculates the total tax by using the subtotal
                decTotalTax = CalculateTotalTax(decSubTotal);

                //This calculates the total price by adding the subtotal and the taxes
                decTotalPrice = CalculateTotalPrice(decSubTotal, decTotalTax);

                /*** OUTPUT ***/

                //this displays the subtotals and the total prices
                lblSubtotal.Text = decSubTotal.ToString("C");
                lblTotal.Text = decTotalPrice.ToString("C");

            }        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //application exits
            Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Textboxes are cleared
            Clear();
        }

        private bool ValidatingUserInput(TextBox txtTwoBySixQuantity, TextBox txtTwoByFourQuantity, TextBox txtFourByEightHalfPlyQuantity,
                TextBox txtFourByEightFiveEigthsPlyQuantity, TextBox txtNailsQuantity, TextBox txtBradsQuantity,
                TextBox txtScrewsQuantity, TextBox txtHammerQuantity, TextBox txtDrillBitsQuantity,
                TextBox txtStapleGunQuantity)
        {
            //int intQuantity;
            bool abc = false;// assuming bad user input
            /* 
             * Takes all these boxes and pass it into another method to see if they
             * are integers and to see if they are between 0 and 500.
             */
            if(ValidInteger(txtTwoBySixQuantity))
            {
                if (ValidInteger(txtTwoByFourQuantity))
                {
                    if (ValidInteger(txtFourByEightHalfPlyQuantity))
                    {
                        if (ValidInteger(txtFourByEightFiveEigthsPlyQuantity))
                        {
                            if (ValidInteger(txtNailsQuantity))
                            {
                                if (ValidInteger(txtBradsQuantity))
                                {
                                    if (ValidInteger(txtScrewsQuantity))
                                    {
                                        if (ValidInteger(txtHammerQuantity))
                                        {
                                            if (ValidInteger(txtDrillBitsQuantity))
                                            {
                                                if (ValidInteger(txtStapleGunQuantity))
                                                {
                                                    abc = true; // means good user input
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            return abc;
        }

        private bool ValidInteger(TextBox txtBox)
        {
            /*** Local Variables ***/
            int intQuantity;
            bool abc;

            // If the user input is not a valid number or blank then displays an error and returns false
            // otherwise if it is valid then check if the quantity that the user provided
            // is between 0 and 500.
            if (int.TryParse(txtBox.Text, out intQuantity) == false)
            {
                MessageBox.Show("Enter in a valid number", "Problem", 0, MessageBoxIcon.Exclamation);
                txtBox.Focus(); //focuses on textbox and highlights it
                txtBox.SelectAll();
                abc = false;
            }
            else
            {       //Checks to see if the user input is between 0 and 500
                    //if it is then return true otherwise return false and display error message.
                if (intQuantity <= 500 && intQuantity >= 0)
                {
                    abc = true;
                }
                else
                {
                    MessageBox.Show("Enter in a value between 0 and 500", "Problem", 0, MessageBoxIcon.Exclamation);
                    txtBox.Focus(); //focuses on textbox and highlights it
                    txtBox.SelectAll();
                    abc = false;
                }
            }

            //returns true or false
            return abc;
        }

        private decimal CalculateTotalTax(decimal decSubtotal)
        {
            /*** Local Variables ***/
            decimal decTax = 0.055m;
            decimal decTotalTax = 0.0m;

            //calculates the total taxes by multiply by the tax rate and the subtotal
            decTotalTax = decTax * decSubtotal;

            //returns the total tax
            return decTotalTax;
        }

        private decimal CalculateTotalPrice(decimal decSubtotal, decimal decTotalTax)
        {
            /*** Local Variables ***/
            decimal decTotalPrice;

            //calculates the total price by adding the calculated total tax and the calculated subtotal
            decTotalPrice = decSubtotal + decTotalTax;

            //retunrs the total price
            return decTotalPrice;
        }
        private decimal CalculatePrice(int quantity, decimal price)
        {
            /*** Local Variables ***/
            decimal decTotal = 0.0m;

            //calculates the price of the item given the quantity and price
            decTotal = Convert.ToDecimal(quantity) * price;

            //returns the total price of an item
            return decTotal;
        }
        
        private decimal CalculateSubTotal(decimal decTwoByFourTotalCost, decimal decTwoBySixTotalCost, decimal decFourByEightHalfTotalCost, decimal decFourByEightFiveEigthsTotalCost,
                        decimal decNailsTotalCost, decimal decBradsTotalCost, decimal decScrewTotalCost, decimal decHammerTotalCost, decimal decDrillBitsTotalCost,
                        decimal decStapleGunTotalCost)
        {
            /*** Local Variables ***/
            decimal decTotal = 0.0m;

            //calcualtes the subtotal by adding all of the items together
            decTotal = decTwoByFourTotalCost + decTwoBySixTotalCost + decFourByEightHalfTotalCost + decFourByEightFiveEigthsTotalCost + decNailsTotalCost + decBradsTotalCost +
                        decScrewTotalCost + decHammerTotalCost + decDrillBitsTotalCost + decStapleGunTotalCost;

            //returns the subtotal
            return decTotal;
        }
        private void Exit()
        {
            //application exits
            Application.Exit();
        }

       private void Clear()
        {
            //Sets all textboxes and output labels to blank
            txtTwoByFourQuantity.Text = "";
            txtTwoBySixQuantity.Text = "";
            txtFourByEightHalfPlyQuantity.Text = "";
            txtFourByEightFiveEigthsPlyQuantity.Text = "";
            txtNailsQuantity.Text = "";
            txtBradsQuantity.Text = "";
            txtScrewsQuantity.Text = "";
            txtHammerQuantity.Text = "";
            txtDrillBitsQuantity.Text = "";
            txtStapleGunQuantity.Text = "";

            lblSubtotal.Text = "";
            lblTotal.Text = "";
        }
    }
}
