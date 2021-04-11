namespace MethodExerciseSolutionsProject
{
    partial class frmMethodExerciseSolutions
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
            this.lblInstructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructionLabel
            // 
            this.lblInstructionLabel.BackColor = System.Drawing.Color.White;
            this.lblInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionLabel.Location = new System.Drawing.Point(8, 8);
            this.lblInstructionLabel.Name = "lblInstructionLabel";
            this.lblInstructionLabel.Size = new System.Drawing.Size(420, 156);
            this.lblInstructionLabel.TabIndex = 0;
            this.lblInstructionLabel.Text = "See Code Window for Solutions";
            this.lblInstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMethodExerciseSolutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 171);
            this.Controls.Add(this.lblInstructionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMethodExerciseSolutions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Method Exercise Solutions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInstructionLabel;
    }
}

