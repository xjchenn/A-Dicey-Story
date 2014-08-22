namespace SurvivalOfTheLuckiest
{
    partial class FormCharacterSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCharacterSelection));
            this.btnWarrior = new System.Windows.Forms.Button();
            this.btnThief = new System.Windows.Forms.Button();
            this.btnMage = new System.Windows.Forms.Button();
            this.btnArcher = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWarrior
            // 
            this.btnWarrior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWarrior.BackgroundImage")));
            this.btnWarrior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWarrior.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnWarrior.FlatAppearance.BorderSize = 0;
            this.btnWarrior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWarrior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWarrior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarrior.Location = new System.Drawing.Point(210, 142);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(60, 60);
            this.btnWarrior.TabIndex = 18;
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.Click += new System.EventHandler(this.btnWarrior_Click);
            // 
            // btnThief
            // 
            this.btnThief.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThief.BackgroundImage")));
            this.btnThief.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThief.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnThief.FlatAppearance.BorderSize = 0;
            this.btnThief.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThief.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThief.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThief.Location = new System.Drawing.Point(144, 142);
            this.btnThief.Name = "btnThief";
            this.btnThief.Size = new System.Drawing.Size(60, 60);
            this.btnThief.TabIndex = 17;
            this.btnThief.UseVisualStyleBackColor = true;
            this.btnThief.Click += new System.EventHandler(this.btnThief_Click);
            // 
            // btnMage
            // 
            this.btnMage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMage.BackgroundImage")));
            this.btnMage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMage.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnMage.FlatAppearance.BorderSize = 0;
            this.btnMage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMage.Location = new System.Drawing.Point(78, 142);
            this.btnMage.Name = "btnMage";
            this.btnMage.Size = new System.Drawing.Size(60, 60);
            this.btnMage.TabIndex = 16;
            this.btnMage.UseVisualStyleBackColor = true;
            this.btnMage.Click += new System.EventHandler(this.btnMage_Click);
            // 
            // btnArcher
            // 
            this.btnArcher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArcher.BackgroundImage")));
            this.btnArcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArcher.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnArcher.FlatAppearance.BorderSize = 0;
            this.btnArcher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnArcher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnArcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArcher.Location = new System.Drawing.Point(12, 142);
            this.btnArcher.Name = "btnArcher";
            this.btnArcher.Size = new System.Drawing.Size(60, 60);
            this.btnArcher.TabIndex = 15;
            this.btnArcher.UseVisualStyleBackColor = true;
            this.btnArcher.Click += new System.EventHandler(this.btnArcher_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(195, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "Continue";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 36);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(91, 13);
            this.lblInstructions.TabIndex = 19;
            this.lblInstructions.Text = "Enter Your Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 20;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(179, 9);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(91, 25);
            this.lblPlayer.TabIndex = 21;
            this.lblPlayer.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Select Your Avatar:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 227);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormCharacterSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(291, 262);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnWarrior);
            this.Controls.Add(this.btnThief);
            this.Controls.Add(this.btnMage);
            this.Controls.Add(this.btnArcher);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCharacterSelection";
            this.Text = "Character Selection";
            this.Load += new System.EventHandler(this.FormCharacterSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWarrior;
        private System.Windows.Forms.Button btnThief;
        private System.Windows.Forms.Button btnMage;
        private System.Windows.Forms.Button btnArcher;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
    }
}