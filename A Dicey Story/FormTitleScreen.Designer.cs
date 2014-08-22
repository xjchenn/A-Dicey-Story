namespace SurvivalOfTheLuckiest
{
    partial class FormTitleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTitleScreen));
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartGame.BackgroundImage")));
            this.btnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            this.btnStartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Location = new System.Drawing.Point(63, 448);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(198, 64);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnHowToPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHowToPlay.BackgroundImage")));
            this.btnHowToPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHowToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHowToPlay.FlatAppearance.BorderSize = 0;
            this.btnHowToPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHowToPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHowToPlay.Location = new System.Drawing.Point(72, 507);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(172, 30);
            this.btnHowToPlay.TabIndex = 1;
            this.btnHowToPlay.UseVisualStyleBackColor = false;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // FormTitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 577);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnStartGame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTitleScreen";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnHowToPlay;

    }
}

