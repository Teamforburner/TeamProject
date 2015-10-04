using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;

        int indexCoin = 0;
        Random randomLocation = new Random();
        Random randomSize = new Random();
        Random randomInterval = new Random();
        PictureBox coin = new PictureBox();
        List<PictureBox> coins = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();

            x = 120;
            y = 423;

            int yCoordinateDiamond = 10;
            CoinGenerator.Start();

            
            textBox1.Text = "Well done! You passed the level!              " + Environment.NewLine + "" +
                            "\n Get on the elevator to collect your gem!";

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
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
                            if (hero.Right < pictureBox1.Left || hero.Bottom<=pictureBox1.Top)
                            {
                                hero.Left += 5;
                            }

                            if (hero.Left >= pictureBox1.Right)
                            {
                                hero.Left += 5;
                            }
                        }
                        else
                        {
                            hero.Left += 5;
                        }
                    }

                    break;

                case Keys.Left:
                    if (hero.Left > 0)
                    {
                        if (pictureBox1.Visible)
                        {
                            if (hero.Left > pictureBox1.Right || hero.Bottom <= pictureBox1.Top)
                            {
                                hero.Left -= 5;
                            }

                            if (hero.Right <= pictureBox1.Left)
                            {
                                hero.Left -= 5;
                            }
                        }
                        else
                        {
                            hero.Left -= 5;
                        }

                    }
                    break;
                case Keys.Up:
                    int i = hero.Location.X;
                    int m = hero.Location.Y;

                    if ((hero.Right == pictureBox1.Left && hero.Bottom > pictureBox1.Location.Y) || (hero.Left == pictureBox1.Right && hero.Bottom > pictureBox1.Location.Y))
                    {
                        m-=5;
                        hero.Location = new Point(i,m);
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

            int p = hero.Location.X;
            int q = hero.Location.Y;

            if (hero.Top > pictureBox2.Bottom)
            {
                q -= 5;
                hero.Location = new Point(p, q);
            }
            else
            {
                TimerElevator.Enabled = false;
            }

                y -= 5;
                pictureBox1.Location = new Point(x, y);

        }

        private void CoinGenerator_Tick_1(object sender, EventArgs e)
        {
            coin = new PictureBox();
            coins.Add(coin);
            randomLocation = new Random();
            randomInterval = new Random();

            coins[indexCoin].BackColor = Color.Yellow;
            coins[indexCoin].Height = 30;
            coins[indexCoin].Width = 30;
            coins[indexCoin].Top = 0;
            coins[indexCoin].Left = randomLocation.Next(0, 410);
            gamePanel.Controls.Add(coins[indexCoin]);
            CoinGenerator.Interval = 10000000;
            coinMovement.Start();
            indexCoin++;
        }

        private void coinMovement_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < coins.Count; i++)
            {
                int x = coins[i].Location.X;
                int y = coins[i].Location.Y;
                coins[i].Location = new Point(x, y + 5);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hero_Click(object sender, EventArgs e)
        {

        }
    }
}
