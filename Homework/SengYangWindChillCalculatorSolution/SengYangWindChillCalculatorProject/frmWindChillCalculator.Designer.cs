namespace SengYangWindChillCalculatorProject
{
    partial class frmWindChillCalculator
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
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.lblAirTemp = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.txtWindSpeed = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblWindChill = new System.Windows.Forms.Label();
            this.lblFrostbiteLabel = new System.Windows.Forms.Label();
            this.lblFrostbiteIndicator = new System.Windows.Forms.Label();
            this.lblWindChillLabel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(171, 12);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(127, 22);
            this.txtTemperature.TabIndex = 0;
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAirTemp
            // 
            this.lblAirTemp.AutoSize = true;
            this.lblAirTemp.Location = new System.Drawing.Point(32, 15);
            this.lblAirTemp.Name = "lblAirTemp";
            this.lblAirTemp.Size = new System.Drawing.Size(133, 17);
            this.lblAirTemp.TabIndex = 1;
            this.lblAirTemp.Text = "Air Temperature °F:";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Location = new System.Drawing.Point(45, 55);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(120, 17);
            this.lblWindSpeed.TabIndex = 2;
            this.lblWindSpeed.Text = "Wind Speed mph:";
            // 
            // txtWindSpeed
            // 
            this.txtWindSpeed.Location = new System.Drawing.Point(171, 52);
            this.txtWindSpeed.Name = "txtWindSpeed";
            this.txtWindSpeed.Size = new System.Drawing.Size(127, 22);
            this.txtWindSpeed.TabIndex = 3;
            this.txtWindSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(35, 90);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(126, 30);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblWindChill
            // 
            this.lblWindChill.BackColor = System.Drawing.Color.White;
            this.lblWindChill.Location = new System.Drawing.Point(172, 138);
            this.lblWindChill.Name = "lblWindChill";
            this.lblWindChill.Size = new System.Drawing.Size(126, 27);
            this.lblWindChill.TabIndex = 5;
            this.lblWindChill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFrostbiteLabel
            // 
            this.lblFrostbiteLabel.AutoSize = true;
            this.lblFrostbiteLabel.Location = new System.Drawing.Point(52, 194);
            this.lblFrostbiteLabel.Name = "lblFrostbiteLabel";
            this.lblFrostbiteLabel.Size = new System.Drawing.Size(114, 17);
            this.lblFrostbiteLabel.TabIndex = 6;
            this.lblFrostbiteLabel.Text = "Time to frostbite:";
            // 
            // lblFrostbiteIndicator
            // 
            this.lblFrostbiteIndicator.BackColor = System.Drawing.Color.White;
            this.lblFrostbiteIndicator.Location = new System.Drawing.Point(172, 181);
            this.lblFrostbiteIndicator.Name = "lblFrostbiteIndicator";
            this.lblFrostbiteIndicator.Size = new System.Drawing.Size(126, 43);
            this.lblFrostbiteIndicator.TabIndex = 7;
            this.lblFrostbiteIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWindChillLabel
            // 
            this.lblWindChillLabel.AutoSize = true;
            this.lblWindChillLabel.Location = new System.Drawing.Point(73, 143);
            this.lblWindChillLabel.Name = "lblWindChillLabel";
            this.lblWindChillLabel.Size = new System.Drawing.Size(92, 17);
            this.lblWindChillLabel.TabIndex = 8;
            this.lblWindChillLabel.Text = "Wind Chill °F:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(171, 90);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWindChillCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 242);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWindChillLabel);
            this.Controls.Add(this.lblFrostbiteIndicator);
            this.Controls.Add(this.lblFrostbiteLabel);
            this.Controls.Add(this.lblWindChill);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWindSpeed);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.lblAirTemp);
            this.Controls.Add(this.txtTemperature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWindChillCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wind Chill Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label lblAirTemp;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.TextBox txtWindSpeed;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblWindChill;
        private System.Windows.Forms.Label lblFrostbiteLabel;
        private System.Windows.Forms.Label lblFrostbiteIndicator;
        private System.Windows.Forms.Label lblWindChillLabel;
        private System.Windows.Forms.Button btnExit;
    }
}

