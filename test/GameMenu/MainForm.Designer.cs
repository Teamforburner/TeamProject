namespace GameMenu
{
    partial class FallingRocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FallingRocks));
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.CreditsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.AccessibleName = "btn_one";
            this.NewGameBtn.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameBtn.Location = new System.Drawing.Point(263, 158);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(113, 60);
            this.NewGameBtn.TabIndex = 0;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // CreditsButton
            // 
            this.CreditsButton.AccessibleName = "btn_Credits";
            this.CreditsButton.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsButton.Location = new System.Drawing.Point(263, 295);
            this.CreditsButton.Name = "CreditsButton";
            this.CreditsButton.Size = new System.Drawing.Size(113, 59);
            this.CreditsButton.TabIndex = 2;
            this.CreditsButton.Text = "Credits";
            this.CreditsButton.UseVisualStyleBackColor = true;
            this.CreditsButton.Click += new System.EventHandler(this.CreditsButton_Click);
            // 
            // FallingRocks
            // 
            this.AccessibleName = "firstMenu";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 600);
            this.Controls.Add(this.CreditsButton);
            this.Controls.Add(this.NewGameBtn);
            this.Name = "FallingRocks";
            this.Text = "FallingRocks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Button CreditsButton;
    }
}

