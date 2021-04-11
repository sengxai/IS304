using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariableCalcProject
{
    public partial class frmVariableCalc : Form
    {
        public frmVariableCalc()
        {
            InitializeComponent();
        }

        private void btnNaiveAdd_Click(object sender, EventArgs e)
        {
            /** BAD CODE **/
            lblAnswer.Text = txtNumberOne.Text + txtNumberTwo.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal decNumber1;
            decimal decNumber2;
            decimal decAnswer;

            decNumber1 = Convert.ToDecimal(txtNumberOne.Text);
            decNumber2 = Convert.ToDecimal(txtNumberTwo.Text);
            decAnswer = decNumber1 + decNumber2;

            lblAnswer.Text = decAnswer.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal decNumber1;
            decimal decNumber2;
            decimal decAnswer;

            decNumber1 = Convert.ToDecimal(txtNumberOne.Text);
            decNumber2 = Convert.ToDecimal(txtNumberTwo.Text);
            decAnswer = decNumber1 / decNumber2;

            lblAnswer.Text = decAnswer.ToString();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            decimal decNumber1;
            decimal decNumber2;
            decimal decAnswer;

            decNumber1 = Convert.ToDecimal(txtNumberOne.Text);
            decNumber2 = Convert.ToDecimal(txtNumberTwo.Text);
            decAnswer = Convert.ToDecimal(Math.Pow(Convert.ToDouble(decNumber1), Convert.ToDouble(decNumber2)));

            lblAnswer.Text = decAnswer.ToString();


        }

        private void btnCalcBathTowels_Click(object sender, EventArgs e)
        {
            int intNumberOfBathTowels;
            decimal decCostOfBathTowels;
            decimal decAnswer;

            intNumberOfBathTowels = Convert.ToInt32(txtNumberOne.Text);
            decCostOfBathTowels = Convert.ToDecimal(txtNumberTwo.Text);
            decAnswer = Convert.ToDecimal(intNumberOfBathTowels) * decCostOfBathTowels;

            lblAnswer.Text = decAnswer.ToString("N"); //C, F, N difference #.#, 0.0#
                                                        //F just gives two decimals & N gives up to thousands
        }
    }
}
