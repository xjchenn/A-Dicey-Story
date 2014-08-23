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
    public partial class FormEvent : Form
    {
        int i;
        bool dragonsword;
        int power;
        string ImagePath;
        public FormEvent(int eventnumber, bool dragonsword, int power)
        {
            InitializeComponent();
            i = eventnumber;
            this.dragonsword = dragonsword;
            this.power = power;
            ImagePath = "BronzeHelmet.png";
        }
        private void FormEvent_Load(object sender, EventArgs e)
        {
            string eventmessage = null;
            Random rand = new Random();
            if (i < 5)
            {
                int j = rand.Next(17);
                if (power == 4)
                {
                    ImagePath = "ThievesSupplies.png";
                    eventmessage = "You found an item of value but a thief took it from you.";
                }
                else
                {
                    eventmessage = PowerUp(i);
                }
            }
            else if (i == 5 || i == 6)
            {
                if (power == 1)
                {
                    ImagePath = "ThievesSupplies.png";
                    eventmessage = "A thief ransacked your supplies but nothing valuable could be taken.";
                }
                else
                {
                    //int x = rand.Next(1);
                    ImagePath = "ThievesSupplies.png";
                    if (i == 5)
                        eventmessage = "A thief snatched away your supplies. -1 Power";
                    else
                        eventmessage = "A thief snatched away your weapon. -1 Power";
                }
            }
            else if (i == 7)
            {
                if (dragonsword == true)
                {
                    ImagePath = "Sword.png";
                    eventmessage = "You have pulled out the one and only legendary dragon slaying sword from its stone. +2 Power";
                }
                else
                {
                    if (power == 4)
                    {
                        ImagePath = "ThievesSupplies.png";
                        eventmessage = "You found an item of value but a thief took it from you.";
                    }
                    else
                    {
                        int j = rand.Next(5);
                        eventmessage = PowerUp(j);
                    }
                }
            }
            else if (i == 8 || i == 9)
            {
                int y = rand.Next(2);
                if (y == 0)
                {
                    ImagePath = "foodandsupplies.png";
                    eventmessage = "You found extra supplies and food. You have enough energy to gain another turn. Roll again.";
                }
                else
                {
                    ImagePath = "Boots of Swiftness.png";
                    eventmessage = "You have found magic boots of speed. You gain another turn. Roll again.";
                }
            }
            else if (i == 10)
            {
                ImagePath = "slipandfell.png";
                eventmessage = "Oops, you slipped and fell. As a result, you lose your next turn.";
            }
            else if (i == 11)
            {
                ImagePath = "slipandfelldownramp.png";
                eventmessage = "You slipped and fell down a ramp, you advance 1 space. ";
            }
            else if (i == 12)
            {
                ImagePath = "WildBear.png";
                eventmessage = "You were chased out of the area by a wild bear, you are pushed away 2 spaces";
            }
            else if (i == 13)
            {
                ImagePath = "savagebees.png";
                eventmessage = "You were chased out of the area by a group of savage bees! You go back 1 space.";
            }
            else if (i == 14)
            {
                ImagePath = "Witch.png";
                eventmessage = "You encountered a witch. To deter your attention, she cast a spell on you to move away from the area. You advance 2 spaces.";
            }
            else if (i == 15)
            {
                ImagePath = "bandofthieves.png";
                eventmessage = "You were severely injured by a band of thieves in their attempt to steal from you. You return to your starting position.";
            }
            else
            {
                ImagePath = "dragonslayertrainer.png";
                eventmessage = "You receive extensive training from a former dragon slayer. To train, you lose your next turn. +1 Power";
            }
            txtEventMessage.Text = eventmessage;
            pbImage.BackgroundImage = Image.FromFile(ImagePath);
        }
        private string PowerUp(int i)
        {
            if (i == 0)
            {
                ImagePath = "natureblessing.gif";
                return "The spirit of nature grants you heightened senses. +1 Power";
            }
            else if (i == 1)
            {
                ImagePath = "BronzeHelmet.png";
                return "You have found a bronze helmet. +1 Power";
            }
            else if (i == 2)
            {
                ImagePath = "PowerElixir.png";
                return "You have found an elixir of power. +1 Power";
            }
            else if (i == 3)
            {
                ImagePath = "MithrilArmor.png";
                return "You have found a mithril vest. +1 Power";
            }
            else
            {
                ImagePath = "Crystal.png";
                return "You have obtained a weapon enhancement crystal. +1 Power";
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
