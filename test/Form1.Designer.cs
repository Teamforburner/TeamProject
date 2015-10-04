namespace test
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.hero = new System.Windows.Forms.PictureBox();
            this.grounPannel = new System.Windows.Forms.Panel();
            this.heroMovement = new System.Windows.Forms.Timer(this.components);
            this.rockGenerator = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TimerElevator = new System.Windows.Forms.Timer(this.components);
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gamePanel.Controls.Add(this.pictureBox2);
            this.gamePanel.Controls.Add(this.pictureBox1);
            this.gamePanel.Controls.Add(this.hero);
            this.gamePanel.Location = new System.Drawing.Point(12, 14);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(400, 440);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // hero
            // 
            this.hero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.hero.Location = new System.Drawing.Point(61, 390);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(30, 50);
            this.hero.TabIndex = 0;
            this.hero.TabStop = false;
            // 
            // grounPannel
            // 
            this.grounPannel.BackColor = System.Drawing.Color.Green;
            this.grounPannel.Location = new System.Drawing.Point(12, 454);
            this.grounPannel.Name = "grounPannel";
            this.grounPannel.Size = new System.Drawing.Size(400, 18);
            this.grounPannel.TabIndex = 1;
            // 
            // heroMovement
            // 
            this.heroMovement.Enabled = true;
            this.heroMovement.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rockGenerator
            // 
            this.rockGenerator.Enabled = true;
            this.rockGenerator.Tick += new System.EventHandler(this.rockGenerator_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(118, 423);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 17);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox2.Location = new System.Drawing.Point(184, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 18);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TimerElevator
            // 
            this.TimerElevator.Tick += new System.EventHandler(this.TimerElevator_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 476);
            this.Controls.Add(this.grounPannel);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Timer heroMovement;
        private System.Windows.Forms.Panel grounPannel;
        private System.Windows.Forms.Timer rockGenerator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer TimerElevator;
    }
}

