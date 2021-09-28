using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong__._
{
    public partial class Form1 : Form
    {
        // global variables
        public string direction;
        public int speed = 5;
        public bool cont = true;
        public string angleDirection = "none";
        public int paddleAngle = 0;


        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        private void ball_Click(object sender, EventArgs e)
        {
            
        }

        //ON START BUTTON
        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            direction = "right";
            cont = true;
            angleDirection = "none";
            paddleAngle = 0;
            ball.Location = new Point(400, 248);
            rightPaddle.Location = new Point(714, 215);
            leftPaddle.Location = new Point(70, 215);
            timer.Enabled = true;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if(cont == false)
            {
                timer.Enabled = false;
            }

            if (direction.Equals("right"))
            {
                if (ball.Location.X <= (rightPaddle.Location.X - 14))
                {
                    //check if it hits bounds
                    if (ball.Location.Y <= 81)
                    {
                        angleDirection = "down";
                    }
                    if (ball.Location.Y >= 412)
                    {
                        angleDirection = "up";
                    }


                    if (angleDirection.Equals("up"))
                    {
                        ball.Location = new Point(ball.Location.X + speed, ball.Location.Y + paddleAngle);
                    }
                    else if(angleDirection.Equals("down"))
                    {
                        ball.Location = new Point(ball.Location.X + speed, ball.Location.Y - paddleAngle);
                    }
                    else
                    {
                        ball.Location = new Point(ball.Location.X + speed, ball.Location.Y);
                    }
                    //ball.Location = new Point(ball.Location.X + speed, ball.Location.Y);
                }

                else if ((ball.Location.Y >= rightPaddle.Location.Y - 15) && (ball.Location.Y <= rightPaddle.Location.Y + 90))
                {
                    direction = "left";
                    ballAngleResult(ball.Location.Y, rightPaddle.Location.Y);
                }
                else
                {
                    cont = false;
                    startButton.Visible = true;
                }
            }

            else if (direction.Equals("left"))
            {
                if (ball.Location.X >= (leftPaddle.Location.X + 12))
                {
                    //check if it hits bounds
                    if(ball.Location.Y <= 81)
                    {
                        angleDirection = "down";
                    }
                    if(ball.Location.Y >= 412)
                    {
                        angleDirection = "up";
                    }


                    if (angleDirection.Equals("up"))
                    {
                        ball.Location = new Point(ball.Location.X - speed, ball.Location.Y + paddleAngle);
                    }
                    else if (angleDirection.Equals("down"))
                    {
                        ball.Location = new Point(ball.Location.X - speed, ball.Location.Y - paddleAngle);
                    }
                    else
                    {
                        ball.Location = new Point(ball.Location.X - speed, ball.Location.Y);
                    }
                    //ball.Location = new Point(ball.Location.X - speed, ball.Location.Y);
                }

                else if ((ball.Location.Y >= leftPaddle.Location.Y - 15) && (ball.Location.Y <= leftPaddle.Location.Y + 90))
                {
                    direction = "right";
                    ballAngleResult(ball.Location.Y, leftPaddle.Location.Y);
                }
                else
                {
                    cont = false;
                    startButton.Visible = true;
                }
            }

            //left paddle moves to ball
            if (angleDirection.Equals("up"))
            {
                if (leftPaddle.Location.Y > 84 + speed)
                {
                    leftPaddle.Location = new Point(leftPaddle.Location.X, leftPaddle.Location.Y - (speed - 2));
                }
            }
            else if (angleDirection.Equals("down"))
            {
                if (leftPaddle.Location.Y < 350 - speed)
                {
                    leftPaddle.Location = new Point(leftPaddle.Location.X, leftPaddle.Location.Y + (speed - 2));
                }
            }
        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                paddleTimerUp.Enabled = true;
            }
            if (e.KeyData == Keys.Down)
            {
                paddleTimerDown.Enabled = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                paddleTimerUp.Enabled = false;
            }
            if (e.KeyData == Keys.Down)
            {
                paddleTimerDown.Enabled = false;
            }
        }

        private void paddleTimerUp_Tick(object sender, EventArgs e)
        {
            if(cont == true)
            {
                if (rightPaddle.Location.Y > 84 + speed)
                {
                    rightPaddle.Location = new Point(rightPaddle.Location.X, rightPaddle.Location.Y - (speed - 2));
                }
            }
            
        }

        private void paddleTimerDown_Tick(object sender, EventArgs e)
        {
            if(cont == true)
            {
                if (rightPaddle.Location.Y < 350 - speed)
                {
                    rightPaddle.Location = new Point(rightPaddle.Location.X, rightPaddle.Location.Y + (speed - 2));
                }
            }
        }

        
        //determines angle of ball when hit
        private void ballAngleResult(int ballY, int paddleY)
        {
            int relativeY = -1 * (paddleY - (ballY + 7));

            if (relativeY < 39)
            {
                angleDirection = "up";
                relativeY = (relativeY - 40) / 3;
                if(relativeY < -3)
                {
                    relativeY = -3;
                }
                if (relativeY > 3)
                {
                    relativeY = -3;
                }
            }
            else if (relativeY > 41)
            {
                angleDirection = "down";
                relativeY = (80 - (40 + relativeY)) / 3;
                if (relativeY < -3)
                {
                    relativeY = -3;
                }
                if (relativeY > 3)
                {
                    relativeY = -3;
                }
            }
            else
            {
                angleDirection = "none";
                relativeY = 0;
            }

            paddleAngle = relativeY;
        }
    }
}
