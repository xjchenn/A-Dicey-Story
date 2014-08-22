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
    public partial class FormStory : Form
    {
        public FormStory()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Game Rules.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
