/*** Seng Yang Simple Invoice 
 *   IS304***/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SengYangSimpleInvoiceProject
{
    public partial class frmSimpleInvoice : Form
    {
        public frmSimpleInvoice()
        {
            InitializeComponent();
        }

        private void frmSimpleInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*** Local Constant ***/
            const decimal decTax = 5.5m;
            const int intQuantity = 1;

            /*** Local Variables ***/
            decimal decGumPrice;
            decimal decChickenPrice;
            decimal decBeefPrice;
            decimal decPorkPrice;
            decimal decFishPrice;
            decimal decCerealPrice;
            decimal decChocolatePrice;

            decimal decSubTotal;
            decimal decTaxTotal;
            decimal decTotal;

            /*** Assigning values to variables ***/
            
            decGumPrice = 1.50m;
            decChickenPrice = 8.99m;
            decBeefPrice = 11.99m;
            decPorkPrice = 10.99m;
            decFishPrice = 10.99m;
            decCerealPrice = 4.99m;
            decChocolatePrice = 3.99m;

            /*** Processing ***/
            /*** Sum of Price of Product * The Quanity(1) ***/
            decSubTotal = (decGumPrice * intQuantity) + (decChickenPrice * intQuantity) + (decBeefPrice * intQuantity) + (decPorkPrice * intQuantity) + (decFishPrice * intQuantity) + (decCerealPrice * intQuantity) + (decChocolatePrice * intQuantity);
            decTaxTotal = (decSubTotal * decTax) / 100;
            decTotal = decSubTotal + decTaxTotal;

            /*** Output ***/
            /*** Assigning the text of the totals to
             *   be from the processing totals ***/
            lblSubTotalPrice.Text = decSubTotal.ToString("C");
            lblTaxPrice.Text = decTaxTotal.ToString("C");
            lblTotalPrice.Text = decTotal.ToString("C");
        }
    }
}
