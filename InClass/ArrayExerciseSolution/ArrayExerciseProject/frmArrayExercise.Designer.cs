namespace ArrayExerciseProject
{
    partial class frmArrayExercise
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
            this.lblRooms = new System.Windows.Forms.Label();
            this.btnGetRooms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRooms
            // 
            this.lblRooms.BackColor = System.Drawing.Color.White;
            this.lblRooms.Location = new System.Drawing.Point(8, 12);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(132, 84);
            this.lblRooms.TabIndex = 0;
            // 
            // btnGetRooms
            // 
            this.btnGetRooms.Location = new System.Drawing.Point(156, 16);
            this.btnGetRooms.Name = "btnGetRooms";
            this.btnGetRooms.Size = new System.Drawing.Size(76, 28);
            this.btnGetRooms.TabIndex = 1;
            this.btnGetRooms.Text = "Get Rooms";
            this.btnGetRooms.UseVisualStyleBackColor = true;
            this.btnGetRooms.Click += new System.EventHandler(this.btnGetRooms_Click);
            // 
            // frmArrayExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 108);
            this.Controls.Add(this.btnGetRooms);
            this.Controls.Add(this.lblRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArrayExercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array Exercise";
            this.Load += new System.EventHandler(this.frmArrayExercise_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Button btnGetRooms;
    }
}

