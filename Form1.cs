using System;
using System.Drawing;
using System.Windows.Forms;
namespace Pong__._
{
    public partial class Form1 : Form
    {
        // global class variables
        // the this keyword with refer to these:
        public string direction;
        public int speed = 5;
        public bool cont = true;
        public string angleDirection = "none";
        public int paddleAngle = 0;
        //initial; sets up windows form
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        //start button click (resets and starts game)
        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            this.direction = "right";
            this.cont = true;
            this.angleDirection = "none";
            this.paddleAngle = 0;
            ball.Location = new Point(400, 248);
            rightPaddle.Location = new Point(714, 215);
            leftPaddle.Location = new Point(70, 215);
            timer.Enabled = true;
        }
        //function to end / reset game
        private void endGame()
        {
            this.cont = false;
            startButton.Visible = true;
        }
        //function to move the ball
        private void moveBall(int currentDirection)
        {
            //check if it hits bounds
            if (ball.Location.Y <= 81)
            {
                this.angleDirection = "down";
            }
            else if (ball.Location.Y >= 412)
            {
                this.angleDirection = "up";
            }
            if (this.angleDirection.Equals("up"))
            {
                ball.Location = new Point(ball.Location.X + currentDirection * this.speed, ball.Location.Y + this.paddleAngle);
            }
            else if (this.angleDirection.Equals("down"))
            {
                ball.Location = new Point(ball.Location.X + currentDirection * this.speed, ball.Location.Y - this.paddleAngle);
            }
            else
            {
                ball.Location = new Point(ball.Location.X + currentDirection * this.speed, ball.Location.Y);
            }
        }
        //function to change direction of ball when it hits a paddle
        private void changeDirection(string direction, int paddleLocationY)
        {
            this.direction = direction;
            ballAngleResult(ball.Location.Y, paddleLocationY);
        }
        //timer that leads the gameplay (per 10ms "tick" events)
        private void timer_Tick(object sender, EventArgs e)
        {
            if(this.cont == false)
            {
                timer.Enabled = false;
            }
            //moves ball right
            if (this.direction.Equals("right"))
            {
                if (ball.Location.X <= (rightPaddle.Location.X - 14))
                {
                    moveBall(1);
                }
                else if ((ball.Location.Y >= rightPaddle.Location.Y - 15) && (ball.Location.Y <= rightPaddle.Location.Y + 90))
                {
                    changeDirection("left", rightPaddle.Location.Y);
                }
                else
                {
                    endGame();
                }
            }
            //moves ball left
            else if (this.direction.Equals("left"))
            {
                if (ball.Location.X >= (leftPaddle.Location.X + 12))
                {
                    moveBall(-1);
                }
                else if ((ball.Location.Y >= leftPaddle.Location.Y - 15) && (ball.Location.Y <= leftPaddle.Location.Y + 90))
                {
                    changeDirection("right", leftPaddle.Location.Y);
                }
                else
                {
                    endGame();
                }
            }
            //left paddle (computer) moves to ball
            ///// EASY MODE ///// 
            /// (moves up when the ball moves up, and down when the ball moves down)
            /*if (this.angleDirection.Equals("up"))
            {
                if (leftPaddle.Location.Y > 84 + this.speed)
                {
                    leftPaddle.Location = new Point(leftPaddle.Location.X, leftPaddle.Location.Y - (this.speed - 2));
                }
            }
            else if (this.angleDirection.Equals("down"))
            {
                if (leftPaddle.Location.Y < 350 - this.speed)
                {
                    leftPaddle.Location = new Point(leftPaddle.Location.X, leftPaddle.Location.Y + (this.speed - 2));
                }
            }*/
            ///// MEDIUM MODE ///// 
            /// (moves its center to a random distance from the ball)
            /*Random random = new Random();
            int randomDistance = random.Next(-40, 40);
            if ((ball.Location.Y + 7) < (leftPaddle.Location.Y + 40 + randomDistance))
            {
                if (leftPaddle.Location.Y > 84 + this.speed)
                {
                    leftPaddle.Location = new Point(leftPaddle.Location.X, leftPaddle.Location.Y - (this.speed - 2));
                }
            }
            else if ((ball.Location.Y + 7) > (leftPaddle.Location.Y + 40 + randomDistance))
            {
                if (leftPaddle.Location.Y < 350 - this.speed)
                {
                    leftPaddle.Location = new Point(leftPaddle.Location.X, leftPaddle.Location.Y + (this.speed - 2));
                }
            }*/
            ///// HARD MODE /////
            /// (moves it's corner toward the ball)
            /*if ((ball.Location.Y + 7) < (leftPaddle.Location.Y + 15))
            {
                if (leftPaddle.Location.Y > 84 + this.speed)
                {
                    leftPaddle.Location = new Point(leftPaddle.Location.X, leftPaddle.Location.Y - (this.speed - 2));
                }
            }
            else if ((ball.Location.Y + 7) > (leftPaddle.Location.Y + 65))
            {
                if (leftPaddle.Location.Y < 350 - this.speed)
                {
                    leftPaddle.Location = new Point(leftPaddle.Location.X, leftPaddle.Location.Y + (this.speed - 2));
                }
            }*/
            ///// ENDLESS MODE /////
            /// (moves it's corner toward the ball (same as HARD) but slightly faster so that it can reach the ball 100% of the time)
            if ((ball.Location.Y + 7) < (leftPaddle.Location.Y + 15))
            {
                if (leftPaddle.Location.Y > 84 + this.speed)
                {
                    leftPaddle.Location = new Point(leftPaddle.Location.X, leftPaddle.Location.Y - (this.speed));
                }
            }
            else if ((ball.Location.Y + 7) > (leftPaddle.Location.Y + 65))
            {
                if (leftPaddle.Location.Y < 350 - this.speed)
                {
                    leftPaddle.Location = new Point(leftPaddle.Location.X, leftPaddle.Location.Y + (this.speed));
                }
            }
        }
        //function to help with arrow key presses
        private void keyData(KeyEventArgs e, bool enabled)
        {
            if (e.KeyData == Keys.Up)
            {
                paddleTimerUp.Enabled = enabled;
            }
            if (e.KeyData == Keys.Down)
            {
                paddleTimerDown.Enabled = enabled;
            }
        }
        //determines if player presses arrow key / which one and moves paddle up or down accordingly
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keyData(e, true);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            keyData(e, false);
        }
        //moves paddle up
        private void paddleTimerUp_Tick(object sender, EventArgs e)
        {
            if(this.cont == true)
            {
                if (rightPaddle.Location.Y > 84 + this.speed)
                {
                    rightPaddle.Location = new Point(rightPaddle.Location.X, rightPaddle.Location.Y - (this.speed - 2));
                }
            }
        }
        //moves paddle down
        private void paddleTimerDown_Tick(object sender, EventArgs e)
        {
            if(this.cont == true)
            {
                if (rightPaddle.Location.Y < 350 - this.speed)
                {
                    rightPaddle.Location = new Point(rightPaddle.Location.X, rightPaddle.Location.Y + (this.speed - 2));
                }
            }
        }
        //determines "angle" (y component) of ball when hit
        private void ballAngleResult(int ballY, int paddleY)
        {
            int relativeY = (ballY + 7) - paddleY;

            if (relativeY < 40)
            {
                this.angleDirection = "up";
                relativeY = (relativeY - 40) / 9;
            }
            else if (relativeY > 40)
            {
                this.angleDirection = "down";
                relativeY = (40 - relativeY) / 9;
            }
            else
            {
                this.angleDirection = "none";
                relativeY = 0;
            }
            if(!(this.angleDirection.Equals("none")))
            {
                if (relativeY < -5 || relativeY > 5)
                {
                    relativeY = -5;
                }
                if (relativeY == 0)
                {
                    relativeY = -1;
                }
            }
            this.paddleAngle = relativeY;
        }
    }
}