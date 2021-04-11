using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldProject
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "HELLO WORLD!";
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "";
        }

        private void frmHelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
