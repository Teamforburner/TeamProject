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

        private int indexCoin;
        private int indexRock;
        private int coinCounter;
        private int gemsCounter;
        private int speedHeroNotWithElevator;

        private int liftXCoordinate = 120;
        private int liftYCoordinate = 420;
        private int lives = 3;
        private int speed = 5;
        private int speedHero = 5;

        private int rockFrequencyMaximumNumber = 3500;
        private int rockFrequencyMinimumNumber = 3300;
        private int coinFrequencyMaximumNumber = 3000;
        private int coinFrequencyMinimumNumber = 2800;

        List<Oval> coins = new List<Oval>();
        List<PictureBox> rocks = new List<PictureBox>();


        public Form1()
        {
            InitializeComponent();

            rockGeneratorTimer.Start();
            coinGeneratorTimer.Start();

            gemTextBox.Text = "Well done! Go to the elevator to collect your gem!";
            livesTextBox.Text = "Lives: " + lives;
            coinsTextBox.Text = "Coins: " + coinCounter;
            gemsTextBox.Text = "Gems: " + gemsCounter;

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool movingRestriction = false;
            bool isOnTheLift = liftTimer.Enabled;

            switch (e.KeyCode)
            {
                case Keys.Right:

                    if (isOnTheLift)
                    {
                        movingRestriction = hero.Right < lift.Right;
                    }
                    else
                    {
                        movingRestriction = hero.Left < 370;
                    }

                    if (movingRestriction)
                    {
                        if (lift.Visible)
                        {
                            if (hero.Right < lift.Left || hero.Bottom <= lift.Top)
                            {
                                hero.Left += speedHero;
                            }

                            if (hero.Left >= lift.Right)
                            {
                                hero.Left += speedHero;
                            }

                            if (hero.Left >= lift.Left + lift.Width/2 - 20)
                            {
                                liftTimer.Start();
                            }
                        }
                        else
                        {
                            coinMovementTimer.Start();
                            coinGeneratorTimer.Start();
                            rockMovementTimer.Start();
                            rockGeneratorTimer.Start();

                            hero.Left += speedHero;
                        }
                    }

                    break;

                case Keys.Left:

                    if (hero.Bottom == 420 || isOnTheLift)
                    {
                        movingRestriction = hero.Left > lift.Left;
                    }
                    else if (lift.Visible && hero.Bottom != 440)
                    {
                    }
                    else
                    {
                        movingRestriction = hero.Left > 0;
                    }


                    if (movingRestriction)
                    {
                        if (!lift.Visible)
                        {
                            coinMovementTimer.Start();
                            coinGeneratorTimer.Start();
                            rockMovementTimer.Start();
                            rockGeneratorTimer.Start();
                        }

                        hero.Left -= speedHero; 
                    }
                    break;
                case Keys.Up:

                    if (lift.Visible)
                    {
                        int i = hero.Location.X;
                        int m = hero.Location.Y;

                        if ((hero.Right == lift.Left && hero.Bottom > lift.Location.Y) || (hero.Left == lift.Right && hero.Bottom > lift.Location.Y))
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
            gemTextBox.Visible = false;

            int p = hero.Location.X;
            int q = hero.Location.Y;

            if (hero.Top > gemPicture.Bottom+5)
            {
                q -= 5;
                hero.Location = new Point(p, q);                
                liftYCoordinate -= 5;
                lift.Location = new Point(liftXCoordinate, liftYCoordinate);
            }
            else
            {                
                liftTimer.Stop();

                GetTheGem();

                IncreaseDifficulty();
            }
        }

        private void GetTheGem()
        {
            gemsCounter++;
            gemPicture.Visible = false;
            hero.Location = new Point(30, 390);
            lift.Visible = false;
            liftYCoordinate = 420;
            lift.Location = new Point(liftXCoordinate, liftYCoordinate);
            gemTextBox.Visible = false;
            livesTextBox.Visible = true;
            gemsTextBox.Visible = true;
            gemsTextBox.Text = "Gems: " + gemsCounter;
        }

        private void IncreaseDifficulty()
        {
            if (speed < 20)
            {
                speed += 5;
                speedHero = speedHeroNotWithElevator;
                speedHero += 5;
            }
            else
            {
                speedHero = speedHeroNotWithElevator;

            }

            if (rockFrequencyMinimumNumber > 1000)
            {
                rockFrequencyMinimumNumber -= 600;
                rockFrequencyMaximumNumber -= 600;
            }
            else if (rockFrequencyMinimumNumber > 200)
            {
                rockFrequencyMinimumNumber -= 80;
                rockFrequencyMaximumNumber -= 80;
            }

            if (coinFrequencyMinimumNumber > 1000)
            {
                coinFrequencyMaximumNumber -= 800;
                coinFrequencyMinimumNumber -= 800;
            }
            else if (coinFrequencyMinimumNumber > 40)
            {
                coinFrequencyMinimumNumber -= 40;
                coinFrequencyMaximumNumber -= 40;
            }
        }

        private void CoinGenerator_Tick_1(object sender, EventArgs e)
        {
            Oval coin = new Oval();
            coins.Add(coin);
            Random randomCoinLocation = new Random();
            Random randomCoinInterval = new Random();

            coins[indexCoin].BackColor = Color.FromArgb(128, 255, 255);
            coins[indexCoin].Image = Resources.CoinSM3DL;
            coins[indexCoin].Height = 30;
            coins[indexCoin].Width = 30;
            coins[indexCoin].Top = 0;
            coins[indexCoin].Left = randomCoinLocation.Next(0, 410);
            gamePanel.Controls.Add(coins[indexCoin]);
            coinGeneratorTimer.Interval = randomCoinInterval.Next(coinFrequencyMinimumNumber, coinFrequencyMaximumNumber); ;
            coinMovementTimer.Start();
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
            bool isCoinsXCoordinateTouchingTheHerosHead = coins[i].Bottom == hero.Top;
            bool isCoinsYCoordinateTouchingTheHerosHead = coins[i].Left > hero.Left-30 && coins[i].Left < hero.Right;
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

            bool isHeroTouchingTheCoinWiththeHead = isCoinsXCoordinateTouchingTheHerosHead && isCoinsYCoordinateTouchingTheHerosHead;

            if (isHeroTouchingTheCoinWiththeHead || isTheHeroTouchingTheCoinFromTheSide)
            {
                coinCounter++;
                gamePanel.Controls.Remove(coins[i]);
                coins.RemoveAt(i);
                coinsTextBox.Text = "Coins: " + coinCounter;
                indexCoin--;

                bool divisibleWithElevator = false;
                bool divisibleWithoutElevator = false;

                if (coinCounter < 10)
                {
                    divisibleWithElevator = coinCounter%5 == 0;
                }
                else
                {
                    divisibleWithElevator = coinCounter%30 == 0;
                    divisibleWithoutElevator = coinCounter%5 == 0;
                }

                if (divisibleWithElevator)
                {
                    coinMovementTimer.Stop();
                    coinGeneratorTimer.Stop();
                    rockMovementTimer.Stop();
                    rockGeneratorTimer.Stop();

                    hero.Location = new Point(30, 390);
                    lift.Visible = true;
                    gemPicture.Visible = true;
                    gemTextBox.Visible = true;
                    livesTextBox.Visible = true;
                    speedHeroNotWithElevator = speedHero;
                    speedHero = 5;
                }
                else if (divisibleWithoutElevator)
                {
                    speedHeroNotWithElevator = speedHero;
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
            PictureBox rock = new PictureBox();

            rocks.Add(rock);
            Random randomRockLocation = new Random();
            Random randomRockInterval = new Random();

            rocks[indexRock].BackColor = Color.Gray;
            rocks[indexRock].Image = Resources.rock;
            rocks[indexRock].Height = 12;
            rocks[indexRock].Width = 30;
            rocks[indexRock].Top = 0;
            rocks[indexRock].Left = randomRockLocation.Next(0, 370);
            gamePanel.Controls.Add(rocks[indexRock]);
            rockGeneratorTimer.Interval = randomRockInterval.Next(rockFrequencyMinimumNumber, rockFrequencyMaximumNumber);
            rockMovementTimer.Start();
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
            bool isRocksXCoordinateTouchingTheHerosHead = rocks[i].Bottom == hero.Top;
            bool isRocksYCoordinateTouchingTheHerosHead = rocks[i].Left > hero.Left - 12 && rocks[i].Left < hero.Right;
            bool isTheHeroTouchingTheRockFromTheSide = false;


            if (hero.Left < rocks[i].Left)
            {
                isTheHeroTouchingTheRockFromTheSide = hero.Right >= rocks[i].Left && hero.Location.Y <= rocks[i].Location.Y + 12 &&
                    hero.Location.Y + 50 > rocks[i].Location.Y;
            }
            else
            {
                isTheHeroTouchingTheRockFromTheSide = hero.Left < rocks[i].Right && hero.Location.Y <= rocks[i].Location.Y + 12 &&
                    hero.Location.Y + 50 > rocks[i].Location.Y;
            }

            bool isTheHeroTouchingTheRockWithHead = isRocksXCoordinateTouchingTheHerosHead &&
                                                    isRocksYCoordinateTouchingTheHerosHead;

            if (isTheHeroTouchingTheRockWithHead || isTheHeroTouchingTheRockFromTheSide)
            {
                lives--;
                gamePanel.Controls.Remove(rocks[i]);
                rocks.RemoveAt(i);
                livesTextBox.Text = "Lives: " + lives;
                indexRock--;

                CheckGameOver();
            }
        }

        private void CheckGameOver()
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
