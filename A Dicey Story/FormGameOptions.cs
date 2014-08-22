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
    public partial class FormGameOptions : Form
    {
        public FormGameOptions()
        {
            InitializeComponent();
        }

        private void FormGameOptions_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCharacterSelection formCharacterSelection = new FormCharacterSelection(Convert.ToInt32(nudAmountPlayers.Value),false);
            formCharacterSelection.StartPosition = FormStartPosition.CenterScreen;
            formCharacterSelection.ShowDialog();
            
        }
    }
}
