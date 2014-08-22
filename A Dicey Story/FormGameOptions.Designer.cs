namespace SurvivalOfTheLuckiest
{
    partial class FormGameOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameOptions));
            this.nudAmountPlayers = new System.Windows.Forms.NumericUpDown();
            this.lblPlayerAmount = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // nudAmountPlayers
            // 
            this.nudAmountPlayers.Location = new System.Drawing.Point(136, 21);
            this.nudAmountPlayers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudAmountPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAmountPlayers.Name = "nudAmountPlayers";
            this.nudAmountPlayers.Size = new System.Drawing.Size(120, 20);
            this.nudAmountPlayers.TabIndex = 0;
            this.nudAmountPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblPlayerAmount
            // 
            this.lblPlayerAmount.AutoSize = true;
            this.lblPlayerAmount.Location = new System.Drawing.Point(26, 23);
            this.lblPlayerAmount.Name = "lblPlayerAmount";
            this.lblPlayerAmount.Size = new System.Drawing.Size(104, 13);
            this.lblPlayerAmount.TabIndex = 6;
            this.lblPlayerAmount.Text = "Number Of Players : ";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(181, 60);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormGameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 98);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPlayerAmount);
            this.Controls.Add(this.nudAmountPlayers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGameOptions";
            this.Text = "New Game Options";
            this.Load += new System.EventHandler(this.FormGameOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAmountPlayers;
        private System.Windows.Forms.Label lblPlayerAmount;
        private System.Windows.Forms.Button btnOK;

    }
}