namespace ListControlsExerciseProject
{
    partial class frmListControlsExercise
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
            this.cboQuantityList = new System.Windows.Forms.ComboBox();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.lblOrderLabel = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboQuantityList
            // 
            this.cboQuantityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuantityList.FormattingEnabled = true;
            this.cboQuantityList.Location = new System.Drawing.Point(8, 12);
            this.cboQuantityList.Name = "cboQuantityList";
            this.cboQuantityList.Size = new System.Drawing.Size(128, 21);
            this.cboQuantityList.TabIndex = 0;
            this.cboQuantityList.SelectedIndexChanged += new System.EventHandler(this.cboProductList_SelectedIndexChanged);
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(152, 32);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(140, 160);
            this.lstOrder.TabIndex = 1;
            // 
            // lblOrderLabel
            // 
            this.lblOrderLabel.Location = new System.Drawing.Point(152, 12);
            this.lblOrderLabel.Name = "lblOrderLabel";
            this.lblOrderLabel.Size = new System.Drawing.Size(140, 20);
            this.lblOrderLabel.TabIndex = 2;
            this.lblOrderLabel.Text = "Current Order:";
            this.lblOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(224, 204);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 24);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(152, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 24);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmListControlsExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 237);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblOrderLabel);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.cboQuantityList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListControlsExercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Controls Exercise";
            this.Load += new System.EventHandler(this.frmListControlsExercise_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboQuantityList;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Label lblOrderLabel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
    }
}

