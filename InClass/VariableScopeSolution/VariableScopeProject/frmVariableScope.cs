using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This is the highest level block in the programming space

namespace VariableScopeProject
{
    //this is a class block
    public partial class frmVariableScope : Form
    {
        /* this is a local declaration with class scope- variable is accessible
         * within all methods */
        //private string strName;

        private int intCount;
                
        //This is a method block
        public frmVariableScope()
        {
            InitializeComponent();
        }

        private void frmVriableScope_Load(Object sender, EventArgs e)
        {
            this.Text = "hello";
        }

        //This is a click event handler method
        private void btnDeclare_Click(object sender, EventArgs e)
        {
            //this is a local declaration to the event handler method-no keyword required
            //string strName
            //Here is an example of accessing a global variable in modGlobal, a static class
            modGlobal.strName = "Seng Yang";
            
        }
        //Another click event handler
        private void btnAssign_Click(object sender, EventArgs e)
        {
            decimal decExpenses;
            lblOutput.Text = modGlobal.strName;
        }
    }
}
