
namespace Pong__._
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rightPaddle = new System.Windows.Forms.PictureBox();
            this.leftPaddle = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paddleTimerUp = new System.Windows.Forms.Timer(this.components);
            this.paddleTimerDown = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rightPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rightPaddle
            // 
            this.rightPaddle.AccessibleName = "rightPaddle";
            this.rightPaddle.Image = ((System.Drawing.Image)(resources.GetObject("rightPaddle.Image")));
            this.rightPaddle.Location = new System.Drawing.Point(714, 215);
            this.rightPaddle.Name = "rightPaddle";
            this.rightPaddle.Size = new System.Drawing.Size(13, 80);
            this.rightPaddle.TabIndex = 0;
            this.rightPaddle.TabStop = false;
            // 
            // leftPaddle
            // 
            this.leftPaddle.AccessibleName = "leftPaddle";
            this.leftPaddle.Image = ((System.Drawing.Image)(resources.GetObject("leftPaddle.Image")));
            this.leftPaddle.Location = new System.Drawing.Point(70, 215);
            this.leftPaddle.Name = "leftPaddle";
            this.leftPaddle.Size = new System.Drawing.Size(13, 80);
            this.leftPaddle.TabIndex = 1;
            this.leftPaddle.TabStop = false;
            // 
            // ball
            // 
            this.ball.AccessibleName = "ball";
            this.ball.BackColor = System.Drawing.SystemColors.Highlight;
            this.ball.Location = new System.Drawing.Point(400, 248);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(15, 15);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.startButton.Location = new System.Drawing.Point(331, 204);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(144, 40);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(70, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 346);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // paddleTimerUp
            // 
            this.paddleTimerUp.Interval = 10;
            this.paddleTimerUp.Tick += new System.EventHandler(this.paddleTimerUp_Tick);
            // 
            // paddleTimerDown
            // 
            this.paddleTimerDown.Interval = 10;
            this.paddleTimerDown.Tick += new System.EventHandler(this.paddleTimerDown_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 53);
            this.label1.TabIndex = 7;
            this.label1.Text = "PONG!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.leftPaddle);
            this.Controls.Add(this.rightPaddle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.rightPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rightPaddle;
        private System.Windows.Forms.PictureBox leftPaddle;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer paddleTimerUp;
        private System.Windows.Forms.Timer paddleTimerDown;
        private System.Windows.Forms.Label label1;
    }
}

