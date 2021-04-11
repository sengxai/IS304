namespace LoopSearchDemoProject
{
    partial class Form1
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
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblSearchForLabel = new System.Windows.Forms.Label();
            this.lblEnterPhraseLabel = new System.Windows.Forms.Label();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.txtCharacter = new System.Windows.Forms.TextBox();
            this.lblAnalysis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(119, 115);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 37);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Search";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lblSearchForLabel
            // 
            this.lblSearchForLabel.AutoSize = true;
            this.lblSearchForLabel.Location = new System.Drawing.Point(64, 65);
            this.lblSearchForLabel.Name = "lblSearchForLabel";
            this.lblSearchForLabel.Size = new System.Drawing.Size(78, 17);
            this.lblSearchForLabel.TabIndex = 1;
            this.lblSearchForLabel.Text = "Search for:";
            // 
            // lblEnterPhraseLabel
            // 
            this.lblEnterPhraseLabel.AutoSize = true;
            this.lblEnterPhraseLabel.Location = new System.Drawing.Point(47, 26);
            this.lblEnterPhraseLabel.Name = "lblEnterPhraseLabel";
            this.lblEnterPhraseLabel.Size = new System.Drawing.Size(95, 17);
            this.lblEnterPhraseLabel.TabIndex = 2;
            this.lblEnterPhraseLabel.Text = "Enter Phrase:";
            // 
            // txtPhrase
            // 
            this.txtPhrase.Location = new System.Drawing.Point(148, 26);
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.Size = new System.Drawing.Size(543, 22);
            this.txtPhrase.TabIndex = 3;
            // 
            // txtCharacter
            // 
            this.txtCharacter.Location = new System.Drawing.Point(148, 65);
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.Size = new System.Drawing.Size(46, 22);
            this.txtCharacter.TabIndex = 4;
            // 
            // lblAnalysis
            // 
            this.lblAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAnalysis.Location = new System.Drawing.Point(210, 68);
            this.lblAnalysis.Name = "lblAnalysis";
            this.lblAnalysis.Size = new System.Drawing.Size(481, 84);
            this.lblAnalysis.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 194);
            this.Controls.Add(this.lblAnalysis);
            this.Controls.Add(this.txtCharacter);
            this.Controls.Add(this.txtPhrase);
            this.Controls.Add(this.lblEnterPhraseLabel);
            this.Controls.Add(this.lblSearchForLabel);
            this.Controls.Add(this.btnAnalyze);
            this.Name = "Form1";
            this.Text = "Phrase Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblSearchForLabel;
        private System.Windows.Forms.Label lblEnterPhraseLabel;
        private System.Windows.Forms.TextBox txtPhrase;
        private System.Windows.Forms.TextBox txtCharacter;
        private System.Windows.Forms.Label lblAnalysis;
    }
}

