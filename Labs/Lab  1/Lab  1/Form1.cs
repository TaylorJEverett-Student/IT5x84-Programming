using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            DoTheCalc();
        }
        private void DoTheCalc()
        {
            int i_Mark;
            string s_Grade;
            i_Mark = Convert.ToInt32(txtMark.Text);

            if (i_Mark > 100) { s_Grade = "Genious!"; }
            else if (i_Mark >= 80 && i_Mark <= 100) { s_Grade = "A+"; }
            else if (i_Mark >= 70 && i_Mark <= 80) { s_Grade = "A"; }
            else if (i_Mark >= 60 && i_Mark <= 70) { s_Grade = "B"; }
            else if (i_Mark >= 50 && i_Mark <= 60) { s_Grade = "C"; }
            else if (i_Mark >= 0 && i_Mark <= 50) { s_Grade = "D"; }
            else { s_Grade = "Invaild"; };
            lblScore.Text = s_Grade;
        }
    }
}
