using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariableUseProject
{
    public partial class frmVariableUse : Form
    {
        public frmVariableUse()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            //First we declare our variables we want to use in this block
            string strName;
            int intNumberOfTowels;
            decimal decSalary;
            float floArea;
            bool blnWantCatalog;

            //assign a value to the variable
            strName = "Sengxai";
            intNumberOfTowels = 4567;
            decSalary = 62000.00m;
            floArea = 9.75f;
            blnWantCatalog = false;

            //assign the value in the variable to the output object text
            lblOutput.Text = strName;
            lblOutput.Text = Convert.ToString(intNumberOfTowels);
            lblOutput.Text = Convert.ToString(decSalary);
            lblOutput.Text = Convert.ToString(floArea);
            lblOutput.Text = Convert.ToString(blnWantCatalog);
        }
    }
}
