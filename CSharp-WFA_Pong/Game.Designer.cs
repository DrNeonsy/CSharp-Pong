namespace CSharp_WFA_Pong
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            playerOne = new PictureBox();
            gameLoop = new System.Windows.Forms.Timer(components);
            scoreLeftSide = new Label();
            scoreRightSide = new Label();
            playerTwo = new PictureBox();
            pongBall = new PictureBox();
            sep1 = new PictureBox();
            sep2 = new PictureBox();
            sep3 = new PictureBox();
            sep4 = new PictureBox();
            sep5 = new PictureBox();
            sep6 = new PictureBox();
            sep7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)playerOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pongBall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sep1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sep2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sep3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sep4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sep5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sep6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sep7).BeginInit();
            SuspendLayout();
            // 
            // playerOne
            // 
            playerOne.BackColor = Color.OrangeRed;
            playerOne.Location = new Point(7, 400);
            playerOne.Margin = new Padding(0);
            playerOne.Name = "playerOne";
            playerOne.Size = new Size(5, 120);
            playerOne.TabIndex = 0;
            playerOne.TabStop = false;
            // 
            // gameLoop
            // 
            gameLoop.Enabled = true;
            gameLoop.Interval = 5;
            gameLoop.Tick += Loop;
            // 
            // scoreLeftSide
            // 
            scoreLeftSide.BackColor = Color.Transparent;
            scoreLeftSide.Font = new Font("Calibri", 27F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLeftSide.ForeColor = Color.OrangeRed;
            scoreLeftSide.Location = new Point(576, 7);
            scoreLeftSide.Margin = new Padding(2, 0, 2, 0);
            scoreLeftSide.Name = "scoreLeftSide";
            scoreLeftSide.Size = new Size(78, 43);
            scoreLeftSide.TabIndex = 1;
            scoreLeftSide.Text = "0";
            scoreLeftSide.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scoreRightSide
            // 
            scoreRightSide.BackColor = Color.Transparent;
            scoreRightSide.Font = new Font("Calibri", 27F, FontStyle.Regular, GraphicsUnit.Point);
            scoreRightSide.ForeColor = Color.BlueViolet;
            scoreRightSide.Location = new Point(869, 7);
            scoreRightSide.Margin = new Padding(2, 0, 2, 0);
            scoreRightSide.Name = "scoreRightSide";
            scoreRightSide.Size = new Size(67, 43);
            scoreRightSide.TabIndex = 3;
            scoreRightSide.Text = "0";
            scoreRightSide.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerTwo
            // 
            playerTwo.BackColor = Color.BlueViolet;
            playerTwo.Location = new Point(1506, 400);
            playerTwo.Margin = new Padding(0);
            playerTwo.Name = "playerTwo";
            playerTwo.Size = new Size(5, 120);
            playerTwo.TabIndex = 5;
            playerTwo.TabStop = false;
            // 
            // pongBall
            // 
            pongBall.BackColor = Color.Transparent;
            pongBall.BackgroundImage = (Image)resources.GetObject("pongBall.BackgroundImage");
            pongBall.BackgroundImageLayout = ImageLayout.Stretch;
            pongBall.Location = new Point(735, 364);
            pongBall.Margin = new Padding(2, 2, 2, 2);
            pongBall.Name = "pongBall";
            pongBall.Size = new Size(28, 27);
            pongBall.TabIndex = 6;
            pongBall.TabStop = false;
            // 
            // sep1
            // 
            sep1.BackColor = Color.White;
            sep1.Location = new Point(746, 10);
            sep1.Margin = new Padding(2, 2, 2, 2);
            sep1.Name = "sep1";
            sep1.Size = new Size(7, 94);
            sep1.TabIndex = 7;
            sep1.TabStop = false;
            // 
            // sep2
            // 
            sep2.BackColor = Color.White;
            sep2.Location = new Point(746, 137);
            sep2.Margin = new Padding(2, 2, 2, 2);
            sep2.Name = "sep2";
            sep2.Size = new Size(7, 94);
            sep2.TabIndex = 8;
            sep2.TabStop = false;
            // 
            // sep3
            // 
            sep3.BackColor = Color.White;
            sep3.Location = new Point(746, 266);
            sep3.Margin = new Padding(2, 2, 2, 2);
            sep3.Name = "sep3";
            sep3.Size = new Size(7, 94);
            sep3.TabIndex = 9;
            sep3.TabStop = false;
            // 
            // sep4
            // 
            sep4.BackColor = Color.White;
            sep4.Location = new Point(746, 390);
            sep4.Margin = new Padding(2, 2, 2, 2);
            sep4.Name = "sep4";
            sep4.Size = new Size(7, 94);
            sep4.TabIndex = 10;
            sep4.TabStop = false;
            // 
            // sep5
            // 
            sep5.BackColor = Color.White;
            sep5.Location = new Point(746, 514);
            sep5.Margin = new Padding(2, 2, 2, 2);
            sep5.Name = "sep5";
            sep5.Size = new Size(7, 94);
            sep5.TabIndex = 11;
            sep5.TabStop = false;
            // 
            // sep6
            // 
            sep6.BackColor = Color.White;
            sep6.Location = new Point(746, 635);
            sep6.Margin = new Padding(2, 2, 2, 2);
            sep6.Name = "sep6";
            sep6.Size = new Size(7, 94);
            sep6.TabIndex = 12;
            sep6.TabStop = false;
            // 
            // sep7
            // 
            sep7.BackColor = Color.White;
            sep7.Location = new Point(746, 748);
            sep7.Margin = new Padding(2, 2, 2, 2);
            sep7.Name = "sep7";
            sep7.Size = new Size(7, 62);
            sep7.TabIndex = 13;
            sep7.TabStop = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1520, 819);
            Controls.Add(pongBall);
            Controls.Add(sep7);
            Controls.Add(sep6);
            Controls.Add(sep5);
            Controls.Add(sep4);
            Controls.Add(sep3);
            Controls.Add(sep2);
            Controls.Add(sep1);
            Controls.Add(playerTwo);
            Controls.Add(playerOne);
            Controls.Add(scoreRightSide);
            Controls.Add(scoreLeftSide);
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(1540, 873);
            MinimumSize = new Size(1538, 824);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "w";
            KeyDown += Game_KeyDown;
            KeyUp += Game_KeyUp;
            ((System.ComponentModel.ISupportInitialize)playerOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pongBall).EndInit();
            ((System.ComponentModel.ISupportInitialize)sep1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sep2).EndInit();
            ((System.ComponentModel.ISupportInitialize)sep3).EndInit();
            ((System.ComponentModel.ISupportInitialize)sep4).EndInit();
            ((System.ComponentModel.ISupportInitialize)sep5).EndInit();
            ((System.ComponentModel.ISupportInitialize)sep6).EndInit();
            ((System.ComponentModel.ISupportInitialize)sep7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private PictureBox playerOne;
        private Label scoreLeftSide;
        private Label scoreRightSide;
        private PictureBox playerTwo;
        private PictureBox pongBall;
        private PictureBox sep1;
        private PictureBox sep2;
        private PictureBox sep3;
        private PictureBox sep4;
        private PictureBox sep5;
        private PictureBox sep6;
        private PictureBox sep7;
    }
}