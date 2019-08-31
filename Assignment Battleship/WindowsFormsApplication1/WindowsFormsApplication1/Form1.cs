using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int hit = 0;
        int miss = 0;
        int rships = 10;
        public Form1()
        {
            InitializeComponent();
        }
        static int i_row = 10;
        static int i_col = 10;

        Button[,] a_buttons = new Button[i_row, i_col];

        private void m_MakeButtons()
        {
            Random r = new Random();
            int x = r.Next(0, 9);
            int y = r.Next(0, 9);
            int ranship = r.Next(1, 5);


            for (int i_Rowindex = 0; i_Rowindex < i_row; i_Rowindex++)
            {
                for (int i_Colindex = 0; i_Colindex < i_col; i_Colindex++)
                {
                    a_buttons[i_Rowindex, i_Colindex] = new System.Windows.Forms.Button();

                    a_buttons[i_Rowindex, i_Colindex].Location = new System.Drawing.Point(40 + 45 * i_Rowindex, 40 + 45 * i_Colindex);
                    a_buttons[i_Rowindex, i_Colindex].Size = new System.Drawing.Size(45, 45);
                    a_buttons[i_Rowindex, i_Colindex].UseVisualStyleBackColor = true;

                    a_buttons[i_Rowindex, i_Colindex].BackColor = Color.Aqua;
                    this.Controls.Add(a_buttons[i_Rowindex, i_Colindex]);

                    if ((i_Rowindex >= x && i_Rowindex <= x+ranship) && i_Colindex == y)
                    {
                        a_buttons[i_Rowindex, i_Colindex].BackColor = Color.Wheat;
                        this.Controls.Add(a_buttons[i_Rowindex, i_Colindex]);
                        a_buttons[i_Rowindex, i_Colindex].Click += new System.EventHandler(m_WhenHit);
                    }
                    else {
                        //a_buttons[i_Rowindex, i_Colindex].BackColor = Color.Aqua;
                        //this.Controls.Add(a_buttons[i_Rowindex, i_Colindex]);
                        a_buttons[i_Rowindex, i_Colindex].Click += new System.EventHandler(m_WhenMiss);
                    }
                }
            }
        }
        //private void m_MakeShips()
        //{
        //    Random r = new Random();

        //    int x = r.Next(0, 9);
        //    int y = r.Next(0, 9);

        //    int ranship = r.Next(1, 5);

        //    for (int i = 0; i < ranship; i++)
        //    {
        //        a_buttons[x + i, y] = new System.Windows.Forms.Button();

        //        a_buttons[x + i, y].Location = new System.Drawing.Point(40 + 45 * (x+i), 40 + 45 * y);
        //        a_buttons[x + i, y].Size = new System.Drawing.Size(45, 45);
        //        a_buttons[x + i, y].UseVisualStyleBackColor = true;
        //        a_buttons[x + i, y].BackColor = Color.Wheat;
        //        this.Controls.Add(a_buttons[x + i, y]);

        //        a_buttons[x, y].Click += new System.EventHandler(m_WhenHit);
        //    }
        //}

        private void m_WhenHit(object sender, EventArgs e)
        {
            Button ClickedButton = sender as Button;

            ClickedButton.BackColor = Color.Red;
            MessageBox.Show("Hit");
            hit++;
            lblhit.Text = hit.ToString();
            
            rships--;
            lblrships.Text = rships.ToString();
            MessageBox.Show("Ship Sunk");
            
        }

        private void m_WhenMiss(object sender, EventArgs e)
        {
            Button ClickedButton = sender as Button;

            ClickedButton.BackColor = Color.White;
            Control control = (Control)sender;
            MessageBox.Show("Miss");
            miss++;
            lblmiss.Text = miss.ToString();

            //if (ClickedButton == a_buttons[rndship])
            //if (ClickedButton == a_buttons[0, 1] || ClickedButton == a_buttons[0, 2])
            //{
            //     ClickedButton.BackColor = Color.Red;
            //     MessageBox.Show("Hit");
            //     hit++;
            //     lblhit.Text = hit.ToString();
            //    if (a_buttons[0, 1].BackColor == Color.Red && a_buttons[0, 2].BackColor == Color.Red)
            //    {
            //        rships--;
            //        lblrships.Text = rships.ToString();
            //        MessageBox.Show("Ship Sunk");
            //    }
            //}
            //else
            //{
            //    ClickedButton.BackColor = Color.White;
            //    Control control = (Control)sender;
            //    MessageBox.Show("Miss");
            //    miss++;
            //    lblmiss.Text = miss.ToString();
            //}
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            m_MakeButtons();
            //m_MakeShips();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Process.GetCurrentProcess().Kill();
            //a_buttons[x, y].BackColor = Color.White;
            //lblhit.Text = ("0");
            //lblmiss.Text = ("0");
            //lblrships.Text = ("10");
            //Form frmHide = new frmHidden();
            ////frmHide.Show();
            //////this.Close();
            //this.Close();
            //frmHide.Show();
        }
    }
}
