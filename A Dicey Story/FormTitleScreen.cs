using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SurvivalOfTheLuckiest
{
    public partial class FormTitleScreen : Form
    {
        public FormTitleScreen()
        {
            InitializeComponent();
            this.StartPosition=FormStartPosition.CenterScreen;
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            FormGameOptions FormGameOptions = new FormGameOptions();
            FormGameOptions.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            FormGameOptions.ShowDialog();
            this.Show();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Game Rules.pdf");
        }
    }
}
