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
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Timer heroMovement;
        private System.Windows.Forms.Panel grounPannel;
        private System.Windows.Forms.Timer rockGenerator;
    }
}

