using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoopDemoProject
{
    public partial class frmForLoopDemo : Form
    {
        // Declare array with class scope so it can be used in several events
        private string[] strColors;
        public frmForLoopDemo()
        {
            InitializeComponent();
        }

        private void frmForLoopDemo_Load(object sender, EventArgs e)
        {
            // Create array of 5 strings
            strColors = new string[5];
            // Assign values to each element of the array, identified by its index
            strColors[0] = "Blue";
            strColors[1] = "Red";
            strColors[2] = "Green";
            strColors[3] = "Yellow";
            strColors[4] = "White";
        }

        private void btnGetColors_Click(object sender, EventArgs e)
        {
            // Set up loop counter to start at 0, add 1 per iteration, and terminate when the counter exceeds the largest array index 
            for (int intIndexer = 0; intIndexer <= strColors.Length - 1; intIndexer++)
            {
                // Use the loop counter variable as the index to the array, so as it increments
                // each time the array moves on to the next element
                txtOutput.Text = txtOutput.Text + strColors[intIndexer] + Environment.NewLine;
                // take the characters in the string at this index and put them into a character array
                char[] chrStringChars = strColors[intIndexer].ToCharArray();
                // Set up loop to start at 1, so the array index starts at the second element
                for (int intCharIndexer = 1; intCharIndexer <= chrStringChars.Length - 1; intCharIndexer++)
                {
                    // Outputs each character on a separate line in the textbox
                    txtOutput.Text = txtOutput.Text + chrStringChars[intCharIndexer] + Environment.NewLine;
                }
            }
        }
    }
}
