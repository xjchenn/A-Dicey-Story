namespace SurvivalOfTheLuckiest
{
    partial class FormWinner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWinner));
            this.pbWinner = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbDragonSlain = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWinner
            // 
            this.pbWinner.Image = ((System.Drawing.Image)(resources.GetObject("pbWinner.Image")));
            this.pbWinner.Location = new System.Drawing.Point(281, 194);
            this.pbWinner.Name = "pbWinner";
            this.pbWinner.Size = new System.Drawing.Size(164, 171);
            this.pbWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWinner.TabIndex = 5;
            this.pbWinner.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(21, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 373);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rtbDragonSlain
            // 
            this.rtbDragonSlain.BackColor = System.Drawing.SystemColors.Control;
            this.rtbDragonSlain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDragonSlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDragonSlain.Location = new System.Drawing.Point(281, 29);
            this.rtbDragonSlain.Name = "rtbDragonSlain";
            this.rtbDragonSlain.ReadOnly = true;
            this.rtbDragonSlain.Size = new System.Drawing.Size(164, 105);
            this.rtbDragonSlain.TabIndex = 6;
            this.rtbDragonSlain.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbDragonSlain);
            this.Controls.Add(this.pbWinner);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWinner";
            this.Text = "You Won!";
            ((System.ComponentModel.ISupportInitialize)(this.pbWinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWinner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtbDragonSlain;
        private System.Windows.Forms.Button button1;

    }
}