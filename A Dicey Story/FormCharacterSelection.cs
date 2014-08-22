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
    public partial class FormCharacterSelection : Form
    {
        int count = 1;
        int numberOfPlayers;
        int chosenPlayer = 0;
        List<Button> Avatars = new List<Button>();
        List<Player> players = new List<Player>();
        public FormCharacterSelection(int numberOfPlayers,bool simulation)
        {
            InitializeComponent();
            this.numberOfPlayers = numberOfPlayers;
            
        }
        private void FormCharacterSelection_Load(object sender, EventArgs e)
        {
            txtName.Text = "Player " + count.ToString();
            txtName.Select();
            Avatars.Add(btnArcher);
            Avatars.Add(btnMage);
            Avatars.Add(btnThief);
            Avatars.Add(btnWarrior);
        }
        private void btnArcher_Click(object sender, EventArgs e)
        {
            btnArcher.FlatAppearance.BorderSize = 1;
            btnMage.FlatAppearance.BorderSize = 0;
            btnThief.FlatAppearance.BorderSize = 0;
            btnWarrior.FlatAppearance.BorderSize = 0;
            if (txtName.Text != "")
                btnOK.Enabled = true;
            chosenPlayer = 0;

        }

        private void btnMage_Click(object sender, EventArgs e)
        {
            btnArcher.FlatAppearance.BorderSize = 0;
            btnMage.FlatAppearance.BorderSize = 1;
            btnThief.FlatAppearance.BorderSize = 0;
            btnWarrior.FlatAppearance.BorderSize = 0;
            if (txtName.Text != "")
                btnOK.Enabled = true;
            chosenPlayer = 1;
        }

        private void btnThief_Click(object sender, EventArgs e)
        {
            btnArcher.FlatAppearance.BorderSize = 0;
            btnMage.FlatAppearance.BorderSize = 0;
            btnThief.FlatAppearance.BorderSize = 1;
            btnWarrior.FlatAppearance.BorderSize = 0;
            if (txtName.Text != "")
                btnOK.Enabled = true;
            chosenPlayer = 2;
        }

        private void btnWarrior_Click(object sender, EventArgs e)
        {
            btnArcher.FlatAppearance.BorderSize = 0;
            btnMage.FlatAppearance.BorderSize = 0;
            btnThief.FlatAppearance.BorderSize = 0;
            btnWarrior.FlatAppearance.BorderSize = 1;
            if (txtName.Text != "")
                btnOK.Enabled = true;
            chosenPlayer = 3;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                btnOK.Enabled = false;
            if (btnArcher.FlatAppearance.BorderSize == 1 || btnMage.FlatAppearance.BorderSize == 1 || btnThief.FlatAppearance.BorderSize == 1 || btnWarrior.FlatAppearance.BorderSize == 1)
            {
                if (txtName.Text != "")
                    btnOK.Enabled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            Avatars[chosenPlayer].Hide();
            players.Add(new Player(txtName.Text, chosenPlayer));
            count++;
            lblPlayer.Text = "Player " + count.ToString();
            txtName.Text = "Player " + count.ToString();
            txtName.Select();
            btnOK.Enabled = false;
            btnBack.Show();
            if (count == numberOfPlayers)
            {
                btnOK.Text = "OK";
            }
            if (count > numberOfPlayers)
            {
                FormGameBoard FormGameBoard = new FormGameBoard(players);
                this.Hide();
                FormGameBoard.ShowDialog();
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            count--;
            if (count == 1)
                btnBack.Hide();
            lblPlayer.Text = "Player " + count.ToString();
            txtName.Text = "Player " + count.ToString();
            Avatars[players[players.Count-1].AvatarNumber].Show();
            players.RemoveAt(players.Count - 1);
            
            
        }

        
    }
}
