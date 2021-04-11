namespace VariableCalcProject
{
    partial class frmVariableCalc
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
            this.txtNumberOne = new System.Windows.Forms.TextBox();
            this.txtNumberTwo = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnNaiveAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnCalcBathTowels = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Location = new System.Drawing.Point(32, 26);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOne.TabIndex = 0;
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new System.Drawing.Point(32, 54);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(100, 22);
            this.txtNumberTwo.TabIndex = 1;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(39, 100);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(92, 32);
            this.lblAnswer.TabIndex = 2;
            // 
            // btnNaiveAdd
            // 
            this.btnNaiveAdd.Location = new System.Drawing.Point(195, 26);
            this.btnNaiveAdd.Name = "btnNaiveAdd";
            this.btnNaiveAdd.Size = new System.Drawing.Size(100, 32);
            this.btnNaiveAdd.TabIndex = 3;
            this.btnNaiveAdd.Text = "Naive Add";
            this.btnNaiveAdd.UseVisualStyleBackColor = true;
            this.btnNaiveAdd.Click += new System.EventHandler(this.btnNaiveAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(195, 93);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(195, 122);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(75, 23);
            this.btnPower.TabIndex = 6;
            this.btnPower.Text = "Power";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnCalcBathTowels
            // 
            this.btnCalcBathTowels.Location = new System.Drawing.Point(194, 159);
            this.btnCalcBathTowels.Name = "btnCalcBathTowels";
            this.btnCalcBathTowels.Size = new System.Drawing.Size(101, 42);
            this.btnCalcBathTowels.TabIndex = 7;
            this.btnCalcBathTowels.Text = "Calculate Bath Towels";
            this.btnCalcBathTowels.UseVisualStyleBackColor = true;
            this.btnCalcBathTowels.Click += new System.EventHandler(this.btnCalcBathTowels_Click);
            // 
            // frmVariableCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.btnCalcBathTowels);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNaiveAdd);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtNumberTwo);
            this.Controls.Add(this.txtNumberOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVariableCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variable and Calculations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOne;
        private System.Windows.Forms.TextBox txtNumberTwo;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnNaiveAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnCalcBathTowels;
    }
}

