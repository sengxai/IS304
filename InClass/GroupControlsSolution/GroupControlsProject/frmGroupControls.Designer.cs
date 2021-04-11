namespace GroupControlsProject
{
    partial class frmGroupControls
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
            this.grpSizes = new System.Windows.Forms.GroupBox();
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.grpDesignElements = new System.Windows.Forms.GroupBox();
            this.rdbXLarge = new System.Windows.Forms.RadioButton();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.chkLongSleeves = new System.Windows.Forms.CheckBox();
            this.chkLogo = new System.Windows.Forms.CheckBox();
            this.chkFlipSequins = new System.Windows.Forms.CheckBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.grpSizes.SuspendLayout();
            this.grpColors.SuspendLayout();
            this.grpDesignElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSizes
            // 
            this.grpSizes.Controls.Add(this.rdbSmall);
            this.grpSizes.Controls.Add(this.rdbMedium);
            this.grpSizes.Controls.Add(this.rdbLarge);
            this.grpSizes.Controls.Add(this.rdbXLarge);
            this.grpSizes.Location = new System.Drawing.Point(12, 12);
            this.grpSizes.Name = "grpSizes";
            this.grpSizes.Size = new System.Drawing.Size(119, 140);
            this.grpSizes.TabIndex = 0;
            this.grpSizes.TabStop = false;
            this.grpSizes.Text = "Select size:";
            // 
            // grpColors
            // 
            this.grpColors.Controls.Add(this.rdbWhite);
            this.grpColors.Controls.Add(this.rdbGreen);
            this.grpColors.Controls.Add(this.rdbBlue);
            this.grpColors.Controls.Add(this.rdbRed);
            this.grpColors.Location = new System.Drawing.Point(159, 12);
            this.grpColors.Name = "grpColors";
            this.grpColors.Size = new System.Drawing.Size(129, 147);
            this.grpColors.TabIndex = 1;
            this.grpColors.TabStop = false;
            this.grpColors.Text = "Select color:";
            // 
            // grpDesignElements
            // 
            this.grpDesignElements.Controls.Add(this.chkFlipSequins);
            this.grpDesignElements.Controls.Add(this.chkLogo);
            this.grpDesignElements.Controls.Add(this.chkLongSleeves);
            this.grpDesignElements.Location = new System.Drawing.Point(327, 12);
            this.grpDesignElements.Name = "grpDesignElements";
            this.grpDesignElements.Size = new System.Drawing.Size(156, 158);
            this.grpDesignElements.TabIndex = 2;
            this.grpDesignElements.TabStop = false;
            this.grpDesignElements.Text = "Select options:";
            this.grpDesignElements.Enter += new System.EventHandler(this.grpDesignElements_Enter);
            // 
            // rdbXLarge
            // 
            this.rdbXLarge.AutoSize = true;
            this.rdbXLarge.Location = new System.Drawing.Point(15, 21);
            this.rdbXLarge.Name = "rdbXLarge";
            this.rdbXLarge.Size = new System.Drawing.Size(75, 21);
            this.rdbXLarge.TabIndex = 0;
            this.rdbXLarge.TabStop = true;
            this.rdbXLarge.Text = "XLarge";
            this.rdbXLarge.UseVisualStyleBackColor = true;
            this.rdbXLarge.CheckedChanged += new System.EventHandler(this.rdbXLarge_CheckedChanged);
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Location = new System.Drawing.Point(15, 48);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(66, 21);
            this.rdbLarge.TabIndex = 1;
            this.rdbLarge.TabStop = true;
            this.rdbLarge.Text = "Large";
            this.rdbLarge.UseVisualStyleBackColor = true;
            this.rdbLarge.CheckedChanged += new System.EventHandler(this.rdbLarge_CheckedChanged);
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Location = new System.Drawing.Point(15, 75);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(78, 21);
            this.rdbMedium.TabIndex = 2;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = true;
            this.rdbMedium.CheckedChanged += new System.EventHandler(this.rdbMedium_CheckedChanged);
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(15, 102);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(63, 21);
            this.rdbSmall.TabIndex = 3;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            this.rdbSmall.CheckedChanged += new System.EventHandler(this.rdbSmall_CheckedChanged);
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(29, 20);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(55, 21);
            this.rdbRed.TabIndex = 0;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Location = new System.Drawing.Point(29, 48);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(57, 21);
            this.rdbBlue.TabIndex = 1;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Location = new System.Drawing.Point(29, 76);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(69, 21);
            this.rdbGreen.TabIndex = 2;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Location = new System.Drawing.Point(29, 104);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(65, 21);
            this.rdbWhite.TabIndex = 3;
            this.rdbWhite.TabStop = true;
            this.rdbWhite.Text = "White";
            this.rdbWhite.UseVisualStyleBackColor = true;
            // 
            // chkLongSleeves
            // 
            this.chkLongSleeves.AutoSize = true;
            this.chkLongSleeves.Location = new System.Drawing.Point(18, 32);
            this.chkLongSleeves.Name = "chkLongSleeves";
            this.chkLongSleeves.Size = new System.Drawing.Size(116, 21);
            this.chkLongSleeves.TabIndex = 0;
            this.chkLongSleeves.Text = "Long Sleeves";
            this.chkLongSleeves.UseVisualStyleBackColor = true;
            // 
            // chkLogo
            // 
            this.chkLogo.AutoSize = true;
            this.chkLogo.Location = new System.Drawing.Point(18, 72);
            this.chkLogo.Name = "chkLogo";
            this.chkLogo.Size = new System.Drawing.Size(62, 21);
            this.chkLogo.TabIndex = 1;
            this.chkLogo.Text = "Logo";
            this.chkLogo.UseVisualStyleBackColor = true;
            // 
            // chkFlipSequins
            // 
            this.chkFlipSequins.AutoSize = true;
            this.chkFlipSequins.Location = new System.Drawing.Point(18, 114);
            this.chkFlipSequins.Name = "chkFlipSequins";
            this.chkFlipSequins.Size = new System.Drawing.Size(107, 21);
            this.chkFlipSequins.TabIndex = 2;
            this.chkFlipSequins.Text = "Flip Sequins";
            this.chkFlipSequins.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOutput.Location = new System.Drawing.Point(327, 206);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 23);
            this.lblOutput.TabIndex = 3;
            // 
            // frmGroupControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 344);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.grpDesignElements);
            this.Controls.Add(this.grpColors);
            this.Controls.Add(this.grpSizes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGroupControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tee Shirt Store";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGroupControls_Paint);
            this.grpSizes.ResumeLayout(false);
            this.grpSizes.PerformLayout();
            this.grpColors.ResumeLayout(false);
            this.grpColors.PerformLayout();
            this.grpDesignElements.ResumeLayout(false);
            this.grpDesignElements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSizes;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.RadioButton rdbXLarge;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.RadioButton rdbWhite;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.GroupBox grpDesignElements;
        private System.Windows.Forms.CheckBox chkFlipSequins;
        private System.Windows.Forms.CheckBox chkLogo;
        private System.Windows.Forms.CheckBox chkLongSleeves;
        private System.Windows.Forms.Label lblOutput;
    }
}

