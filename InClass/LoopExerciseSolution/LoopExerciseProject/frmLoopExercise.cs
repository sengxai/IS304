using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopExerciseProject
{
    public partial class frmLoopExercise : Form
    {
        public frmLoopExercise()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string strParagraph;
            int intWordCount;
            int intCounter;
            char[] chrParagraph;
            char chrSpace = char.Parse(" ");

            strParagraph = txtParagraph.Text;
            if(strParagraph != "")
            {
                intWordCount = 1;
            }
            else
            {
                intWordCount = 0;
            }
            strParagraph = strParagraph.Trim();
            chrParagraph = strParagraph.ToCharArray();

            for(intCounter = 0; intCounter<=chrParagraph.Length-1; intCounter++)
            {
                if(chrParagraph[intCounter]==chrSpace)
                {
                    intWordCount = intWordCount + 1;
                }
            }
            lblWordCount.Text = "The text contains " + intWordCount.ToString() + " words.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtParagraph.Text = "";
            lblWordCount.Text = "";
        }
    }
}
