namespace LoopExerciseProject
{
    partial class frmLoopExercise
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
            this.txtParagraph = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtParagraph
            // 
            this.txtParagraph.Location = new System.Drawing.Point(8, 8);
            this.txtParagraph.MaxLength = 30000;
            this.txtParagraph.Multiline = true;
            this.txtParagraph.Name = "txtParagraph";
            this.txtParagraph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParagraph.Size = new System.Drawing.Size(564, 116);
            this.txtParagraph.TabIndex = 0;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(488, 136);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(80, 28);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Word Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lblWordCount
            // 
            this.lblWordCount.BackColor = System.Drawing.Color.White;
            this.lblWordCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWordCount.Location = new System.Drawing.Point(8, 140);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(336, 24);
            this.lblWordCount.TabIndex = 2;
            this.lblWordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(392, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 28);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmLoopExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 175);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtParagraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoopExercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loop Exercise - Word Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParagraph;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Button btnClear;
    }
}

