using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//IT5x84-2017-S1 - Assignment 2
//Name :  Taylor Everett
//StuID : 21600252
//Date :  27/05/2017

namespace Assignment2
{
    public partial class frmSnakeGame : Form
    {
        Graphics g;
        List<Point> snake = new List<Point>();
        Point apples = new Point();
        string direction;
        Point currentHead;
        Point snakeEnd;
        Random rdm = new Random();
        int score = 0;
        int points = 100;
        string input = "Your Name";

        public frmSnakeGame()//sets the starting direction
        {
            InitializeComponent();
            direction = "Up";
        }

        private void frmSnakeGame_Load(object sender, EventArgs e)
        {


        }

        private void btnStart_Click(object sender, EventArgs e)//on click resets the game, starts the timer, make the first apple, and disables button so ProcessKeyCmd can work
        {
            clear();
            snakehead();
            GameTimer.Start();
            GameTimer.Enabled = true;
            btnStart.Enabled = false;
            genApple();

        }

        private void btnScore_Click(object sender, EventArgs e)//on click shows all scores saved to the Player.score document found next to the .exe
        {
            string s_RPScore;
            s_RPScore = System.IO.File.ReadAllText("Player.score");
            MessageBox.Show(s_RPScore);

        }

        public void btnEnter_Click(object sender, EventArgs e)//on click this saves player score to Player.score document found next to the .exe
        {

            string path = "Player.score";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(input + ":" + score);
            }
        }




        public void clear() //Resets games picture box ,starting direction, veiwed score, and int score
        {
            g = pictureBox1.CreateGraphics();
            g.FillRectangle(Brushes.White, 0, 0, 400, 400);
            direction = "Up";
            lblPoint.Text = "------";
            score = 0;
        }

        private void snakehead() //snake start point
        {
            snake = new List<Point>();
            snake.Add(new Point(200, 200));
        }


        private void Movement()//Makes the snake look like it's moving by generating a new head infront of the direction while making the a white block over the first head.
        {

            currentHead = snake[snake.Count - 1];

            switch (direction)
            {
                case "Up":
                    {
                        
                        snake.Add(new Point(currentHead.X, currentHead.Y - 10));
                        g.FillRectangle(Brushes.Black, currentHead.X, currentHead.Y - 10, 10, 10);
                        break;
                    }
                case "Down":
                    {
                        
                        snake.Add(new Point(currentHead.X, currentHead.Y + 10));
                        g.FillRectangle(Brushes.Black, currentHead.X, currentHead.Y + 10, 10, 10);
                        break;
                    }
                case "Left":
                    {
                        
                        snake.Add(new Point(currentHead.X - 10, currentHead.Y));
                        g.FillRectangle(Brushes.Black, currentHead.X - 10, currentHead.Y, 10, 10);
                        break;
                    }
                case "Right":
                    {
                        
                        snake.Add(new Point(currentHead.X + 10, currentHead.Y));
                        g.FillRectangle(Brushes.Black, currentHead.X + 10, currentHead.Y, 10, 10);
                        break;
                    }
            }

            snakeEnd = snake[0];
            snake.RemoveAt(0);
            g.FillRectangle(Brushes.White, snakeEnd.X, snakeEnd.Y, 10, 10);

        }
        public Boolean ProcessKeyCmd(Keys keyData)// allows Keys to be used and set direction while not allowing the snake to move back on it's self
        {
            switch (keyData)
            {
                case Keys.Up:
                    {
                        if (direction != "Up" && direction != "Down")
                        {
                            direction = "Up";
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if (direction != "Down" && direction != "Up")
                        {
                            direction = "Down";
                        }
                        break;
                    }
                case Keys.Left:
                    {
                        if (direction != "Left" && direction != "Right")
                        {
                            direction = "Left";
                        }
                        break;
                    }
                case Keys.Right:
                    {
                        if (direction != "Right" && direction != "Left")
                        {
                            direction = "Right";
                        }
                        break;
                    }
            }
            return true;

        }

        private Boolean checkCollision()//Collision checking for game borders true meaning it's hit the edge and false to let the game continue
        {
            Point currentHead = snake[snake.Count - 1];
            if (currentHead.X == 0)
            {
                return true;
            }
            if (currentHead.X == 400)
            {
                return true;
            }
            if (currentHead.Y == 0)
            {
                return true;
            }
            if (currentHead.Y == 400)
            {
                return true;
            }
            return false;
        }



        private Boolean snakeHitBody()//check to make sure the it's touching it's own body 
        {
            if (snake.Count > 1)
            {
                for (int j = 1; j < snake.Count; j++)
                {
                    if (snake[j].X == snake[0].X && snake[j].Y == snake[0].Y)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private void genApple()//Makes an apple 10x10 in a random Location within the 400x400 picture box 
        {

            int x = rdm.Next(1, 40) * 10;
            int y = rdm.Next(1, 40) * 10;

            apples.X = x;
            apples.Y = y;
            g.FillRectangle(Brushes.Red, x, y, 10, 10);//makes apple red

            if (snakeEnd.X == apples.X && snakeEnd.Y == apples.Y)// if generates on snake body generates again
            {
                genApple();
            }

        }


        private void growSnake()// tells the apple to generate when hit by the head and to increase the size of the snakes array
        {
            if (currentHead.X == apples.X && currentHead.Y == apples.Y)
            {
                genApple();
                List<Point> temp = new List<Point>();
                temp.Add(snakeEnd);
                temp.AddRange(snake.ToArray());
                snake = temp;

                score += points;
                lblPoint.Text = score.ToString();
            }

        }


        private void GameTimer_Tick(object sender, EventArgs e)//stops the game for hitting the sides or snake's self and enables the start button while giving it a new name. Opens input messagebox
        {
            
            Movement();
            if (checkCollision())
            {
                GameTimer.Stop();
                ShowInputDialog(ref input);
                btnStart.Enabled = true;
                btnStart.Text = "Restart";
            }

            if (snakeHitBody())
            {
                GameTimer.Stop();
                ShowInputDialog(ref input);
                btnStart.Enabled = true;
                btnStart.Text = "Restart";

            }

            growSnake();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//needed to enable Keys to work.
        {
            ProcessKeyCmd(e.KeyCode);
        }

        //made a Input message box, found most of this code on stack over flow on this page"https://stackoverflow.com/questions/97097/what-is-the-c-sharp-version-of-vb-nets-inputdialog"
        //was going to make a way to get input for user name in a messagebox but i failed
        //makes a new form with a label, textbox, and 3 buttons.
        public DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(250, 120);
            Form msgInput = new Form();

            msgInput.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            msgInput.ClientSize = size;
            msgInput.Text = "Game Over";


            System.Windows.Forms.Label lblGameOver = new Label();
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new System.Drawing.Size(28, 13);
            lblGameOver.Text = "Your score is: " + score;
            lblGameOver.Location = new System.Drawing.Point(5, 5);
            lblGameOver.AutoSize = true;

            System.Windows.Forms.TextBox txtInputName = new TextBox();
            txtInputName.Size = new System.Drawing.Size(size.Width - 10, 23);
            txtInputName.Location = new System.Drawing.Point(5, 30);
            txtInputName.Name = "txtInputName";
            txtInputName.Text = input;//can't figure out where this data is getting lost. This took my entire saturday and I have nothing to show for it. 
            msgInput.Controls.Add(txtInputName);

            Button btnScore = new Button();
            btnScore.Name = "btnScore";
            btnScore.Size = new System.Drawing.Size(75, 23);
            btnScore.Text = "&Scores";
            btnScore.Location = new System.Drawing.Point(size.Width - 160 - 80, 60);
            msgInput.Controls.Add(btnScore);
            btnScore.Click += new System.EventHandler(this.btnScore_Click);

            Button btnEnter = new Button();
            btnEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new System.Drawing.Size(75, 23);
            btnEnter.Text = "&Enter";
            btnEnter.Location = new System.Drawing.Point(size.Width - 80 - 80, 60);
            msgInput.Controls.Add(btnEnter);
            btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

            Button btnCancel = new Button();
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.Text = "&Cancel";
            btnCancel.Location = new System.Drawing.Point(size.Width - 80, 60);
            msgInput.Controls.Add(btnCancel);

            msgInput.Controls.AddRange(new Control[] { lblGameOver, txtInputName, btnScore, btnEnter, btnCancel });
            msgInput.ClientSize = new Size(Math.Max(250, lblGameOver.Right + 10), msgInput.ClientSize.Height);
            msgInput.AcceptButton = btnEnter;
            msgInput.CancelButton = btnCancel;
            msgInput.StartPosition = FormStartPosition.CenterParent;

            DialogResult result = msgInput.ShowDialog();
            input = txtInputName.Text;
            return result;
        }
    }
}
