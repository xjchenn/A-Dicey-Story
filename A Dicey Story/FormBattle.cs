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
    public partial class FormBattle : Form
    {
        Player player1, player2;
        Graphics gDice;
        Bitmap diceBitmap;
        bool rollFlag1, rollFlag2;
        int dice;
        int diceCount;
        int rollP1, rollP2;
        Player lose;
        int randNum;
        public Player Lose
        {
            get { return lose; }
        }
        public FormBattle(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            rollFlag1 = true;
            rollFlag2 = true;
            randNum = 0;
            InitializeComponent();
        }

        private void FormBattle_Load(object sender, EventArgs e)
        {
            pbDice.Focus();
            diceBitmap=new Bitmap(pbDice.Width,pbDice.Height);
            gDice=Graphics.FromImage(diceBitmap);
            pbAvatarP1.BackgroundImage = player1.getAvatar(1);
            pbAvatarP2.BackgroundImage = player2.getAvatar(0);
            lblP1.Text = player1.Name;
            lblP2.Text = player2.Name;
            
            rollP1 = 0;
            rollP2 = 0;
            dice = 0;
            diceCount = 0;
            pbDice.Image = new Bitmap(drawBattleDice(gDice, diceBitmap, new Pen(Color.White), new SolidBrush(Color.Black), player1.Power, 0));
            pbDiceP2.Image = new Bitmap(drawBattleDice(gDice, diceBitmap, new Pen(Color.White), new SolidBrush(Color.Black), player2.Power, 0));
        }
        Bitmap drawBattleDice(Graphics gDice, Bitmap diceBitmap, Pen myPen, Brush myBrush, int level, int randomNumber)
        {
            gDice.Clear(Color.Transparent);
            PointF[] Verticies;
                Verticies = new PointF[3];
                Verticies[0] = new PointF(0, pbDice.Height - 1);
                Verticies[1] = new PointF(pbDice.Width - 1, pbDice.Height - 1);
                Verticies[2] = new PointF(pbDice.Width / 2.0f, (float)(pbDice.Height - 1 - pbDice.Height / 2 * Math.Sqrt(3)));

                if (level == 1)
                    gDice.FillPolygon(new SolidBrush(Color.Green), Verticies);
                else if(level==2)
                    gDice.FillPolygon(new SolidBrush(Color.Red), Verticies);
                else if (level == 3)
                    gDice.FillPolygon(new SolidBrush(Color.Blue), Verticies);
                else if (level == 4)
                    gDice.FillPolygon(new SolidBrush(Color.Purple), Verticies);
                myPen.Color = Color.Black;
                gDice.DrawPolygon(myPen, Verticies);
            Font font = new Font("Times New Roman", 16, FontStyle.Bold);
            StringFormat format = new StringFormat();
            Brush whiteBrush = new SolidBrush(Color.White);
            format.Alignment = StringAlignment.Center;
            RectangleF rect = new RectangleF(pbDice.Width / 2 - 20 , pbDice.Height / 2 - 4 , 40 , 25);
            if (randomNumber == 0)
            {
                rect.Y = pbDice.Height / 2 + 6;
                gDice.DrawString("Roll", new Font("Times New Roman", 14, FontStyle.Italic), whiteBrush, rect, format);
            }
            else
            {
                gDice.DrawString(randomNumber.ToString(), font, whiteBrush, rect, format);
            }
            return diceBitmap;
        }

        private void pbDice_Click(object sender, EventArgs e)
        {
            if (rollFlag1)
            {
                dice = 1;
                timerRoll.Start();
            }
            rollFlag1 = false;
            
        }

        private void pbDiceP2_Click(object sender, EventArgs e)
        {
            if (rollFlag2)
            {
                dice = 2;
                timerRoll.Start();
            }
            rollFlag2 = false;
     
        }

        private void timerRoll_Tick(object sender, EventArgs e)
        {
            
            if (diceCount > 15)
            {
                timerRoll.Stop();
                diceCount = 0;
                if(dice==1)
                    rollP1=randNum;
                else if(dice==2)
                    rollP2 = randNum;
                if (!rollFlag1 && !rollFlag2)
                {
                    if (rollP1 < rollP2)
                    {
                        lose = player1;
                        lblWin.Text = player2.Name + " wins!";
                        btnOK.Enabled = true;
                    }
                    else if (rollP1 > rollP2)
                    {
                        lose = player2;
                        lblWin.Text = player1.Name + " wins!";
                        btnOK.Enabled = true;
                    }
                    else
                    {
                        rollFlag1 = true;
                        rollFlag2 = true;
                        lblWin.Text = "You have tied, roll again.";
                        //pbDice.BackgroundImage = drawBattleDice(gDice, diceBitmap, new Pen(Color.White), new SolidBrush(Color.Black), player1.Power, 0);
                        //pbDiceP2.BackgroundImage = drawBattleDice(gDice, diceBitmap, new Pen(Color.White), new SolidBrush(Color.Black), player2.Power, 0);
                    }
                }
                return;
            }
            Random rand = new Random();
            
            if (dice == 1)
            {
                randNum = rand.Next(DiceNum(player1.Power)) + 1;
                pbDice.Image = drawBattleDice(gDice, diceBitmap, new Pen(Color.White), new SolidBrush(Color.Black), player1.Power, randNum);
            }
            else if (dice == 2)
            {
                randNum = rand.Next(DiceNum(player2.Power)) + 1;
                pbDiceP2.Image = drawBattleDice(gDice, diceBitmap, new Pen(Color.White), new SolidBrush(Color.Black), player2.Power, randNum);
            }
            diceCount++;
        }
        private int DiceNum(int level)
        {
            if (level == 1)
                return 4;
            else if (level == 2)
                return 8;
            else if (level == 3)
                return 16;
            else if (level == 4)
                return 20;
            else
                return 0;
                
        }
    }
}
