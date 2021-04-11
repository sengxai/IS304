using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListControlsExerciseProject
{
    public partial class frmListControlsExercise : Form
    {
        public frmListControlsExercise()
        {
            InitializeComponent();
        }

        private void frmListControlsExercise_Load(object sender, EventArgs e)
        {
            int intCounter;
            //Loop to fill combo box with quantities from 0 to 100
            for (intCounter = 0; intCounter <= 100; intCounter++)
            {
                //Use the loop counter as the value to add to the Combobox
                cboQuantityList.Items.Add(intCounter.ToString());
            }
            //Initialize the combobox and listbox to show 0 and blank respectively
            //Note that changing the SelectedIndex will run the selectedindexChanged event
            cboQuantityList.SelectedIndex = 0;
            lstOrder.Items.Clear();
        }

        private void cboProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add the selected value in the combobox to the listbox
            lstOrder.Items.Add(cboQuantityList.SelectedItem);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int intSum = 0;
            //Loop to go through all the values in the listbox and sum them
            //Counter is indexing, so condition uses Count -1 to go up to the largest index
            for(int intCounter = 0; intCounter<=lstOrder.Items.Count -1;intCounter++)
            {
                //Update the sum by adding the current list item value
                //Note counter variable is used as the index of the Items array
                intSum = intSum + Convert.ToInt32(lstOrder.Items[intCounter]);
            }
            //Initialize the combo and list ready for next order
            cboQuantityList.SelectedIndex = 0;
            lstOrder.Items.Clear();
            //Note current order sum in listbox
            lstOrder.Items.Add(intSum.ToString());    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Initalize combo and list box
            cboQuantityList.SelectedIndex = 0;
            lstOrder.Items.Clear();
        }
    }
}
