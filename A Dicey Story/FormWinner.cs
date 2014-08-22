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
    public partial class FormWinner : Form
    {
        public FormWinner(string player)
        {
            InitializeComponent();
            string winner = player;
            pbWinner.BackgroundImage = Image.FromFile(@"WIN.jpg");
            rtbDragonSlain.Text = "The dragon has been slain by " + winner + ". Congratulations " + winner + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
