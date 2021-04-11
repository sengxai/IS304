namespace FirstLookProject
{
    partial class frmFirstLook
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
            this.btnFirstLook = new System.Windows.Forms.Button();
            this.dtpHola = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirstLook
            // 
            this.btnFirstLook.Location = new System.Drawing.Point(608, 381);
            this.btnFirstLook.Name = "btnFirstLook";
            this.btnFirstLook.Size = new System.Drawing.Size(112, 30);
            this.btnFirstLook.TabIndex = 0;
            this.btnFirstLook.Text = "Look Here";
            this.btnFirstLook.UseVisualStyleBackColor = true;
            this.btnFirstLook.Click += new System.EventHandler(this.btnFirstLook_Click);
            // 
            // dtpHola
            // 
            this.dtpHola.Location = new System.Drawing.Point(182, 254);
            this.dtpHola.Name = "dtpHola";
            this.dtpHola.Size = new System.Drawing.Size(200, 22);
            this.dtpHola.TabIndex = 2;
            this.dtpHola.ValueChanged += new System.EventHandler(this.dtpHola_ValueChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(83, 94);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmFirstLook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtpHola);
            this.Controls.Add(this.btnFirstLook);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFirstLook";
            this.Text = "A First Look";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFirstLook;
        private System.Windows.Forms.DateTimePicker dtpHola;
        private System.Windows.Forms.Button btnClose;
    }
}

