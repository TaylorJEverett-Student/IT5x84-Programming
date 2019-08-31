namespace StudentGrade
{
    partial class frmSalary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkLoan = new System.Windows.Forms.CheckBox();
            this.chkAwesomeness = new System.Windows.Forms.CheckBox();
            this.chkKiwiSaverOwn = new System.Windows.Forms.CheckBox();
            this.chkKiwiSaverBoss = new System.Windows.Forms.CheckBox();
            this.chkPoliteness = new System.Windows.Forms.CheckBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.txtLoanRate = new System.Windows.Forms.TextBox();
            this.txtAwesomeness = new System.Windows.Forms.TextBox();
            this.txtKiwiSaverOwn = new System.Windows.Forms.TextBox();
            this.txtPoliteness = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours worked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rate per hour $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tax (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deductable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Receivable";
            // 
            // chkLoan
            // 
            this.chkLoan.AutoSize = true;
            this.chkLoan.Location = new System.Drawing.Point(43, 133);
            this.chkLoan.Name = "chkLoan";
            this.chkLoan.Size = new System.Drawing.Size(107, 17);
            this.chkLoan.TabIndex = 5;
            this.chkLoan.Text = "Student Loan (%)";
            this.chkLoan.UseVisualStyleBackColor = true;
            // 
            // chkAwesomeness
            // 
            this.chkAwesomeness.AutoSize = true;
            this.chkAwesomeness.Location = new System.Drawing.Point(43, 156);
            this.chkAwesomeness.Name = "chkAwesomeness";
            this.chkAwesomeness.Size = new System.Drawing.Size(103, 17);
            this.chkAwesomeness.TabIndex = 6;
            this.chkAwesomeness.Text = "Awesomeness $";
            this.chkAwesomeness.UseVisualStyleBackColor = true;
            // 
            // chkKiwiSaverOwn
            // 
            this.chkKiwiSaverOwn.AutoSize = true;
            this.chkKiwiSaverOwn.Location = new System.Drawing.Point(43, 179);
            this.chkKiwiSaverOwn.Name = "chkKiwiSaverOwn";
            this.chkKiwiSaverOwn.Size = new System.Drawing.Size(90, 17);
            this.chkKiwiSaverOwn.TabIndex = 7;
            this.chkKiwiSaverOwn.Text = "KiwiSaver (%)";
            this.chkKiwiSaverOwn.UseVisualStyleBackColor = true;
            // 
            // chkKiwiSaverBoss
            // 
            this.chkKiwiSaverBoss.AutoSize = true;
            this.chkKiwiSaverBoss.Location = new System.Drawing.Point(43, 224);
            this.chkKiwiSaverBoss.Name = "chkKiwiSaverBoss";
            this.chkKiwiSaverBoss.Size = new System.Drawing.Size(96, 17);
            this.chkKiwiSaverBoss.TabIndex = 9;
            this.chkKiwiSaverBoss.Text = "KiwiSaver (3%)";
            this.chkKiwiSaverBoss.UseVisualStyleBackColor = true;
            // 
            // chkPoliteness
            // 
            this.chkPoliteness.AutoSize = true;
            this.chkPoliteness.Location = new System.Drawing.Point(43, 247);
            this.chkPoliteness.Name = "chkPoliteness";
            this.chkPoliteness.Size = new System.Drawing.Size(74, 17);
            this.chkPoliteness.TabIndex = 8;
            this.chkPoliteness.Text = "Politeness";
            this.chkPoliteness.UseVisualStyleBackColor = true;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(156, 19);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 10;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(156, 51);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 11;
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(156, 82);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(100, 20);
            this.txtTaxRate.TabIndex = 12;
            // 
            // txtLoanRate
            // 
            this.txtLoanRate.Location = new System.Drawing.Point(156, 130);
            this.txtLoanRate.Name = "txtLoanRate";
            this.txtLoanRate.Size = new System.Drawing.Size(100, 20);
            this.txtLoanRate.TabIndex = 13;
            // 
            // txtAwesomeness
            // 
            this.txtAwesomeness.Location = new System.Drawing.Point(156, 156);
            this.txtAwesomeness.Name = "txtAwesomeness";
            this.txtAwesomeness.Size = new System.Drawing.Size(100, 20);
            this.txtAwesomeness.TabIndex = 14;
            // 
            // txtKiwiSaverOwn
            // 
            this.txtKiwiSaverOwn.Location = new System.Drawing.Point(156, 182);
            this.txtKiwiSaverOwn.Name = "txtKiwiSaverOwn";
            this.txtKiwiSaverOwn.Size = new System.Drawing.Size(100, 20);
            this.txtKiwiSaverOwn.TabIndex = 15;
            // 
            // txtPoliteness
            // 
            this.txtPoliteness.Location = new System.Drawing.Point(156, 245);
            this.txtPoliteness.Name = "txtPoliteness";
            this.txtPoliteness.Size = new System.Drawing.Size(100, 20);
            this.txtPoliteness.TabIndex = 16;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(295, 82);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(61, 13);
            this.lblResult.TabIndex = 18;
            this.lblResult.Text = "$________";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(298, 44);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 17;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 277);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtPoliteness);
            this.Controls.Add(this.txtKiwiSaverOwn);
            this.Controls.Add(this.txtAwesomeness);
            this.Controls.Add(this.txtLoanRate);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.chkKiwiSaverBoss);
            this.Controls.Add(this.chkPoliteness);
            this.Controls.Add(this.chkKiwiSaverOwn);
            this.Controls.Add(this.chkAwesomeness);
            this.Controls.Add(this.chkLoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSalary";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkLoan;
        private System.Windows.Forms.CheckBox chkAwesomeness;
        private System.Windows.Forms.CheckBox chkKiwiSaverOwn;
        private System.Windows.Forms.CheckBox chkKiwiSaverBoss;
        private System.Windows.Forms.CheckBox chkPoliteness;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.TextBox txtLoanRate;
        private System.Windows.Forms.TextBox txtAwesomeness;
        private System.Windows.Forms.TextBox txtKiwiSaverOwn;
        private System.Windows.Forms.TextBox txtPoliteness;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalc;
    }
}