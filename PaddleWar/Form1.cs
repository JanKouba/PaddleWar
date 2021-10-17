using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaddleWar
{
    public partial class frmMain : Form
    {
        Timer tmrBallMove;
        Timer tmrLeft;
        Timer tmrRight;
        double bounce = 0;
        double bounceTotal = 0;
        double balls = 0;
        double score = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private int step = 5;
        private int angle = 0;
        public enum Way { Up = 1, Down = 2, Left = 3, Right = 4};
        Way currentWay;
       
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            lblGameOver.Visible = false;
            lblStart.Visible = false;
            picGameOver.Visible = false;

            bounce = 0;

            picBall.Location = new Point(pnlMain.Size.Width / 2, pnlMain.Size.Height / 2);

            currentWay = 0;
            tmrBallMove = new Timer();
            tmrBallMove.Interval = 1;
            tmrBallMove.Tick += tmrBallMove_Tick;
            tmrBallMove.Start();

            tmrLeft = new Timer();
            tmrLeft.Interval = 50;
            tmrLeft.Tick += tmrLeft_Tick;

            tmrRight = new Timer();
            tmrRight.Interval = 50;
            tmrRight.Tick += tmrRight_Tick;

            textBox1.Focus();
        }

        void tmrRight_Tick(object sender, EventArgs e)
        {
            if (tmrRight.Interval > 20)
                tmrRight.Interval -= 10;
            MoveRight();
        }

        void tmrLeft_Tick(object sender, EventArgs e)
        {
            if (tmrLeft.Interval > 20)
                tmrLeft.Interval -= 10;
            MoveLeft();
        }

        void tmrBallMove_Tick(object sender, EventArgs e)
        {
            int ballDown = picBall.Location.Y + picBall.Size.Height;
            int ballUp = picBall.Location.Y;
            int ballLeft = picBall.Location.X;
            int ballRight = picBall.Location.X + picBall.Size.Width;

            int edgeRight = pnlMain.Size.Width;
            int edgeLeft = 0;
            int edgeUp = 0;
            int edgeDown =  pnlMain.Size.Height;

            int paddleLeft = picPaddle.Location.X;
            int paddleRight = picPaddle.Location.X + picPaddle.Size.Width;
            int paddleUp = picPaddle.Location.Y;

            if (currentWay == 0)
                currentWay = Way.Down;

            if (currentWay == Way.Down)
            {
                if (ballLeft <= edgeLeft)
                    angle = -angle;

                if (ballRight >= edgeRight)
                    angle = -angle;

                if (ballDown < paddleUp)
                {
                    picBall.Location = new Point(picBall.Location.X + angle, picBall.Location.Y + 5);
                    currentWay = Way.Down;
                }
                else
                    if (ballRight >= paddleLeft && ballLeft <= paddleRight) //odraz od pádla
                    {
                        Random rnd = new Random();
                        currentWay = Way.Up;
                        angle = 1 + rnd.Next(5);
                        bounce++;
                        bounceTotal++;
                        lblBounce.Text = "Bounce: " + bounce.ToString();
                        
                    }
                    else
                    {
                        picBall.Location = new Point(picBall.Location.X + angle, picBall.Location.Y + 5);
                        currentWay = Way.Down;
                    }

                if (ballUp >= edgeDown)
                {
                    tmrBallMove.Stop();
                    //lblGameOver.Visible = true;
                    lblStart.Visible = true;
                    picGameOver.Visible = true;
                    balls++;
                    lblBall.Text = "Lost Balls: " + balls.ToString();
                }
            }

            if (currentWay == Way.Up)
            {
                if (ballLeft <= edgeLeft)
                    angle = -angle;

                if (ballRight >= edgeRight)
                    angle = -angle;

                if (ballUp > edgeUp)
                {
                    picBall.Location = new Point(picBall.Location.X - angle, picBall.Location.Y - 5);
                    currentWay = Way.Up;
                }
                else
                {
                    Random rnd = new Random();
                    currentWay = Way.Down;
                    angle = -(angle) + (5- rnd.Next(5));
                }
            }

            if (balls > 0)
                score = Math.Round(bounceTotal / balls,1);
            else
                score = bounce;
            lblScore.Text = "Score: " + score;

        }

        private void MoveLeft()
        {
            if (picPaddle.Location.X >= 0) 
            picPaddle.Location = new Point(picPaddle.Location.X - (step+5), picPaddle.Location.Y);
        }

        private void MoveRight()
        {
            if (picPaddle.Location.X + picPaddle.Size.Width  <= pnlMain.Size.Width) 
            picPaddle.Location = new Point(picPaddle.Location.X + (step +5), picPaddle.Location.Y);
        }
       
      
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                tmrLeft.Enabled = true;

            else if (e.KeyCode == Keys.Right)
                tmrRight.Enabled = true;
            else if (e.KeyCode == Keys.Space)
                if (picGameOver.Visible)
                    StartGame();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            tmrLeft.Enabled = false;
            tmrRight.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnStart.Focus();
            lblStart.Visible = true;
           
        }

      

        private void pnlMain_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
