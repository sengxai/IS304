namespace SengYangAmortizationScheduleProject
{
    partial class frmAmortizationSchedule
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
            this.lblLoanAmountLabel = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.cboInterestRate = new System.Windows.Forms.ComboBox();
            this.lblYearsLabel = new System.Windows.Forms.Label();
            this.lblInterestLabel = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnCalculatePayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoanAmountLabel
            // 
            this.lblLoanAmountLabel.AutoSize = true;
            this.lblLoanAmountLabel.Location = new System.Drawing.Point(26, 29);
            this.lblLoanAmountLabel.Name = "lblLoanAmountLabel";
            this.lblLoanAmountLabel.Size = new System.Drawing.Size(96, 17);
            this.lblLoanAmountLabel.TabIndex = 0;
            this.lblLoanAmountLabel.Text = "Loan Amount:";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(128, 29);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(100, 22);
            this.txtLoanAmount.TabIndex = 1;
            // 
            // cboYears
            // 
            this.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(291, 58);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(121, 24);
            this.cboYears.TabIndex = 2;
            // 
            // cboInterestRate
            // 
            this.cboInterestRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInterestRate.FormattingEnabled = true;
            this.cboInterestRate.Location = new System.Drawing.Point(479, 58);
            this.cboInterestRate.Name = "cboInterestRate";
            this.cboInterestRate.Size = new System.Drawing.Size(121, 24);
            this.cboInterestRate.TabIndex = 3;
            // 
            // lblYearsLabel
            // 
            this.lblYearsLabel.AutoSize = true;
            this.lblYearsLabel.Location = new System.Drawing.Point(268, 29);
            this.lblYearsLabel.Name = "lblYearsLabel";
            this.lblYearsLabel.Size = new System.Drawing.Size(137, 17);
            this.lblYearsLabel.TabIndex = 4;
            this.lblYearsLabel.Text = "Choose Loan Years:";
            // 
            // lblInterestLabel
            // 
            this.lblInterestLabel.AutoSize = true;
            this.lblInterestLabel.Location = new System.Drawing.Point(445, 29);
            this.lblInterestLabel.Name = "lblInterestLabel";
            this.lblInterestLabel.Size = new System.Drawing.Size(161, 17);
            this.lblInterestLabel.TabIndex = 5;
            this.lblInterestLabel.Text = "Choose Interest Rate %:";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(29, 113);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(671, 308);
            this.lstOutput.TabIndex = 6;
            // 
            // btnCalculatePayment
            // 
            this.btnCalculatePayment.Location = new System.Drawing.Point(91, 67);
            this.btnCalculatePayment.Name = "btnCalculatePayment";
            this.btnCalculatePayment.Size = new System.Drawing.Size(137, 40);
            this.btnCalculatePayment.TabIndex = 7;
            this.btnCalculatePayment.Text = "Calculate Payment";
            this.btnCalculatePayment.UseVisualStyleBackColor = true;
            this.btnCalculatePayment.Click += new System.EventHandler(this.btnCalculatePayment_Click);
            // 
            // frmAmortizationSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 436);
            this.Controls.Add(this.btnCalculatePayment);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lblInterestLabel);
            this.Controls.Add(this.lblYearsLabel);
            this.Controls.Add(this.cboInterestRate);
            this.Controls.Add(this.cboYears);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.lblLoanAmountLabel);
            this.Name = "frmAmortizationSchedule";
            this.Text = "Amortization Schedule";
            this.Load += new System.EventHandler(this.frmAmortizationSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanAmountLabel;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.ComboBox cboYears;
        private System.Windows.Forms.ComboBox cboInterestRate;
        private System.Windows.Forms.Label lblYearsLabel;
        private System.Windows.Forms.Label lblInterestLabel;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnCalculatePayment;
    }
}

