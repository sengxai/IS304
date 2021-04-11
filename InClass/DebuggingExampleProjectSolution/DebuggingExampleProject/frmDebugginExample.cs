using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebuggingExampleProject
{
    public partial class frmDebugginExample : Form
    {
        private const decimal decDiscountRate = 0.025m;
        private const decimal decTaxRate = 0.065m;
        public frmDebugginExample()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            decimal decSamsung424kPrice;
            decimal decRosewoodTablePrice;
            decimal decPhillipsDVR4kPrice;
            decimal decSubTotal;
            decimal decDiscount;
            decimal decTax;
            decimal decTotal;

            //Inputs ********************************************************************************************
            decSamsung424kPrice = Convert.ToDecimal(lblSamsung424kPrice.Text);
            decRosewoodTablePrice = Convert.ToDecimal(lblRosewoodTVTablePrice.Text);
            decPhillipsDVR4kPrice = Convert.ToDecimal(lblPhillipsDVR4kPrice.Text);

            //Processing ****************************************************************************************

            decSubTotal = decSamsung424kPrice + decRosewoodTablePrice + decPhillipsDVR4kPrice;
            decDiscount = decSubTotal * decDiscountRate;
            decTax = (decSubTotal - decDiscount) * decTaxRate;
            decTotal = decSubTotal + decTax - decDiscount;

            //Output ********************************************************************************************
            lblSubTotal.Text = decSubTotal.ToString("C");
            lblDiscount.Text = decDiscount.ToString("C");
            lblTax.Text = decTax.ToString("C");
            lblTotal.Text = decTotal.ToString("C");
        }
    }
}
