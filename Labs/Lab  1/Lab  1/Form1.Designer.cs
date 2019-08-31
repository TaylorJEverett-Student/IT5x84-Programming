namespace Lab__1
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
            this.lblEnterMark = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterMark
            // 
            this.lblEnterMark.AutoSize = true;
            this.lblEnterMark.Location = new System.Drawing.Point(13, 33);
            this.lblEnterMark.Name = "lblEnterMark";
            this.lblEnterMark.Size = new System.Drawing.Size(59, 13);
            this.lblEnterMark.TabIndex = 0;
            this.lblEnterMark.Text = "Enter Mark";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(94, 30);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 20);
            this.txtMark.TabIndex = 1;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(30, 98);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(42, 13);
            this.lblGrade.TabIndex = 2;
            this.lblGrade.Text = "Grade :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(94, 97);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "_______";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(182, 98);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.lblEnterMark);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterMark;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnCal;
    }
}

