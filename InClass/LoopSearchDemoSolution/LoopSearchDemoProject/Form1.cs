using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopSearchDemoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string strPhrase;
            char[] chrCharacter;
            string strAnalysis;
            int intCharacterCount = 0;

            strPhrase = txtPhrase.Text;
            chrCharacter = txtCharacter.Text.ToCharArray();
            char[] chrPhraseArray = strPhrase.ToCharArray();

            for (int intIndexer = 0; intIndexer <= chrPhraseArray.Length - 1; intIndexer++)
            {
                if (chrPhraseArray[intIndexer] == chrCharacter[0])
                {
                    intCharacterCount = intCharacterCount + 1;
                }
            }

            strAnalysis = "There are " + intCharacterCount.ToString() + " instances of '" + chrCharacter[0].ToString() + "' in the phrase.";
            lblAnalysis.Text = strAnalysis;
        }
    }
}
