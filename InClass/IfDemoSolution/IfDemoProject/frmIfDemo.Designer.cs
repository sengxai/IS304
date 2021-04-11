namespace IfDemoProject
{
    partial class frmIfDemo
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
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblForecast = new System.Windows.Forms.Label();
            this.btnForecast = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(48, 35);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(100, 22);
            this.txtTeamName.TabIndex = 0;
            // 
            // lblForecast
            // 
            this.lblForecast.BackColor = System.Drawing.Color.White;
            this.lblForecast.Location = new System.Drawing.Point(45, 77);
            this.lblForecast.Name = "lblForecast";
            this.lblForecast.Size = new System.Drawing.Size(220, 74);
            this.lblForecast.TabIndex = 1;
            this.lblForecast.Click += new System.EventHandler(this.lblForecast_Click);
            // 
            // btnForecast
            // 
            this.btnForecast.Location = new System.Drawing.Point(169, 31);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(96, 26);
            this.btnForecast.TabIndex = 2;
            this.btnForecast.Text = "Forecast";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(48, 167);
            this.txtGuess.MaxLength = 2;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(53, 22);
            this.txtGuess.TabIndex = 3;
            // 
            // lblFeedback
            // 
            this.lblFeedback.BackColor = System.Drawing.Color.White;
            this.lblFeedback.Location = new System.Drawing.Point(45, 208);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(179, 80);
            this.lblFeedback.TabIndex = 4;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(123, 163);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(125, 31);
            this.btnEvaluate.TabIndex = 5;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // frmIfDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 320);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnForecast);
            this.Controls.Add(this.lblForecast);
            this.Controls.Add(this.txtTeamName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIfDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "If Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblForecast;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnEvaluate;
    }
}

