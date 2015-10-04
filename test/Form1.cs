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

        int indexRocks = 0;
        Random randomLocation = new Random();
        Random randomSize = new Random();
        Random randomInterval = new Random();
        PictureBox rock = new PictureBox();
        List<PictureBox> rocks = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();

            x = 120;
            y = Bottom;

            int yCoordinateDiamond = 10;

            TimerElevator.Enabled = true;
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
                        hero.Left += 5;
                    }
                    break;
                case Keys.Left:
                    if (hero.Left > 0)
                    {
                        hero.Left -= 5;
                    }
                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;

            }
        }

        private void rockGenerator_Tick(object sender, EventArgs e)
        {
            rock = new PictureBox();
            rock.Left = randomLocation.Next(0, 400);
            rock.Height = 30;
            rock.Width = 30;
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TimerElevator_Tick(object sender, EventArgs e)
        {
            if (y > pictureBox2.Bottom+20)
            {
                y -= 5;
                pictureBox1.Location = new Point(x, y);
            }
        }
    }
}
