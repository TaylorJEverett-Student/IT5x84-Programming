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
        int rships = 3;
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
            int ranship1 = r.Next(3, 3);
            int ranship2 = r.Next(2, 2);
            int ranship3 = r.Next(4, 4);


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

                    if ((i_Rowindex >= x && i_Rowindex <= x + ranship1) && i_Colindex == y)//over laps with other boats
                    {
                        a_buttons[i_Rowindex, i_Colindex].BackColor = Color.Wheat;
                        this.Controls.Add(a_buttons[i_Rowindex, i_Colindex]);
                        a_buttons[i_Rowindex, i_Colindex].Click += new System.EventHandler(m_WhenHit);
                    }
                    else if ((i_Colindex > x && i_Colindex < x + ranship2) && i_Rowindex == y)
                    {
                        a_buttons[i_Rowindex, i_Colindex].BackColor = Color.Wheat;
                        this.Controls.Add(a_buttons[i_Rowindex, i_Colindex]);
                        a_buttons[i_Rowindex, i_Colindex].Click += new System.EventHandler(m_WhenHit);
                    }
                    else if ((i_Colindex > x && i_Colindex < x + ranship3) && i_Rowindex == x)
                    {
                        a_buttons[i_Rowindex, i_Colindex].BackColor = Color.Wheat;
                        this.Controls.Add(a_buttons[i_Rowindex, i_Colindex]);
                        a_buttons[i_Rowindex, i_Colindex].Click += new System.EventHandler(m_WhenHit);
                    }
                    else
                    {
                        a_buttons[i_Rowindex, i_Colindex].Click += new System.EventHandler(m_WhenMiss);// conflicts with hit on second boat
                    }
                }
            }
        }


        private void m_WhenHit(object sender, EventArgs e)
        {
            Button ClickedButton = sender as Button;

            ClickedButton.BackColor = Color.Red;
            MessageBox.Show("Hit");
            hit++;
            lblhit.Text = hit.ToString();
            (sender as Button).Enabled = false;
            //if (a_buttons[i_Rowindex, i_Colindex].BackColor == Color.Red)          // put with each boat gen /\ and does nothing moved here to get out of way 
            //{
            //    rships--;                                                          // Remaining Ship counter
            //    lblrships.Text = rships.ToString();
            //    MessageBox.Show("Ship Sunk");
            //}
        }

        private void m_WhenMiss(object sender, EventArgs e)
        {
            Button ClickedButton = sender as Button;
            
            ClickedButton.BackColor = Color.White;
            Control control = (Control)sender;
            MessageBox.Show("Miss");
            miss++;
            lblmiss.Text = miss.ToString();
            (sender as Button).Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            m_MakeButtons();
        }

        

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Process.GetCurrentProcess().Kill();
        }
    }
}
