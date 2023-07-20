using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
// hersey tamam sadece skor hatasi duzeltilicek ve baslma ekrani eklenicek
namespace PongGame
{
    public partial class Form1 : Form
    {
        int speedX,speedY; // for ball
        int PlayerSpeed;
        int EnemySpeed;
        int Escore, Pscore;

        Random rnd = new Random(); 

        bool GoUp, GoDown; // for player
        
      
        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimeStarter() // first values
        {
            speedX = 5;
            speedY = 5;
            PlayerSpeed = 5;
            EnemySpeed = 2;
            Escore = 0;
            Pscore = 0;

            GameTime.Enabled = true;
            ScoreTime.Enabled = true;
            this.Controls.Remove(StartLabel);
        }

        

        private void GameTime_Tick(object sender, EventArgs e) // main game timer
        {
            // player movement
            if(GoUp == true && player.Top > ceilingBlock.Location.Y + ceilingBlock.Height)
            {
                player.Top -= PlayerSpeed;
            }
            if (GoDown == true && player.Top < groundBlock.Location.Y - player.Height )
            {
                player.Top += PlayerSpeed;
            }


            //ball movement
            ball.Top += speedY;
            ball.Left += speedX;


            foreach(Control x in this.Controls) // changing ball direction for Y axis if ball hits the gorund block or ceilng block
            {
                if(x is Label && (string)x.Tag == "floor")
                {
                    if(x.Bounds.IntersectsWith(ball.Bounds))
                    {
                        speedY = -speedY;
                    }
                }
            }


            if (ball.Bounds.IntersectsWith(player.Bounds))//if ball hits enemy or player changing the X Y direction and ball speed values
            {
                speedY = rnd.Next(-5, 6);
                speedX = -rnd.Next(7, 11);
            }
            if (ball.Bounds.IntersectsWith(enemy.Bounds))
            {
                speedY = rnd.Next(-5, 6);
                speedX = rnd.Next(7, 11);
            }

           
            if (ball.Location.X < 400 && speedX < 0 && enemy.Top < groundBlock.Top - enemy.Height)//Enemy Controller
            {
                if (ball.Top < enemy.Top )
                {
                    enemy.Top += -5;
                }          
                else if(ball.Top > enemy.Top  && ball.Top < enemy.Top + enemy.Height )
                {
                    
                }
                else if (ball.Top > enemy.Top )
                {
                    enemy.Top += 5;
                }
                           
                EnemySpeed = rnd.Next(0, 6);
            }
            else if (ball.Top > groundBlock.Top - enemy.Height && enemy.Top < groundBlock.Top - enemy.Height && ball.Location.X < 400 && speedX < 0)
            {            
                enemy.Top += 4;
            }
            else
            {
                enemy.Top += EnemySpeed;
                if(enemy.Bounds.IntersectsWith(ceilingBlock.Bounds) || enemy.Bounds.IntersectsWith(groundBlock.Bounds))
                {
                    EnemySpeed = -EnemySpeed;                  
                }
            }              
        }


        private void ScoreTime_Tick(object sender, EventArgs e) // score 
        {
            if (ball.Left > rightBlock.Left)
            {
                enemyScore.Text = (++Escore).ToString();
                speedX = rnd.Next(1, 4);
                speedY = rnd.Next(-5, 6);
                ball.Location = middleBlock.Location;
            }
            else if(ball.Left < leftBlock.Left)
            {
                playerScore.Text = (++Pscore).ToString();
                speedX = -rnd.Next(1, 4);
                speedY = rnd.Next(-5, 6);
                ball.Location = middleBlock.Location;
            }           
        }


        #region CONTROLLER_BOOL 
        private void Form1_KeyDown(object sender, KeyEventArgs e) //Controllers
        {
            if(e.KeyCode == Keys.Up)
            {
                GoUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                GameTimeStarter();
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                GoUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = false;
            }
        }
        #endregion
    }
}
