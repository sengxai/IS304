namespace InterfaceControlsProject
{
    partial class frmInterfaceControls
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
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblEnterNameLabel = new System.Windows.Forms.Label();
            this.txtMultiLine = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnEscape = new System.Windows.Forms.Button();
            this.btnSomething = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtStuff = new System.Windows.Forms.TextBox();
            this.txtThings = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(120, 36);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(316, 22);
            this.txtEnterName.TabIndex = 4;
            this.txtEnterName.TextChanged += new System.EventHandler(this.txtEnterName_TextChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOutput.Location = new System.Drawing.Point(120, 64);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(316, 31);
            this.lblOutput.TabIndex = 1;
            // 
            // lblEnterNameLabel
            // 
            this.lblEnterNameLabel.AutoSize = true;
            this.lblEnterNameLabel.Location = new System.Drawing.Point(28, 36);
            this.lblEnterNameLabel.Name = "lblEnterNameLabel";
            this.lblEnterNameLabel.Size = new System.Drawing.Size(83, 17);
            this.lblEnterNameLabel.TabIndex = 3;
            this.lblEnterNameLabel.Text = "Enter Name";
            this.lblEnterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMultiLine
            // 
            this.txtMultiLine.Location = new System.Drawing.Point(120, 100);
            this.txtMultiLine.Multiline = true;
            this.txtMultiLine.Name = "txtMultiLine";
            this.txtMultiLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMultiLine.Size = new System.Drawing.Size(316, 138);
            this.txtMultiLine.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(124, 264);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 27);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnEscape
            // 
            this.btnEscape.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEscape.Location = new System.Drawing.Point(224, 264);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(75, 27);
            this.btnEscape.TabIndex = 1;
            this.btnEscape.Text = "Escape";
            this.btnEscape.UseVisualStyleBackColor = true;
            this.btnEscape.Click += new System.EventHandler(this.btnEscape_Click);
            // 
            // btnSomething
            // 
            this.btnSomething.Location = new System.Drawing.Point(324, 264);
            this.btnSomething.Name = "btnSomething";
            this.btnSomething.Size = new System.Drawing.Size(94, 27);
            this.btnSomething.TabIndex = 0;
            this.btnSomething.Text = "So&mething";
            this.btnSomething.UseVisualStyleBackColor = true;
            this.btnSomething.Click += new System.EventHandler(this.btnSomething_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(116, 308);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(296, 22);
            this.txtAddress.TabIndex = 5;
            // 
            // txtStuff
            // 
            this.txtStuff.Location = new System.Drawing.Point(116, 336);
            this.txtStuff.Name = "txtStuff";
            this.txtStuff.Size = new System.Drawing.Size(76, 22);
            this.txtStuff.TabIndex = 6;
            // 
            // txtThings
            // 
            this.txtThings.Location = new System.Drawing.Point(116, 364);
            this.txtThings.Name = "txtThings";
            this.txtThings.Size = new System.Drawing.Size(296, 22);
            this.txtThings.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(52, 308);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(68, 336);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 17);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(80, 364);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(312, 336);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 22);
            this.txtZipCode.TabIndex = 11;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(244, 340);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(65, 17);
            this.lblZip.TabIndex = 12;
            this.lblZip.Text = "Zip Code";
            // 
            // frmInterfaceControls
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnEscape;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtThings);
            this.Controls.Add(this.txtStuff);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnSomething);
            this.Controls.Add(this.btnEscape);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtMultiLine);
            this.Controls.Add(this.lblEnterNameLabel);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtEnterName);
            this.Name = "frmInterfaceControls";
            this.Text = "00";
            this.Load += new System.EventHandler(this.frmInterfaceControls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblEnterNameLabel;
        private System.Windows.Forms.TextBox txtMultiLine;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnEscape;
        private System.Windows.Forms.Button btnSomething;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtStuff;
        private System.Windows.Forms.TextBox txtThings;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblZip;
    }
}

