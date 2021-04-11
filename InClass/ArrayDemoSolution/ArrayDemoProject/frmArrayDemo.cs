using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayDemoProject
{
    public partial class frmArrayDemo : Form
    {
        //DECLARATION of module level string array reference strColors
        private string[] strColors;

        public frmArrayDemo()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + strColors[0];
            txtOutput.Text = txtOutput.Text + Environment.NewLine + strColors[1];
            txtOutput.Text = txtOutput.Text + Environment.NewLine + strColors[2];
            txtOutput.Text = txtOutput.Text + Environment.NewLine + strColors[3];
            txtOutput.Text = txtOutput.Text + Environment.NewLine + strColors[4];
            char[] chrStringChars = strColors[1].ToCharArray();
            txtOutput.Text = txtOutput.Text + Environment.NewLine + chrStringChars[0];
            txtOutput.Text = txtOutput.Text + Environment.NewLine + chrStringChars[1];
            txtOutput.Text = txtOutput.Text + Environment.NewLine + chrStringChars[2];
        }

        private void frmArrayDemo_Load(object sender, EventArgs e)
        {
            strColors = new string[5];
            strColors[0] = "Blue";
            strColors[1] = "Red";
            strColors[2] = "Green";
            strColors[3] = "Yellow";
            strColors[4] = "White";
            //strColors[5] = "Purple";


        }
    }
}
