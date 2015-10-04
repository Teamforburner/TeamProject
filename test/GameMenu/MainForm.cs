using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMenu
{
    public partial class FallingRocks : Form
    {
        public FallingRocks()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {

            Form2 difficultySelect = new Form2();
            difficultySelect.Show();
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            CreditsForm credits = new CreditsForm();
            credits.Show();
        }
    }
}
