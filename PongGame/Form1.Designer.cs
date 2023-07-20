namespace PongGame
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
            this.ceilingBlock = new System.Windows.Forms.Label();
            this.leftBlock = new System.Windows.Forms.Label();
            this.groundBlock = new System.Windows.Forms.Label();
            this.rightBlock = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.middleBlock = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.enemyScore = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.ScoreTime = new System.Windows.Forms.Timer(this.components);
            this.StartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // ceilingBlock
            // 
            this.ceilingBlock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ceilingBlock.Location = new System.Drawing.Point(34, 18);
            this.ceilingBlock.Name = "ceilingBlock";
            this.ceilingBlock.Size = new System.Drawing.Size(729, 10);
            this.ceilingBlock.TabIndex = 0;
            this.ceilingBlock.Tag = "floor";
            // 
            // leftBlock
            // 
            this.leftBlock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leftBlock.Location = new System.Drawing.Point(34, 18);
            this.leftBlock.Name = "leftBlock";
            this.leftBlock.Size = new System.Drawing.Size(10, 461);
            this.leftBlock.TabIndex = 1;
            this.leftBlock.Tag = "";
            // 
            // groundBlock
            // 
            this.groundBlock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groundBlock.Location = new System.Drawing.Point(34, 474);
            this.groundBlock.Name = "groundBlock";
            this.groundBlock.Size = new System.Drawing.Size(729, 10);
            this.groundBlock.TabIndex = 2;
            this.groundBlock.Tag = "floor";
            // 
            // rightBlock
            // 
            this.rightBlock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rightBlock.Location = new System.Drawing.Point(753, 28);
            this.rightBlock.Name = "rightBlock";
            this.rightBlock.Size = new System.Drawing.Size(10, 446);
            this.rightBlock.TabIndex = 3;
            this.rightBlock.Tag = "";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(728, 195);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(19, 69);
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            this.player.Tag = "players";
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.White;
            this.enemy.Location = new System.Drawing.Point(50, 207);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(19, 69);
            this.enemy.TabIndex = 5;
            this.enemy.TabStop = false;
            this.enemy.Tag = "players";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(705, 218);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(17, 17);
            this.ball.TabIndex = 6;
            this.ball.TabStop = false;
            // 
            // GameTime
            // 
            this.GameTime.Interval = 3;
            this.GameTime.Tick += new System.EventHandler(this.GameTime_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(391, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(391, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(391, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 17);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(391, 162);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 17);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(391, 195);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(17, 17);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(391, 261);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(17, 17);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // middleBlock
            // 
            this.middleBlock.BackColor = System.Drawing.Color.White;
            this.middleBlock.Location = new System.Drawing.Point(391, 227);
            this.middleBlock.Name = "middleBlock";
            this.middleBlock.Size = new System.Drawing.Size(17, 17);
            this.middleBlock.TabIndex = 13;
            this.middleBlock.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(391, 389);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(17, 17);
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Location = new System.Drawing.Point(391, 33);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(17, 17);
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.Location = new System.Drawing.Point(391, 293);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(17, 17);
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.White;
            this.pictureBox11.Location = new System.Drawing.Point(391, 325);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(17, 17);
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.White;
            this.pictureBox12.Location = new System.Drawing.Point(391, 357);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(17, 17);
            this.pictureBox12.TabIndex = 18;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.White;
            this.pictureBox14.Location = new System.Drawing.Point(391, 422);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(17, 17);
            this.pictureBox14.TabIndex = 19;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.White;
            this.pictureBox13.Location = new System.Drawing.Point(391, 454);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(17, 17);
            this.pictureBox13.TabIndex = 20;
            this.pictureBox13.TabStop = false;
            // 
            // enemyScore
            // 
            this.enemyScore.AutoSize = true;
            this.enemyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enemyScore.ForeColor = System.Drawing.Color.White;
            this.enemyScore.Location = new System.Drawing.Point(353, 37);
            this.enemyScore.Name = "enemyScore";
            this.enemyScore.Size = new System.Drawing.Size(32, 33);
            this.enemyScore.TabIndex = 21;
            this.enemyScore.Text = "0";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playerScore.ForeColor = System.Drawing.Color.White;
            this.playerScore.Location = new System.Drawing.Point(414, 37);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(32, 33);
            this.playerScore.TabIndex = 22;
            this.playerScore.Text = "0";
            // 
            // ScoreTime
            // 
            this.ScoreTime.Enabled = true;
            this.ScoreTime.Tick += new System.EventHandler(this.ScoreTime_Tick);
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StartLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartLabel.Location = new System.Drawing.Point(273, 195);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(251, 74);
            this.StartLabel.TabIndex = 23;
            this.StartLabel.Text = "PRESS ENTER\r\nTO START";
            this.StartLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(797, 498);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.enemyScore);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.middleBlock);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.player);
            this.Controls.Add(this.rightBlock);
            this.Controls.Add(this.groundBlock);
            this.Controls.Add(this.leftBlock);
            this.Controls.Add(this.ceilingBlock);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ceilingBlock;
        private System.Windows.Forms.Label leftBlock;
        private System.Windows.Forms.Label groundBlock;
        private System.Windows.Forms.Label rightBlock;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox middleBlock;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label enemyScore;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Timer ScoreTime;
        private System.Windows.Forms.Label StartLabel;
    }
}

