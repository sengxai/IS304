using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SengYangIntroducingYourselfProject
{
    public partial class frmIntroducingYourself : Form
    {
        public frmIntroducingYourself()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            lblName.Text = "Seng Yang";
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            lblDOB.Text = "1997";
        }

        private void btnBirthPlace_Click(object sender, EventArgs e)
        {
            lblBirthPlace.Text = "Wausau, WI USA";
        }

        private void btnHobby_Click(object sender, EventArgs e)
        {
            lblHobby.Text = "Fishing";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Purple";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblName.Text = "";
            lblDOB.Text = "";
            lblHobby.Text = "";
            lblBirthPlace.Text = "";
            lblColor.Text = "";
        }
    }
}
