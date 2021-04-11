using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceControlsProject
{
    public partial class frmInterfaceControls : Form
    {
        public frmInterfaceControls()
        {
            InitializeComponent();
        }

        private void frmInterfaceControls_Load(object sender, EventArgs e)
        {

        }

        private void txtEnterName_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = txtEnterName.Text;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "You pressed the enter key";
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "You pressed the Escape key";
        }

        private void btnSomething_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "You pressed the Alt + m keys";
        }
    }
}
