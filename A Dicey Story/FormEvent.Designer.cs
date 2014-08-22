namespace SurvivalOfTheLuckiest
{
    partial class FormEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvent));
            this.btnOK = new System.Windows.Forms.Button();
            this.txtEventMessage = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(181, 107);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtEventMessage
            // 
            this.txtEventMessage.BackColor = System.Drawing.SystemColors.Control;
            this.txtEventMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEventMessage.Location = new System.Drawing.Point(12, 2);
            this.txtEventMessage.Multiline = true;
            this.txtEventMessage.Name = "txtEventMessage";
            this.txtEventMessage.ReadOnly = true;
            this.txtEventMessage.Size = new System.Drawing.Size(244, 52);
            this.txtEventMessage.TabIndex = 2;
            this.txtEventMessage.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.Location = new System.Drawing.Point(12, 60);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 72);
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(268, 144);
            this.Controls.Add(this.txtEventMessage);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEvent";
            this.Text = "Event!";
            this.Load += new System.EventHandler(this.FormEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtEventMessage;
        private System.Windows.Forms.PictureBox pbImage;
    }
}