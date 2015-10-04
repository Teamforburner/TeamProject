namespace GameMenu
{
    partial class GameOverMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "btn_TryAgain";
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(158, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Try Again";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AccessibleName = "btn_ExitGame";
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(158, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit Game";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GameOverMenu
            // 
            this.AccessibleName = "GameOverMenu";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(295, 289);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GameOverMenu";
            this.Text = "FallingRocks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}