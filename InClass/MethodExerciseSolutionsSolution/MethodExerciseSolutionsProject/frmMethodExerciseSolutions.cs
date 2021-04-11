using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodExerciseSolutionsProject
{
    public partial class frmMethodExerciseSolutions : Form
    {
        public frmMethodExerciseSolutions()
        {
            InitializeComponent();
        }

        //Basic Concepts - Method Design
        /* Situation 1:
         * CalcCarpetPrice()
         * double dblCarpetLength
         * double dblCarpetBreadth
         * decimal decPricePerSquareYard */
         //Cohesion - High, focused on a single task
         //Coupling - Low, no need for references to outside code


         /* Situation 2:
          * CheckBonusEligibility()
          * int intPerfReviewScore
          * int intCutoffScore
          * OR float */
          //Cohesion - High, focused on a single task
          //Coupling - Low, all informaton needed is supplied

        /* Situation 3:
         * ReorderPart()
         * string strPartNumber
         * string strSupplierNumber
         * decimal decTargetPrice */
         //Cohesion - High. focused on a single task
         //Coupling - May be high, design may be missing
         //a quantity parameter from outside code.

        // Arguments, parameters and passing mechanisms
        /* Statement 1:
         * Technically false, best practice true - Arguments
         * should use names specific to the local situation,
         * Parameters should use generic names that will fit
         * the general purpose */

         /* Statement 2:
          * True - arguments must be listed in the order that
          * parameters are defined (and every parameter needs an 
          * argument) so that values can be passed */

         /* Statement 3:
          * True - a method may not need any arguments, or many 
          * arguments depending on the task. */

         /* Statement 4: 
          * False - by default a value is passed from the argument
          * to the parameter to be used in the method. */

         /* Statement 5:
          * True - passing by reference involves copying the 
          * reference to the stored value, so that both argument
          * and parameter names reference the same memory location 
          * where the value is stored.  */
          


        /* Method with Return Values Exercise Solutions */
        //Situation 1

        private double NumberOfYardsOfMulch(double dblSquareFeet, double dblDepthInInches)
        {
            double dblYards = 0.0;
            //Calculate Yards Required
            return dblYards;
        }

        //Situation 2

        private bool ValidateCredit(string strCustomerID, decimal decCreditAmount)
        {
            bool blnValid = false;
            //Determine if credit valid
            return blnValid;
        }

        //Situation 3

            // Arrays must have customer ID as well as the balance or fee so that they can be related
        private void UpdateAccountBalances(ref decimal[,] decAccountBalances, ref decimal[,] decAccountFees)
        {
            //Update balances with fees
        }
    }
}
