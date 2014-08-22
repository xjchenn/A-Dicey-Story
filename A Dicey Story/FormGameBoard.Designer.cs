namespace SurvivalOfTheLuckiest
{
    partial class FormGameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameBoard));
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDice = new System.Windows.Forms.Timer(this.components);
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.lblPower = new System.Windows.Forms.Label();
            this.pbPower = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pbDice = new System.Windows.Forms.PictureBox();
            this.pbPlayers = new System.Windows.Forms.PictureBox();
            this.timerAnimate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.White;
            this.pbMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMain.BackgroundImage")));
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Location = new System.Drawing.Point(315, 27);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1023, 682);
            this.pbMain.TabIndex = 1;
            this.pbMain.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoRollToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // autoRollToolStripMenuItem
            // 
            this.autoRollToolStripMenuItem.Name = "autoRollToolStripMenuItem";
            this.autoRollToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.autoRollToolStripMenuItem.Text = "AutoRoll";
            this.autoRollToolStripMenuItem.Click += new System.EventHandler(this.autoRollToolStripMenuItem_Click);
            // 
            // timerDice
            // 
            this.timerDice.Interval = 50;
            this.timerDice.Tick += new System.EventHandler(this.timerDice_Tick);
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.Chartreuse;
            this.panelPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPlayer.Controls.Add(this.lblPower);
            this.panelPlayer.Controls.Add(this.pbPower);
            this.panelPlayer.Controls.Add(this.pbAvatar);
            this.panelPlayer.Controls.Add(this.lblName);
            this.panelPlayer.Controls.Add(this.pbDice);
            this.panelPlayer.Location = new System.Drawing.Point(33, 53);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(232, 156);
            this.panelPlayer.TabIndex = 5;
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("News Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(14, 59);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(59, 16);
            this.lblPower.TabIndex = 4;
            this.lblPower.Text = "Power:";
            // 
            // pbPower
            // 
            this.pbPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPower.Location = new System.Drawing.Point(17, 36);
            this.pbPower.Name = "pbPower";
            this.pbPower.Size = new System.Drawing.Size(100, 20);
            this.pbPower.TabIndex = 3;
            this.pbPower.TabStop = false;
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatar.Location = new System.Drawing.Point(137, 14);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(72, 87);
            this.pbAvatar.TabIndex = 1;
            this.pbAvatar.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("News Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Player 1";
            // 
            // pbDice
            // 
            this.pbDice.BackColor = System.Drawing.Color.Transparent;
            this.pbDice.Location = new System.Drawing.Point(17, 88);
            this.pbDice.Name = "pbDice";
            this.pbDice.Size = new System.Drawing.Size(50, 50);
            this.pbDice.TabIndex = 0;
            this.pbDice.TabStop = false;
            this.pbDice.Click += new System.EventHandler(this.pbDice_Click_1);
            // 
            // pbPlayers
            // 
            this.pbPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlayers.Location = new System.Drawing.Point(33, 231);
            this.pbPlayers.Name = "pbPlayers";
            this.pbPlayers.Size = new System.Drawing.Size(232, 423);
            this.pbPlayers.TabIndex = 6;
            this.pbPlayers.TabStop = false;
            // 
            // timerAnimate
            // 
            this.timerAnimate.Interval = 400;
            this.timerAnimate.Tick += new System.EventHandler(this.timerAnimate_Tick);
            // 
            // FormGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.pbPlayers);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGameBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGameBoard_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGameBoard_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Timer timerDice;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbDice;
        private System.Windows.Forms.PictureBox pbPower;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.PictureBox pbPlayers;
        private System.Windows.Forms.Timer timerAnimate;
        private System.Windows.Forms.ToolStripMenuItem autoRollToolStripMenuItem;
    }
}