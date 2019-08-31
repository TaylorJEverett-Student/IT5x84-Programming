using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGrade
{
    public partial class frmMarkCalc : Form
    {
        public frmMarkCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Form1_FormClosing (object sender, FormClosingEventArgs e)
        {
            ShowGoodbye();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            DoTheCalc();
        }

        private void DoTheCalc()
        {
            int i_Mark;
            string s_Grade;

            i_Mark = Convert.ToInt32(txtMark.Text);

            s_Grade = ShowMeTheGrade(i_Mark);

            lblGrade.Text = s_Grade;
        }
        private void ShowGoodbye ()
        {
            MessageBox.Show("Goodbye!");
        }

        private void ShowCustomGoodbye (string s_GoodbyeText)
        {
            MessageBox.Show(s_GoodbyeText);
        }

        private string ShowMeTheGrade (int i_Mark)
        {
            string s_Grade = "Genious!";

            if (i_Mark <= 100) { s_Grade = "A+"; };
            if (i_Mark < 80) { s_Grade = "A"; };
            if (i_Mark < 70) { s_Grade = "B"; };
            if (i_Mark < 60) { s_Grade = "C"; };
            if (i_Mark < 50) { s_Grade = "F"; };
            if (i_Mark < 0) { s_Grade = "Invalid"; };

            return s_Grade;
        }

        private void txtMark_TextChanged(object sender, EventArgs e)
        {
            DoTheCalc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoTheCalc();
        }
    }
}
