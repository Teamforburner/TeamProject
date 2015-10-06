using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Properties;

namespace test
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;

        int indexCoin = 0;
        int indexRock = 0;
        private int coinCounter = 0;
        private int lives = 3;
        private int gems = 0;
        private int speed = 5;
        private int rockFrequency = 4000;
        private int coinFrequency = 2200;
        private int speedHero = 5;
        private int normalSpeed = 5;

        Random randomLocation = new Random();
        Random randomSize = new Random();
        Random randomInterval = new Random();
        Oval coin = new Oval() ;
        List<Oval> coins = new List<Oval>();
        PictureBox rock = new PictureBox();
        Random randomRockLocation = new Random();
        Random randomRockInterval = new Random();
        List<PictureBox> rocks = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();

            x = 120;
            y = 420;
            rockGenerator.Start();

            int yCoordinateDiamond = 10;
            CoinGenerator.Start();

            textBox1.Text = "Well done! Go to the elevator to collect your gem!";
            textBox2.Text = "Lives: " + lives;
            textBox3.Text = "Coins: " + coinCounter;
            textBox4.Text = "Gems: " + gems;

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:

                    if (hero.Left < 370)
                    {
                        if (pictureBox1.Visible)
                        {
                            if (hero.Right < pictureBox1.Left || hero.Bottom <= pictureBox1.Top)
                            {
                                hero.Left += speedHero;
                            }

                            if (hero.Left >= pictureBox1.Right)
                            {
                                hero.Left += speedHero;
                            }

                            if (hero.Left >= pictureBox1.Left + pictureBox1.Width/2 - 20)
                            {
                                TimerElevator.Enabled = true;
                                pictureBox3.Visible = false;
                            }

                        }
                        else
                        {
                            coinMovement.Start();
                            CoinGenerator.Start();
                            rockMovement.Start();
                            rockGenerator.Start();

                            hero.Left += speedHero;
                        }
                    }

                    break;

                case Keys.Left:
                    if (hero.Left > 0)
                    {
                        if (!pictureBox1.Visible)
                        {
                            coinMovement.Start();
                            CoinGenerator.Start();
                            rockMovement.Start();
                            rockGenerator.Start();
                        }

                        hero.Left -= speedHero; 
                    }
                    break;
                case Keys.Up:

                    if (pictureBox1.Visible)
                    {
                        int i = hero.Location.X;
                        int m = hero.Location.Y;

                        if ((hero.Right == pictureBox1.Left && hero.Bottom > pictureBox1.Location.Y) || (hero.Left == pictureBox1.Right && hero.Bottom > pictureBox1.Location.Y))
                        {
                            m -= 5;
                            hero.Location = new Point(i, m);
                        }
                    }

                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;

            }
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TimerElevator_Tick(object sender, EventArgs e)
        {
            textBox1.Visible = false;

            int p = hero.Location.X;
            int q = hero.Location.Y;

            if (hero.Top > pictureBox2.Bottom+5)
            {
                q -= 5;
                hero.Location = new Point(p, q);                
                y -= 5;
                pictureBox1.Location = new Point(x, y);
            }
            else
            {
                TimerElevator.Enabled = false;

                GetTheGem();

                IncreaseDifficulty();
            }
        }

        private void GetTheGem()
        {
            gems++;
            pictureBox2.Visible = false;
            hero.Location = new Point(30, 390);
            pictureBox1.Visible = false;
            y = 420;
            pictureBox1.Location = new Point(x, y);
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox4.Visible = true;
            textBox4.Text = "Gems: " + gems;
        }

        private void IncreaseDifficulty()
        {
            if (speed < 15)
            {
                speed += 5;
                speedHero = normalSpeed;
                speedHero += 5;
            }

            if (rockFrequency > 400)
            {
                rockFrequency -= 400;
            }
            else if (rockFrequency > 200)
            {
                rockFrequency -= 40;
            }

            if (coinFrequency > 400)
            {
                coinFrequency -= 400;
            }
            else if (coinFrequency > 40)
            {
                coinFrequency -= 40;
            }
        }

        private void CoinGenerator_Tick_1(object sender, EventArgs e)
        {
            coin = new Oval();
            coins.Add(coin);
            randomLocation = new Random();
            randomInterval = new Random();

            coins[indexCoin].BackColor = Color.FromArgb(128, 255, 255);
            coins[indexCoin].Image = Resources.CoinSM3DL;
            coins[indexCoin].Height = 30;
            coins[indexCoin].Width = 30;
            coins[indexCoin].Top = 0;
            coins[indexCoin].Left = randomLocation.Next(0, 410);
            gamePanel.Controls.Add(coins[indexCoin]);
            CoinGenerator.Interval = coinFrequency;
            coinMovement.Start();
            indexCoin++;
        }

        private void coinMovement_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < coins.Count; i++)
            {
                int x = coins[i].Location.X;
                int y = coins[i].Location.Y;
                coins[i].Location = new Point(x, y + speed);

                DetectCollisionWithACoin(i);
            }
        }

        private void DetectCollisionWithACoin(int i)
        {
            bool isCoinBottomNextToHerosTop = coins[i].Bottom == hero.Top;
            bool isCoinTouchingTheHerosHeadABitToTheRight = coins[i].Left >= hero.Left && coins[i].Left <= hero.Right;
            bool isCoinTouchingTheHerosHeadABitToTheLeft = coins[i].Right > hero.Left && coins[i].Right < hero.Right;
            bool isTheHeroTouchingTheCoinFromTheSide = false;

            if (hero.Left < coins[i].Left)
            {
                isTheHeroTouchingTheCoinFromTheSide = hero.Right >= coins[i].Left &&
                                                              hero.Location.Y <= coins[i].Location.Y + 30 &&
                                                              hero.Location.Y + 50 > coins[i].Location.Y;
            }
            else
            {
                isTheHeroTouchingTheCoinFromTheSide = hero.Left <= coins[i].Right &&
                                                              hero.Location.Y <= coins[i].Location.Y + 30 &&
                                                              hero.Location.Y + 50 > coins[i].Location.Y;
            }

            bool isHeroTouchingTheCoinWiththeHead = isCoinBottomNextToHerosTop &&
                                                    (isCoinTouchingTheHerosHeadABitToTheRight ||
                                                     isCoinTouchingTheHerosHeadABitToTheLeft);

            if (isHeroTouchingTheCoinWiththeHead || isTheHeroTouchingTheCoinFromTheSide)
            {
                coinCounter++;
                gamePanel.Controls.Remove(coins[i]);
                coins.RemoveAt(i);
                textBox3.Text = "Coins: " + coinCounter;
                indexCoin--;

                bool divisibleWithElevator = false;
                bool divisibleWithoutElevator = false;

                if (coinCounter < 10)
                {
                    divisibleWithElevator = coinCounter%5 == 0;
                }
                else
                {
                    divisibleWithoutElevator = coinCounter%5 == 0;
                }

                if (divisibleWithElevator)
                {
                    coinMovement.Stop();
                    CoinGenerator.Stop();
                    rockMovement.Stop();
                    rockGenerator.Stop();

                    hero.Location = new Point(30, 390);
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    normalSpeed = speedHero;
                    speedHero = 5;
                }
                else if (divisibleWithoutElevator)
                {
                    IncreaseDifficulty();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hero_Click(object sender, EventArgs e)
        {

        }

        private void rockGenerator_Tick(object sender, EventArgs e)
        {
            rock = new PictureBox();

            rocks.Add(rock);
            randomRockLocation = new Random();
            randomRockInterval = new Random();

            rocks[indexRock].BackColor = Color.Gray;
            rocks[indexRock].Image = Resources.rock;
            rocks[indexRock].Height = 12;
            rocks[indexRock].Width = 30;
            rocks[indexRock].Top = 0;
            rocks[indexRock].Left = randomLocation.Next(0, 370);
            gamePanel.Controls.Add(rocks[indexRock]);
            rockGenerator.Interval = rockFrequency;
            rockMovement.Start();
            indexRock++;
        }

        private void rockMovement_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < rocks.Count; i++)
            {
                int x = rocks[i].Location.X;
                int y = rocks[i].Location.Y;
                rocks[i].Location = new Point(x, y + speed);

                DetectCollisionWithAStone(i);

            }
        }

        private void DetectCollisionWithAStone(int i)
        {
            bool a = rocks[i].Bottom == hero.Top;
            bool b = rocks[i].Left >= hero.Left && rocks[i].Left <= hero.Right;
            bool c = false;

            if (hero.Left < rocks[i].Left)
            {
                c = hero.Right >= rocks[i].Left && hero.Location.Y <= rocks[i].Location.Y + 30 &&
                    hero.Location.Y + 50 > rocks[i].Location.Y;
            }
            else
            {
                c = hero.Left < rocks[i].Right && hero.Location.Y <= rocks[i].Location.Y + 30 &&
                    hero.Location.Y + 50 > rocks[i].Location.Y;
            }

            if ((a && (b || (rocks[i].Right > hero.Left && rocks[i].Right < hero.Right))) || c)
            {
                lives--;
                gamePanel.Controls.Remove(rocks[i]);
                rocks.RemoveAt(i);
                textBox2.Text = "Lives: " + lives;
                indexRock--;

                GameOver();
            }
        }

        private void GameOver()
        {
            if (lives == 0)
            {
                Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                Dispose();
            }
        }
    }
}
