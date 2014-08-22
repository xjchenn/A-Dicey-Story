namespace SurvivalOfTheLuckiest
{
    partial class FormBattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBattle));
            this.pbAvatarP1 = new System.Windows.Forms.PictureBox();
            this.pbDice = new System.Windows.Forms.PictureBox();
            this.pbDiceP2 = new System.Windows.Forms.PictureBox();
            this.pbAvatarP2 = new System.Windows.Forms.PictureBox();
            this.timerRoll = new System.Windows.Forms.Timer(this.components);
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarP2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAvatarP1
            // 
            this.pbAvatarP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatarP1.Location = new System.Drawing.Point(12, 38);
            this.pbAvatarP1.Name = "pbAvatarP1";
            this.pbAvatarP1.Size = new System.Drawing.Size(72, 87);
            this.pbAvatarP1.TabIndex = 2;
            this.pbAvatarP1.TabStop = false;
            // 
            // pbDice
            // 
            this.pbDice.BackColor = System.Drawing.Color.Transparent;
            this.pbDice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDice.Location = new System.Drawing.Point(90, 65);
            this.pbDice.Name = "pbDice";
            this.pbDice.Size = new System.Drawing.Size(60, 60);
            this.pbDice.TabIndex = 4;
            this.pbDice.TabStop = false;
            this.pbDice.Click += new System.EventHandler(this.pbDice_Click);
            // 
            // pbDiceP2
            // 
            this.pbDiceP2.BackColor = System.Drawing.Color.Transparent;
            this.pbDiceP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDiceP2.Location = new System.Drawing.Point(184, 65);
            this.pbDiceP2.Name = "pbDiceP2";
            this.pbDiceP2.Size = new System.Drawing.Size(60, 60);
            this.pbDiceP2.TabIndex = 6;
            this.pbDiceP2.TabStop = false;
            this.pbDiceP2.Click += new System.EventHandler(this.pbDiceP2_Click);
            // 
            // pbAvatarP2
            // 
            this.pbAvatarP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatarP2.Location = new System.Drawing.Point(248, 38);
            this.pbAvatarP2.Name = "pbAvatarP2";
            this.pbAvatarP2.Size = new System.Drawing.Size(72, 87);
            this.pbAvatarP2.TabIndex = 5;
            this.pbAvatarP2.TabStop = false;
            // 
            // timerRoll
            // 
            this.timerRoll.Interval = 50;
            this.timerRoll.Tick += new System.EventHandler(this.timerRoll_Tick);
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("News Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(12, 16);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(86, 19);
            this.lblP1.TabIndex = 7;
            this.lblP1.Text = "Player 1";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("News Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(229, 16);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(86, 19);
            this.lblP2.TabIndex = 8;
            this.lblP2.Text = "Player 1";
            // 
            // lblWin
            // 
            this.lblWin.Font = new System.Drawing.Font("News Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(86, 141);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(158, 55);
            this.lblWin.TabIndex = 9;
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(233, 199);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 234);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.pbDiceP2);
            this.Controls.Add(this.pbAvatarP2);
            this.Controls.Add(this.pbDice);
            this.Controls.Add(this.pbAvatarP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBattle";
            this.Text = "Battle!";
            this.Load += new System.EventHandler(this.FormBattle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAvatarP1;
        private System.Windows.Forms.PictureBox pbDice;
        private System.Windows.Forms.PictureBox pbDiceP2;
        private System.Windows.Forms.PictureBox pbAvatarP2;
        private System.Windows.Forms.Timer timerRoll;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Button btnOK;
    }
}