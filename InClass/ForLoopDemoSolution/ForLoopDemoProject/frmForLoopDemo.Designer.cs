﻿namespace ForLoopDemoProject
{
    partial class frmForLoopDemo
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
            this.btnGetColors = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetColors
            // 
            this.btnGetColors.Location = new System.Drawing.Point(256, 12);
            this.btnGetColors.Name = "btnGetColors";
            this.btnGetColors.Size = new System.Drawing.Size(96, 33);
            this.btnGetColors.TabIndex = 0;
            this.btnGetColors.Text = "Get Colors";
            this.btnGetColors.UseVisualStyleBackColor = true;
            this.btnGetColors.Click += new System.EventHandler(this.btnGetColors_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(217, 370);
            this.txtOutput.TabIndex = 1;
            // 
            // frmForLoopDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 423);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnGetColors);
            this.Name = "frmForLoopDemo";
            this.Text = "For Loop Demo";
            this.Load += new System.EventHandler(this.frmForLoopDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetColors;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

