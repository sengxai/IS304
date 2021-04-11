/***
 * This program calculates the cost
 * of each item selected and 
 * displays the total automatically
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

namespace SengYangDelicatessenProject
{
    public partial class frmDelicatessen : Form
    {
        /*** Class Variables ***/

        private decimal decPlainBagel = 1.75m;
        private decimal decLox = 2.00m;
        private decimal decCreamCheese = 1.50m;
        private decimal decSpinach = 5.95m;
        private decimal decChef = 7.95m;
        private decimal decCola = 1.50m;
        private decimal decCreamSoda = 1.75m;

        private decimal decBagelSubtotal = 0.00m;
        private decimal decSaladSubtotal = 0.00m;
        private decimal decSodaSubtotal = 0.00m;
        private decimal decTotal = 0.00m;

        public frmDelicatessen()
        {
            InitializeComponent();
        }

        private void chkBagel_CheckedChanged(object sender, EventArgs e)
        {
            /*** Local Variable ***/

            string strBagelSubtotal;

            /*** This checks to see if the bagel check box
             * has been checked or not. If it has been checked
             * then the group grpBagelFilling will be enabled
             * and the checkboxes within that bagel group will be
             * available to press.
             * ***/
            if( chkBagel.Checked == true)
            {
                grpBagelFilling.Enabled = true;

                /* When bagel is checked the subtotal of bagel
                 * is updated to the price of a plain bagel
                 * and assigned the subtotal to a string to hold the
                 * string value of subtotal so we can display it on
                 * a subtotal label to the right of the GUI.
                 */
                decBagelSubtotal = decPlainBagel; 
                strBagelSubtotal = decBagelSubtotal.ToString("C");
            }
            else
            {
                /* This is when chkBagel has been unchecked */

                grpBagelFilling.Enabled = false;                    //turns the grpBagelFilling off so no one can use it
                decBagelSubtotal = decBagelSubtotal - decPlainBagel; //subtracts the price of plain bagel out of the bagels subtotal so its back to 0
                strBagelSubtotal = "";                              // the subtotal label is set to blank because no bagel as been selected
                chkLox.Checked = false;                          //unchecks chkLox and unchecks chkCreamCheese
                chkCreemCheese.Checked = false;                 
            }
            lblBagelSubtotal.Text = strBagelSubtotal; //lblBagelCost is the string from above which is the price of a plain bagel when bagel is checked
            decTotal = decBagelSubtotal + decSaladSubtotal + decSodaSubtotal; //automatically updates the total price.

            lblTotalCost.Text = decTotal.ToString("C"); //automatically displays the total price.
        }

        private void frmDelicatessen_Load(object sender, EventArgs e)
        {
            /* When the form loads the three groups are automatically disabled */
            grpBagelFilling.Enabled = false;
            grpSaladChoice.Enabled = false;
            grpSoda.Enabled = false;
        }

        private void chkSalad_CheckedChanged(object sender, EventArgs e)
        {
            /*** This checks to see if the Salad check box
             * has been checked or not. If it has been checked
             * then the group grpSaladChoice will be enabled
             * and the radioboxes within that group will be
             * available to press.
             * ***/
            if (chkSalad.Checked == true)
            {
                grpSaladChoice.Enabled = true;
            }
            else
            {
                grpSaladChoice.Enabled = false;     //turns the grpSaladChoice off so no one can use it
                rdbSpinach.Checked = false;         //unchecks rdbSpinach when Salad is unchecked
                rdbChef.Checked = false;            //unchecks rdbChef when Salad is unchecked
                decSaladSubtotal = 0.00m;           //sets subtotal of salad back to 0 when Salad is unchecked
                lblSpinachSubtotal.Text = "";           //makes the display of spinach subtotal blank
            }
            decTotal = decBagelSubtotal + decSaladSubtotal + decSodaSubtotal; //automatically updates the total price.

            lblTotalCost.Text = decTotal.ToString("C"); //automatically displays the total price.
        }

        private void chkSoda_CheckedChanged(object sender, EventArgs e)
        {
            /*** This checks to see if the Soda check box
             * has been checked or not. If it has been checked
             * then the group grpSoda will be enabled
             * and the radioboxes within that group will be
             * available to press.
             * ***/
            if (chkSoda.Checked == true)
            {
                grpSoda.Enabled = true;
            }
            else
            {
                grpSoda.Enabled = false;    //turns the grpSoda off so no one can use it
                rdbCola.Checked = false;    //unchecks rdbCola when Soda is unchecked
                rdbCreamSoda.Checked = false;  //unchecks rdbCreamSoda when Soda is unchecked
                lblSubtotalSoda.Text = "";      //makes the display of soda subtotal blank
                decSodaSubtotal = 0.00m; //sets subtotal back to 0 when soda has been unchecked
            }
            decTotal = decBagelSubtotal + decSaladSubtotal + decSodaSubtotal;  //automatically updates the total price.

            lblTotalCost.Text = decTotal.ToString("C"); //automatically displays the total price.
        }

        private void chkLox_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLox.Checked == true)
            {
                /* If chkLox is checked add the bagels subtotal to the 
                 * price of Lox and update the subtotal.
                 */
                decBagelSubtotal = decBagelSubtotal + decLox;   
            }
            else
            {   /* If chkLox is unchecked subtract the bagels subtotal from the 
                 * price of Lox and update the subtotal.
                 */
                decBagelSubtotal = decBagelSubtotal - decLox;
            }
            lblBagelSubtotal.Text = decBagelSubtotal.ToString("C");      //displays the subtotal of bagel
            decTotal = decBagelSubtotal + decSaladSubtotal + decSodaSubtotal; //automatically updates the total price.

            lblTotalCost.Text = decTotal.ToString("C"); //automatically displays the total price.
        }

        private void chkCreemCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCreemCheese.Checked == true)
            {
                /* If chkCreemCheese is checked add the bagels subtotal to the 
                 * price of cream cheese and update the subtotal.
                 */
                decBagelSubtotal = decBagelSubtotal + decCreamCheese;
            }
            else
            {
                /* If chkCreemCheese is unchecked subtract the bagels subtotal from the 
                 * price of cream cheese and update the subtotal.
                 */
                decBagelSubtotal = decBagelSubtotal - decCreamCheese;
            }
            lblBagelSubtotal.Text = decBagelSubtotal.ToString("C");         //displays the subtotal of bagel
            decTotal = decBagelSubtotal + decSaladSubtotal + decSodaSubtotal; //automatically updates the total price.

            lblTotalCost.Text = decTotal.ToString("C"); //automatically displays the total price.

        }

        private void rdbSpinach_CheckedChanged(object sender, EventArgs e)
        {
            if( rdbSpinach.Checked == true)
            {
                /* If rdbSpinach is checked add the salads subtotal to the 
                 * price of spinach and update the subtotal.
                 */
                decSaladSubtotal = decSaladSubtotal + decSpinach;
            }
            else
            {
                /* If rdbSpinach is unchecked subtract the salads subtotal from the 
                * price of spinach and update the subtotal.
                */
                decSaladSubtotal = decSaladSubtotal - decSpinach;
            }
            lblSpinachSubtotal.Text = decSaladSubtotal.ToString("C");       //displays the subtotal of salad
            decTotal = decBagelSubtotal + decSaladSubtotal + decSodaSubtotal; //automatically updates the total price.

            lblTotalCost.Text = decTotal.ToString("C"); //automatically displays the total price.
        }

        private void rdbChef_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbChef.Checked == true)
            {
                /* If rdbChef is checked add the salads subtotal to the 
                 * price of chef and update the subtotal.
                 */
                decSaladSubtotal = decSaladSubtotal + decChef;
            }
            else
            {
                /* If rdbChef is unchecked subtract the salads subtotal from the 
                * price of chef and update the subtotal.
                */
                decSaladSubtotal = decSaladSubtotal - decChef;
            }
            lblSpinachSubtotal.Text = decSaladSubtotal.ToString("C");       //displays the subtotal of salad
            decTotal = decBagelSubtotal + decSaladSubtotal + decSodaSubtotal; //automatically updates the total price.

            lblTotalCost.Text = decTotal.ToString("C"); //automatically displays the total price.
        }

        private void rdbCola_CheckedChanged(object sender, EventArgs e)
        {
            if( rdbCola.Checked == true)
            {
                /* If rdbCola is checked add the soda subtotal to the 
                 * price of cola and update the subtotal.
                 */
                decSodaSubtotal = decSodaSubtotal + decCola;
            }
            else
            {
                /* If rdbCola is unchecked subtract the soda subtotal from the 
                * price of cola and update the subtotal.
                */
                decSodaSubtotal = decSodaSubtotal - decCola;
            }
            lblSubtotalSoda.Text = decSodaSubtotal.ToString("C");       //displays the subtotal of soda
            decTotal = decBagelSubtotal + decSaladSubtotal + decSodaSubtotal; //automatically updates the total price.

            lblTotalCost.Text = decTotal.ToString("C"); //automatically displays the total price.
        }

        private void rdbCreamSoda_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCreamSoda.Checked == true)
            {
                /* If rdbCreamSoda is checked add the soda subtotal to the 
                 * price of cola and update the subtotal.
                 */
                decSodaSubtotal = decSodaSubtotal + decCreamSoda;
            }
            else
            {
                /* If rdbCreamSoda is unchecked subtract the soda subtotal from the 
               * price of cream soda and update the subtotal.
               */
                decSodaSubtotal = decSodaSubtotal - decCreamSoda;
            }
            lblSubtotalSoda.Text = decSodaSubtotal.ToString("C");       //displays the subtotal of soda
            decTotal = decBagelSubtotal + decSaladSubtotal + decSodaSubtotal; //automatically updates the total price.

            lblTotalCost.Text = decTotal.ToString("C"); //automatically displays the total price.
        }
    }
}
