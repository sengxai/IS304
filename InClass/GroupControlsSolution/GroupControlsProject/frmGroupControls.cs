using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupControlsProject
{
    public partial class frmGroupControls : Form
    {
        private decimal decTotal = 0.00m;
        private decimal decXLargePrice = 6.00m;
        private decimal decLargePrice = 5.00m;
        private decimal decMediumPrice = 4.00m;
        private decimal decSmallPrice = 3.00m;
        private decimal decLongSleevePrice = 8.00m;
        private decimal decLogoPrice = 10.00m;
        private decimal decFlipSequinPrice = 20.00m;
        public frmGroupControls()
        {
            InitializeComponent();
        }

        private void grpDesignElements_Enter(object sender, EventArgs e)
        {

        }

        private void rdbXLarge_CheckedChanged(object sender, EventArgs e)
        {
            if( rdbXLarge.Checked == true)
            {
                decTotal = decTotal + decXLargePrice;
                grpColors.Enabled = true;
                grpDesignElements.Enabled = true;
            }
            else
            {
                decTotal = decTotal - decXLargePrice;
                grpColors.Enabled = false;
                grpDesignElements.Enabled = false;

            }
            lblOutput.Text = decTotal.ToString("C");
        }

        private void rdbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLarge.Checked == true)
            {
                decTotal = decTotal + decLargePrice;
                grpColors.Enabled = true;
                grpDesignElements.Enabled = false;

            }
            else
            {
                decTotal = decTotal - decLargePrice;
                grpColors.Enabled = false;
                rdbBlue.Checked = false;
                rdbGreen.Checked = false;
                rdbRed.Checked = false;
                rdbWhite.Checked = false;
                grpColors.Enabled = false;
            }
            lblOutput.Text = decTotal.ToString("C");
        }

        private void rdbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMedium.Checked == true)
            {
                decTotal = decTotal + decMediumPrice;
                grpColors.Enabled = true;
            }
            else
            {
                decTotal = decTotal - decMediumPrice;
                grpColors.Enabled = false;
            }
            lblOutput.Text = decTotal.ToString("C");
        }

        private void rdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSmall.Checked == true)
            {
                decTotal = decTotal + decSmallPrice;
                grpColors.Enabled = true;
            }
            else
            {
                decTotal = decTotal - decSmallPrice;
                grpColors.Enabled = false;
            }
            lblOutput.Text = decTotal.ToString("C");
        }

        private void frmGroupControls_Paint(object sender, PaintEventArgs e)
        {
            rdbXLarge.Checked = false;
        }
    }
}
