namespace SengYangDelicatessenProject
{
    partial class frmDelicatessen
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
            this.grpMainMenu = new System.Windows.Forms.GroupBox();
            this.chkSoda = new System.Windows.Forms.CheckBox();
            this.chkSalad = new System.Windows.Forms.CheckBox();
            this.chkBagel = new System.Windows.Forms.CheckBox();
            this.grpBagelFilling = new System.Windows.Forms.GroupBox();
            this.chkCreemCheese = new System.Windows.Forms.CheckBox();
            this.chkLox = new System.Windows.Forms.CheckBox();
            this.grpSaladChoice = new System.Windows.Forms.GroupBox();
            this.rdbChef = new System.Windows.Forms.RadioButton();
            this.rdbSpinach = new System.Windows.Forms.RadioButton();
            this.grpSoda = new System.Windows.Forms.GroupBox();
            this.rdbCreamSoda = new System.Windows.Forms.RadioButton();
            this.rdbCola = new System.Windows.Forms.RadioButton();
            this.lblBagelTotalCost = new System.Windows.Forms.Label();
            this.lblBagelSubtotal = new System.Windows.Forms.Label();
            this.lblSpinachSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalSoda = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalSaladCost = new System.Windows.Forms.Label();
            this.lblTotalSodaCost = new System.Windows.Forms.Label();
            this.grpMainMenu.SuspendLayout();
            this.grpBagelFilling.SuspendLayout();
            this.grpSaladChoice.SuspendLayout();
            this.grpSoda.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMainMenu
            // 
            this.grpMainMenu.Controls.Add(this.chkSoda);
            this.grpMainMenu.Controls.Add(this.chkSalad);
            this.grpMainMenu.Controls.Add(this.chkBagel);
            this.grpMainMenu.Location = new System.Drawing.Point(26, 13);
            this.grpMainMenu.Name = "grpMainMenu";
            this.grpMainMenu.Size = new System.Drawing.Size(108, 275);
            this.grpMainMenu.TabIndex = 0;
            this.grpMainMenu.TabStop = false;
            this.grpMainMenu.Text = "Main Menu";
            // 
            // chkSoda
            // 
            this.chkSoda.AutoSize = true;
            this.chkSoda.Location = new System.Drawing.Point(20, 194);
            this.chkSoda.Name = "chkSoda";
            this.chkSoda.Size = new System.Drawing.Size(63, 21);
            this.chkSoda.TabIndex = 2;
            this.chkSoda.Text = "Soda";
            this.chkSoda.UseVisualStyleBackColor = true;
            this.chkSoda.CheckedChanged += new System.EventHandler(this.chkSoda_CheckedChanged);
            // 
            // chkSalad
            // 
            this.chkSalad.AutoSize = true;
            this.chkSalad.Location = new System.Drawing.Point(20, 107);
            this.chkSalad.Name = "chkSalad";
            this.chkSalad.Size = new System.Drawing.Size(66, 21);
            this.chkSalad.TabIndex = 1;
            this.chkSalad.Text = "Salad";
            this.chkSalad.UseVisualStyleBackColor = true;
            this.chkSalad.CheckedChanged += new System.EventHandler(this.chkSalad_CheckedChanged);
            // 
            // chkBagel
            // 
            this.chkBagel.AutoSize = true;
            this.chkBagel.Location = new System.Drawing.Point(20, 21);
            this.chkBagel.Name = "chkBagel";
            this.chkBagel.Size = new System.Drawing.Size(66, 21);
            this.chkBagel.TabIndex = 0;
            this.chkBagel.Text = "Bagel";
            this.chkBagel.UseVisualStyleBackColor = true;
            this.chkBagel.CheckedChanged += new System.EventHandler(this.chkBagel_CheckedChanged);
            // 
            // grpBagelFilling
            // 
            this.grpBagelFilling.Controls.Add(this.chkCreemCheese);
            this.grpBagelFilling.Controls.Add(this.chkLox);
            this.grpBagelFilling.Location = new System.Drawing.Point(140, 34);
            this.grpBagelFilling.Name = "grpBagelFilling";
            this.grpBagelFilling.Size = new System.Drawing.Size(141, 80);
            this.grpBagelFilling.TabIndex = 1;
            this.grpBagelFilling.TabStop = false;
            this.grpBagelFilling.Text = "Bagel Filling";
            // 
            // chkCreemCheese
            // 
            this.chkCreemCheese.AutoSize = true;
            this.chkCreemCheese.Location = new System.Drawing.Point(16, 48);
            this.chkCreemCheese.Name = "chkCreemCheese";
            this.chkCreemCheese.Size = new System.Drawing.Size(123, 21);
            this.chkCreemCheese.TabIndex = 1;
            this.chkCreemCheese.Text = "Cream Cheese";
            this.chkCreemCheese.UseVisualStyleBackColor = true;
            this.chkCreemCheese.CheckedChanged += new System.EventHandler(this.chkCreemCheese_CheckedChanged);
            // 
            // chkLox
            // 
            this.chkLox.AutoSize = true;
            this.chkLox.Location = new System.Drawing.Point(16, 21);
            this.chkLox.Name = "chkLox";
            this.chkLox.Size = new System.Drawing.Size(52, 21);
            this.chkLox.TabIndex = 0;
            this.chkLox.Text = "Lox";
            this.chkLox.UseVisualStyleBackColor = true;
            this.chkLox.CheckedChanged += new System.EventHandler(this.chkLox_CheckedChanged);
            // 
            // grpSaladChoice
            // 
            this.grpSaladChoice.Controls.Add(this.rdbChef);
            this.grpSaladChoice.Controls.Add(this.rdbSpinach);
            this.grpSaladChoice.Location = new System.Drawing.Point(140, 120);
            this.grpSaladChoice.Name = "grpSaladChoice";
            this.grpSaladChoice.Size = new System.Drawing.Size(139, 81);
            this.grpSaladChoice.TabIndex = 2;
            this.grpSaladChoice.TabStop = false;
            this.grpSaladChoice.Text = "Salad Choice";
            // 
            // rdbChef
            // 
            this.rdbChef.AutoSize = true;
            this.rdbChef.Location = new System.Drawing.Point(20, 49);
            this.rdbChef.Name = "rdbChef";
            this.rdbChef.Size = new System.Drawing.Size(58, 21);
            this.rdbChef.TabIndex = 1;
            this.rdbChef.TabStop = true;
            this.rdbChef.Text = "Chef";
            this.rdbChef.UseVisualStyleBackColor = true;
            this.rdbChef.CheckedChanged += new System.EventHandler(this.rdbChef_CheckedChanged);
            // 
            // rdbSpinach
            // 
            this.rdbSpinach.AutoSize = true;
            this.rdbSpinach.Location = new System.Drawing.Point(20, 21);
            this.rdbSpinach.Name = "rdbSpinach";
            this.rdbSpinach.Size = new System.Drawing.Size(80, 21);
            this.rdbSpinach.TabIndex = 0;
            this.rdbSpinach.TabStop = true;
            this.rdbSpinach.Text = "Spinach";
            this.rdbSpinach.UseVisualStyleBackColor = true;
            this.rdbSpinach.CheckedChanged += new System.EventHandler(this.rdbSpinach_CheckedChanged);
            // 
            // grpSoda
            // 
            this.grpSoda.Controls.Add(this.rdbCreamSoda);
            this.grpSoda.Controls.Add(this.rdbCola);
            this.grpSoda.Location = new System.Drawing.Point(140, 207);
            this.grpSoda.Name = "grpSoda";
            this.grpSoda.Size = new System.Drawing.Size(141, 81);
            this.grpSoda.TabIndex = 3;
            this.grpSoda.TabStop = false;
            this.grpSoda.Text = "Soda";
            // 
            // rdbCreamSoda
            // 
            this.rdbCreamSoda.AutoSize = true;
            this.rdbCreamSoda.Location = new System.Drawing.Point(16, 48);
            this.rdbCreamSoda.Name = "rdbCreamSoda";
            this.rdbCreamSoda.Size = new System.Drawing.Size(107, 21);
            this.rdbCreamSoda.TabIndex = 1;
            this.rdbCreamSoda.TabStop = true;
            this.rdbCreamSoda.Text = "Cream Soda";
            this.rdbCreamSoda.UseVisualStyleBackColor = true;
            this.rdbCreamSoda.CheckedChanged += new System.EventHandler(this.rdbCreamSoda_CheckedChanged);
            // 
            // rdbCola
            // 
            this.rdbCola.AutoSize = true;
            this.rdbCola.Location = new System.Drawing.Point(16, 21);
            this.rdbCola.Name = "rdbCola";
            this.rdbCola.Size = new System.Drawing.Size(57, 21);
            this.rdbCola.TabIndex = 0;
            this.rdbCola.TabStop = true;
            this.rdbCola.Text = "Cola";
            this.rdbCola.UseVisualStyleBackColor = true;
            this.rdbCola.CheckedChanged += new System.EventHandler(this.rdbCola_CheckedChanged);
            // 
            // lblBagelTotalCost
            // 
            this.lblBagelTotalCost.AutoSize = true;
            this.lblBagelTotalCost.Location = new System.Drawing.Point(287, 38);
            this.lblBagelTotalCost.Name = "lblBagelTotalCost";
            this.lblBagelTotalCost.Size = new System.Drawing.Size(132, 17);
            this.lblBagelTotalCost.TabIndex = 4;
            this.lblBagelTotalCost.Text = "Total Cost of Bagel:";
            // 
            // lblBagelSubtotal
            // 
            this.lblBagelSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBagelSubtotal.Location = new System.Drawing.Point(325, 60);
            this.lblBagelSubtotal.Name = "lblBagelSubtotal";
            this.lblBagelSubtotal.Size = new System.Drawing.Size(100, 23);
            this.lblBagelSubtotal.TabIndex = 5;
            this.lblBagelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpinachSubtotal
            // 
            this.lblSpinachSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSpinachSubtotal.Location = new System.Drawing.Point(325, 147);
            this.lblSpinachSubtotal.Name = "lblSpinachSubtotal";
            this.lblSpinachSubtotal.Size = new System.Drawing.Size(100, 23);
            this.lblSpinachSubtotal.TabIndex = 6;
            this.lblSpinachSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotalSoda
            // 
            this.lblSubtotalSoda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSubtotalSoda.Location = new System.Drawing.Point(325, 235);
            this.lblSubtotalSoda.Name = "lblSubtotalSoda";
            this.lblSubtotalSoda.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotalSoda.TabIndex = 7;
            this.lblSubtotalSoda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalCost.Location = new System.Drawing.Point(325, 287);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(100, 23);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Location = new System.Drawing.Point(275, 287);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(44, 17);
            this.lblTotalLabel.TabIndex = 9;
            this.lblTotalLabel.Text = "Total:";
            this.lblTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalSaladCost
            // 
            this.lblTotalSaladCost.AutoSize = true;
            this.lblTotalSaladCost.Location = new System.Drawing.Point(287, 124);
            this.lblTotalSaladCost.Name = "lblTotalSaladCost";
            this.lblTotalSaladCost.Size = new System.Drawing.Size(132, 17);
            this.lblTotalSaladCost.TabIndex = 10;
            this.lblTotalSaladCost.Text = "Total Cost of Salad:";
            // 
            // lblTotalSodaCost
            // 
            this.lblTotalSodaCost.AutoSize = true;
            this.lblTotalSodaCost.Location = new System.Drawing.Point(287, 211);
            this.lblTotalSodaCost.Name = "lblTotalSodaCost";
            this.lblTotalSodaCost.Size = new System.Drawing.Size(129, 17);
            this.lblTotalSodaCost.TabIndex = 11;
            this.lblTotalSodaCost.Text = "Total Cost of Soda:";
            // 
            // frmDelicatessen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 331);
            this.Controls.Add(this.lblTotalSodaCost);
            this.Controls.Add(this.lblTotalSaladCost);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblSubtotalSoda);
            this.Controls.Add(this.lblSpinachSubtotal);
            this.Controls.Add(this.lblBagelSubtotal);
            this.Controls.Add(this.lblBagelTotalCost);
            this.Controls.Add(this.grpSoda);
            this.Controls.Add(this.grpSaladChoice);
            this.Controls.Add(this.grpBagelFilling);
            this.Controls.Add(this.grpMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDelicatessen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delicatessen";
            this.Load += new System.EventHandler(this.frmDelicatessen_Load);
            this.grpMainMenu.ResumeLayout(false);
            this.grpMainMenu.PerformLayout();
            this.grpBagelFilling.ResumeLayout(false);
            this.grpBagelFilling.PerformLayout();
            this.grpSaladChoice.ResumeLayout(false);
            this.grpSaladChoice.PerformLayout();
            this.grpSoda.ResumeLayout(false);
            this.grpSoda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMainMenu;
        private System.Windows.Forms.CheckBox chkSoda;
        private System.Windows.Forms.CheckBox chkSalad;
        private System.Windows.Forms.CheckBox chkBagel;
        private System.Windows.Forms.GroupBox grpBagelFilling;
        private System.Windows.Forms.CheckBox chkCreemCheese;
        private System.Windows.Forms.CheckBox chkLox;
        private System.Windows.Forms.GroupBox grpSaladChoice;
        private System.Windows.Forms.RadioButton rdbChef;
        private System.Windows.Forms.RadioButton rdbSpinach;
        private System.Windows.Forms.GroupBox grpSoda;
        private System.Windows.Forms.RadioButton rdbCreamSoda;
        private System.Windows.Forms.RadioButton rdbCola;
        private System.Windows.Forms.Label lblBagelTotalCost;
        private System.Windows.Forms.Label lblBagelSubtotal;
        private System.Windows.Forms.Label lblSpinachSubtotal;
        private System.Windows.Forms.Label lblSubtotalSoda;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalSaladCost;
        private System.Windows.Forms.Label lblTotalSodaCost;
    }
}

