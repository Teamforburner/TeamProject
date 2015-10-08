namespace FallingStonesPlus
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gemPicture = new System.Windows.Forms.PictureBox();
            this.lift = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            this.gemTextBox = new System.Windows.Forms.TextBox();
            this.grounPannel = new System.Windows.Forms.Panel();
            this.liftTimer = new System.Windows.Forms.Timer(this.components);
            this.coinMovementTimer = new System.Windows.Forms.Timer(this.components);
            this.coinGeneratorTimer = new System.Windows.Forms.Timer(this.components);
            this.rockGeneratorTimer = new System.Windows.Forms.Timer(this.components);
            this.rockMovementTimer = new System.Windows.Forms.Timer(this.components);
            this.livesTextBox = new System.Windows.Forms.TextBox();
            this.coinsTextBox = new System.Windows.Forms.TextBox();
            this.gemsTextBox = new System.Windows.Forms.TextBox();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gemPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gamePanel.Controls.Add(this.gemPicture);
            this.gamePanel.Controls.Add(this.lift);
            this.gamePanel.Controls.Add(this.hero);
            this.gamePanel.Controls.Add(this.gemTextBox);
            this.gamePanel.Location = new System.Drawing.Point(12, 14);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(400, 440);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // gemPicture
            // 
            this.gemPicture.BackColor = System.Drawing.Color.Maroon;
            this.gemPicture.BackgroundImage = global::FallingStonesPlus.Properties.Resources.DiamondResize3;
            this.gemPicture.Location = new System.Drawing.Point(177, 47);
            this.gemPicture.Name = "gemPicture";
            this.gemPicture.Size = new System.Drawing.Size(33, 32);
            this.gemPicture.TabIndex = 2;
            this.gemPicture.TabStop = false;
            this.gemPicture.Visible = false;
            this.gemPicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lift
            // 
            this.lift.BackColor = System.Drawing.Color.Gray;
            this.lift.Location = new System.Drawing.Point(120, 420);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(170, 20);
            this.lift.TabIndex = 1;
            this.lift.TabStop = false;
            this.lift.Visible = false;
            this.lift.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hero
            // 
            this.hero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.hero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hero.BackgroundImage")));
            this.hero.Location = new System.Drawing.Point(0, 390);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(30, 50);
            this.hero.TabIndex = 0;
            this.hero.TabStop = false;
            this.hero.Click += new System.EventHandler(this.hero_Click);
            // 
            // gemTextBox
            // 
            this.gemTextBox.Enabled = false;
            this.gemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gemTextBox.Location = new System.Drawing.Point(99, 128);
            this.gemTextBox.Multiline = true;
            this.gemTextBox.Name = "gemTextBox";
            this.gemTextBox.Size = new System.Drawing.Size(223, 82);
            this.gemTextBox.TabIndex = 3;
            this.gemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gemTextBox.Visible = false;
            // 
            // grounPannel
            // 
            this.grounPannel.BackColor = System.Drawing.Color.Green;
            this.grounPannel.Location = new System.Drawing.Point(12, 454);
            this.grounPannel.Name = "grounPannel";
            this.grounPannel.Size = new System.Drawing.Size(400, 18);
            this.grounPannel.TabIndex = 1;
            // 
            // liftTimer
            // 
            this.liftTimer.Tick += new System.EventHandler(this.TimerElevator_Tick);
            // 
            // coinMovementTimer
            // 
            this.coinMovementTimer.Interval = 90;
            this.coinMovementTimer.Tick += new System.EventHandler(this.coinMovement_Tick_1);
            // 
            // coinGeneratorTimer
            // 
            this.coinGeneratorTimer.Tick += new System.EventHandler(this.CoinGenerator_Tick_1);
            // 
            // rockGeneratorTimer
            // 
            this.rockGeneratorTimer.Tick += new System.EventHandler(this.rockGenerator_Tick);
            // 
            // rockMovementTimer
            // 
            this.rockMovementTimer.Tick += new System.EventHandler(this.rockMovement_Tick);
            // 
            // livesTextBox
            // 
            this.livesTextBox.Enabled = false;
            this.livesTextBox.Location = new System.Drawing.Point(481, 155);
            this.livesTextBox.Name = "livesTextBox";
            this.livesTextBox.Size = new System.Drawing.Size(81, 20);
            this.livesTextBox.TabIndex = 2;
            // 
            // coinsTextBox
            // 
            this.coinsTextBox.Enabled = false;
            this.coinsTextBox.Location = new System.Drawing.Point(481, 204);
            this.coinsTextBox.Name = "coinsTextBox";
            this.coinsTextBox.Size = new System.Drawing.Size(82, 20);
            this.coinsTextBox.TabIndex = 3;
            // 
            // gemsTextBox
            // 
            this.gemsTextBox.Enabled = false;
            this.gemsTextBox.Location = new System.Drawing.Point(481, 241);
            this.gemsTextBox.Name = "gemsTextBox";
            this.gemsTextBox.Size = new System.Drawing.Size(81, 20);
            this.gemsTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 476);
            this.Controls.Add(this.gemsTextBox);
            this.Controls.Add(this.coinsTextBox);
            this.Controls.Add(this.livesTextBox);
            this.Controls.Add(this.grounPannel);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gemPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Panel grounPannel;
        private System.Windows.Forms.PictureBox lift;
        private System.Windows.Forms.PictureBox gemPicture;
        private System.Windows.Forms.Timer liftTimer;
        private System.Windows.Forms.TextBox gemTextBox;
        private System.Windows.Forms.Timer coinMovementTimer;
        private System.Windows.Forms.Timer coinGeneratorTimer;
        private System.Windows.Forms.Timer rockGeneratorTimer;
        private System.Windows.Forms.Timer rockMovementTimer;
        private System.Windows.Forms.TextBox livesTextBox;
        private System.Windows.Forms.TextBox coinsTextBox;
        private System.Windows.Forms.TextBox gemsTextBox;
    }
}

