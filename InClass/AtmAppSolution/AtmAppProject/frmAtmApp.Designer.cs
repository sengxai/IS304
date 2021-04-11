namespace AtmAppProject
{
    partial class frmAtmApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.rdbSaving = new System.Windows.Forms.RadioButton();
            this.rdbChecking = new System.Windows.Forms.RadioButton();
            this.grpWithdrawlAmount = new System.Windows.Forms.GroupBox();
            this.rdbWithTwoHundred = new System.Windows.Forms.RadioButton();
            this.rdbWithHundred = new System.Windows.Forms.RadioButton();
            this.rdbWithFourty = new System.Windows.Forms.RadioButton();
            this.rdbWithTwenty = new System.Windows.Forms.RadioButton();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.lblWithdrawlAmt = new System.Windows.Forms.Label();
            this.lblWithdrawl = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.grpAccount.SuspendLayout();
            this.grpWithdrawlAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(this.rdbSaving);
            this.grpAccount.Controls.Add(this.rdbChecking);
            this.grpAccount.Location = new System.Drawing.Point(12, 24);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(141, 109);
            this.grpAccount.TabIndex = 0;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Select Account:";
            // 
            // rdbSaving
            // 
            this.rdbSaving.AutoSize = true;
            this.rdbSaving.Location = new System.Drawing.Point(28, 59);
            this.rdbSaving.Name = "rdbSaving";
            this.rdbSaving.Size = new System.Drawing.Size(79, 21);
            this.rdbSaving.TabIndex = 1;
            this.rdbSaving.Text = "Savings";
            this.rdbSaving.UseVisualStyleBackColor = true;
            this.rdbSaving.CheckedChanged += new System.EventHandler(this.rdbSaving_CheckedChanged);
            // 
            // rdbChecking
            // 
            this.rdbChecking.AutoSize = true;
            this.rdbChecking.Location = new System.Drawing.Point(28, 22);
            this.rdbChecking.Name = "rdbChecking";
            this.rdbChecking.Size = new System.Drawing.Size(87, 21);
            this.rdbChecking.TabIndex = 0;
            this.rdbChecking.Text = "Checking";
            this.rdbChecking.UseVisualStyleBackColor = true;
            this.rdbChecking.CheckedChanged += new System.EventHandler(this.rdbChecking_CheckedChanged);
            // 
            // grpWithdrawlAmount
            // 
            this.grpWithdrawlAmount.Controls.Add(this.rdbWithTwoHundred);
            this.grpWithdrawlAmount.Controls.Add(this.rdbWithHundred);
            this.grpWithdrawlAmount.Controls.Add(this.rdbWithFourty);
            this.grpWithdrawlAmount.Controls.Add(this.rdbWithTwenty);
            this.grpWithdrawlAmount.Location = new System.Drawing.Point(182, 24);
            this.grpWithdrawlAmount.Name = "grpWithdrawlAmount";
            this.grpWithdrawlAmount.Size = new System.Drawing.Size(138, 145);
            this.grpWithdrawlAmount.TabIndex = 1;
            this.grpWithdrawlAmount.TabStop = false;
            this.grpWithdrawlAmount.Text = "Select Withdrawl:";
            // 
            // rdbWithTwoHundred
            // 
            this.rdbWithTwoHundred.AutoSize = true;
            this.rdbWithTwoHundred.Location = new System.Drawing.Point(21, 106);
            this.rdbWithTwoHundred.Name = "rdbWithTwoHundred";
            this.rdbWithTwoHundred.Size = new System.Drawing.Size(61, 21);
            this.rdbWithTwoHundred.TabIndex = 3;
            this.rdbWithTwoHundred.Text = "$200";
            this.rdbWithTwoHundred.UseVisualStyleBackColor = true;
            this.rdbWithTwoHundred.CheckedChanged += new System.EventHandler(this.rdbWithTwoHundred_CheckedChanged);
            // 
            // rdbWithHundred
            // 
            this.rdbWithHundred.AutoSize = true;
            this.rdbWithHundred.Location = new System.Drawing.Point(21, 78);
            this.rdbWithHundred.Name = "rdbWithHundred";
            this.rdbWithHundred.Size = new System.Drawing.Size(61, 21);
            this.rdbWithHundred.TabIndex = 2;
            this.rdbWithHundred.Text = "$100";
            this.rdbWithHundred.UseVisualStyleBackColor = true;
            this.rdbWithHundred.CheckedChanged += new System.EventHandler(this.rdbWithHundred_CheckedChanged);
            // 
            // rdbWithFourty
            // 
            this.rdbWithFourty.AutoSize = true;
            this.rdbWithFourty.Location = new System.Drawing.Point(21, 50);
            this.rdbWithFourty.Name = "rdbWithFourty";
            this.rdbWithFourty.Size = new System.Drawing.Size(53, 21);
            this.rdbWithFourty.TabIndex = 1;
            this.rdbWithFourty.Text = "$40";
            this.rdbWithFourty.UseVisualStyleBackColor = true;
            this.rdbWithFourty.CheckedChanged += new System.EventHandler(this.rdbWithFourty_CheckedChanged);
            // 
            // rdbWithTwenty
            // 
            this.rdbWithTwenty.AutoSize = true;
            this.rdbWithTwenty.Location = new System.Drawing.Point(21, 22);
            this.rdbWithTwenty.Name = "rdbWithTwenty";
            this.rdbWithTwenty.Size = new System.Drawing.Size(53, 21);
            this.rdbWithTwenty.TabIndex = 0;
            this.rdbWithTwenty.Text = "$20";
            this.rdbWithTwenty.UseVisualStyleBackColor = true;
            this.rdbWithTwenty.CheckedChanged += new System.EventHandler(this.rdbWithTwenty_CheckedChanged);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(30, 211);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(123, 41);
            this.btnTransaction.TabIndex = 2;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // lblWithdrawlAmt
            // 
            this.lblWithdrawlAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblWithdrawlAmt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWithdrawlAmt.Location = new System.Drawing.Point(374, 46);
            this.lblWithdrawlAmt.Name = "lblWithdrawlAmt";
            this.lblWithdrawlAmt.Size = new System.Drawing.Size(100, 23);
            this.lblWithdrawlAmt.TabIndex = 3;
            // 
            // lblWithdrawl
            // 
            this.lblWithdrawl.AutoSize = true;
            this.lblWithdrawl.Location = new System.Drawing.Point(349, 24);
            this.lblWithdrawl.Name = "lblWithdrawl";
            this.lblWithdrawl.Size = new System.Drawing.Size(125, 17);
            this.lblWithdrawl.TabIndex = 4;
            this.lblWithdrawl.Text = "Withdrawl Amount:";
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOutput.Location = new System.Drawing.Point(179, 211);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(175, 113);
            this.lblOutput.TabIndex = 5;
            // 
            // frmAtmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 385);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblWithdrawl);
            this.Controls.Add(this.lblWithdrawlAmt);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.grpWithdrawlAmount);
            this.Controls.Add(this.grpAccount);
            this.Name = "frmAtmApp";
            this.Text = "Atm Application";
            this.Load += new System.EventHandler(this.frmAtmApp_Load);
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.grpWithdrawlAmount.ResumeLayout(false);
            this.grpWithdrawlAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.RadioButton rdbSaving;
        private System.Windows.Forms.RadioButton rdbChecking;
        private System.Windows.Forms.GroupBox grpWithdrawlAmount;
        private System.Windows.Forms.RadioButton rdbWithTwoHundred;
        private System.Windows.Forms.RadioButton rdbWithHundred;
        private System.Windows.Forms.RadioButton rdbWithFourty;
        private System.Windows.Forms.RadioButton rdbWithTwenty;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Label lblWithdrawlAmt;
        private System.Windows.Forms.Label lblWithdrawl;
        private System.Windows.Forms.Label lblOutput;
    }
}

