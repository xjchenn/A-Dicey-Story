using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LevelClass;
namespace SurvivalOfTheLuckiest
{
    public partial class FormGameBoard : Form
    {
        List<Player> players;
        GameBoard GameBoard;
        Level MainLevel;
        FormEvent FormEvent;
        float width_ratio;
        float height_ratio;
        Graphics gDraw;
        Bitmap mainBitmap;
        Bitmap diceBitmap;
        Bitmap displayBitmap;
        Graphics gDisplay;
        Graphics gDice;
        int timerCount = 0;
        bool MoveFlag = false;
        bool RollFlag = true;
        int moveCount = 0;
        int randNum = 0;
        int numTurns = 1;
        bool dragonsword = true;
        int[] Lose;
        int[] Battle;
        public FormGameBoard(List<Player> players)
        {
            InitializeComponent();
            float screenWidth = Screen.PrimaryScreen.Bounds.Width;
            float screenHeight = Screen.PrimaryScreen.Bounds.Height;
            //screenWidth = 1920;
            //screenHeight = 1080;
            width_ratio = (screenWidth / this.Width);
            height_ratio = (screenHeight / this.Height);
            SizeF scale = new SizeF(width_ratio, height_ratio);

            foreach (Control control in this.Controls)
            {
                control.Scale(scale);
            }
            foreach (Control control in this.Controls)
            {
                control.Font = new Font(control.Font.Name, control.Font.SizeInPoints * height_ratio * width_ratio, control.Font.Style);
            }
            this.players = players;
            MainLevel = new Level();
            GameBoard = new GameBoard(players, MainLevel);
            GameBoard.Initialize();
            mainBitmap = new Bitmap(pbMain.Width, pbMain.Height);
            gDraw = Graphics.FromImage(mainBitmap);
            diceBitmap = new Bitmap(pbDice.Width, pbDice.Height);
            gDice = Graphics.FromImage(diceBitmap);
            displayBitmap = new Bitmap(pbPlayers.Width, pbPlayers.Height);
            gDisplay = Graphics.FromImage(displayBitmap);
            Lose = new int[GameBoard.Count];
            Battle = new int[GameBoard.Count];
            //FormEvent FormEvent = new FormEvent(12);
            //FormEvent.StartPosition = FormStartPosition.CenterScreen;
            //*************************//
        }
        private void FormGameBoard_Load(object sender, EventArgs e)
        {
            MainLevel.Read(@"FinalLevel.lvl");
            RefreshPlayers();
            Random rand = new Random();
            int randNum = rand.Next(6) + 1;
            NextTurn(GameBoard[GameBoard.Active]);
            //Player player1 = new Player("Player 1", 1);
            //Player player2 = new Player("Player 2", 2);
            //player1.Power = 1;
            //player2.Power = 2;
            //FormBattle formBattle = new FormBattle(player1,player2);
            //formBattle.ShowDialog();
            foreach (Control control in panelPlayer.Controls)
            {
                control.Font = new Font(control.Font.Name, control.Font.SizeInPoints * height_ratio * width_ratio, control.Font.Style);
            }
            FormStory FormStory = new FormStory();
            FormStory.StartPosition = FormStartPosition.CenterScreen;
            FormStory.ShowDialog();
        }
        public void RefreshPlayers()
        {
            Bitmap BackgroundImage = (Bitmap)pbMain.BackgroundImage;
            using (Graphics g = Graphics.FromImage(BackgroundImage))
            {
                g.DrawImage(MainLevel.GetImage(), 0, 0);
            }
            pbMain.BackgroundImage = BackgroundImage;
            gDraw.Clear(Color.Transparent);
            for (int i = 0; i < players.Count; i++)
            {
                if (GameBoard[i].CurrentPosition.X == 6 && GameBoard[i].CurrentPosition.Y == 3)
                    gDraw.DrawImage(GameBoard[i].Avatar, GameBoard[i].CurrentPosition.X * (pbMain.Width / 15), (GameBoard[i].CurrentPosition.Y * (pbMain.Height / 10)) - 20, GameBoard[i].Avatar.Width * 0.85f * width_ratio, GameBoard[i].Avatar.Height * 0.85f * height_ratio);
                else
                    gDraw.DrawImage(GameBoard[i].Avatar, GameBoard[i].CurrentPosition.X * (pbMain.Width / 15), GameBoard[i].CurrentPosition.Y * (pbMain.Height / 10), GameBoard[i].Avatar.Width * 0.85f * width_ratio, GameBoard[i].Avatar.Height * 0.85f * height_ratio);
            }
            pbMain.Image = mainBitmap;
        }
        public void NextTurn(Player player)
        {
            lblName.Text = player.Name;
            lblName.Font = new Font(lblName.Font.Name, lblName.Font.Size, lblName.Font.Style);
            Bitmap Avatar = player.getAvatar(0);
            pbAvatar.Size = new Size((int)(Avatar.Size.Width * 6 / 5 * width_ratio), (int)(Avatar.Size.Height * 6 / 5 * height_ratio));
            pbAvatar.BackgroundImage = Avatar;
            pbDice.Image = drawDice(gDice, diceBitmap, (int)(5 * (width_ratio + height_ratio) / 2), new Pen(Color.Black), new SolidBrush(Color.Black), 0);
            Bitmap power = new Bitmap(Image.FromFile("power" + player.Power + ".png"));
            pbPower.BackgroundImage = power;
            lblPower.Font = new Font(lblPower.Font.Name, lblPower.Font.Size, lblPower.Font.Style);
            lblPower.Text = "Power: " + player.Power + "/4";
            for (int i = 0; i < GameBoard.Count; i++)
            {
                Bitmap currentAvatar;
                if (i == GameBoard.Active)
                    currentAvatar = GameBoard[i].getAvatar(1);
                else
                    currentAvatar = GameBoard[i].getAvatar(-1);
                if (GameBoard[i].AvatarNumber == 3)
                    gDisplay.DrawImage(currentAvatar, 25 * width_ratio, (i * 72 + 20 + i * 15) * height_ratio, 65 * width_ratio, 72 * height_ratio);
                else if (GameBoard[i].AvatarNumber == 1)
                    gDisplay.DrawImage(currentAvatar, 8 * width_ratio, (i * 72 + 20 + i * 15) * height_ratio, 60 * width_ratio, 72 * height_ratio);
                else if (GameBoard[i].AvatarNumber == 0)
                    gDisplay.DrawImage(currentAvatar, 10 * width_ratio, (i * 72 + 20 + i * 15) * height_ratio, 65 * width_ratio, 72 * height_ratio);
                else
                    gDisplay.DrawImage(currentAvatar, 15 * width_ratio, (i * 72 + 15 + i * 15) * height_ratio, 60 * width_ratio, 72 * height_ratio);
                gDisplay.DrawString(GameBoard[i].Name, new Font("Times New Roman", 14 * (width_ratio + height_ratio) / 2, FontStyle.Regular), new SolidBrush(Color.Black), 80 * width_ratio, (i * 72 + 20 + i * 15) * height_ratio);
                gDisplay.DrawImage(Image.FromFile("power" + GameBoard[i].Power + ".png"), 80 * width_ratio, ((i * 72 + 20 + i * 15) + 20) * height_ratio, 70 * width_ratio, 20 * height_ratio);
            }
            pbPlayers.Image = displayBitmap;
            //width_ratio = 1;
            //height_ratio = 1;
        }
        Bitmap drawDice(Graphics gDice, Bitmap diceBitmap, int iDiceDistance, Pen myPen, Brush myBrush, int randNum)
        {
            gDice.Clear(Color.White);

            gDice.FillRectangle(new SolidBrush(Color.Red), 0, 0, pbDice.Width - 1, pbDice.Height - 1);
            gDice.DrawRectangle(myPen, 0, 0, pbDice.Width - 1, pbDice.Height - 1);
            if (randNum == 1 || randNum == 3 || randNum == 5)
            {
                gDice.FillEllipse(myBrush, pbDice.Width / 2 - iDiceDistance, pbDice.Height / 2 - iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                if (randNum == 3 || randNum == 5)
                {
                    gDice.FillEllipse(myBrush, iDiceDistance, pbDice.Height - 3 * iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                    gDice.FillEllipse(myBrush, pbDice.Width - 3 * iDiceDistance, iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                    if (randNum == 5)
                    {
                        gDice.FillEllipse(myBrush, iDiceDistance, iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                        gDice.FillEllipse(myBrush, pbDice.Width - 3 * iDiceDistance, pbDice.Height - 3 * iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                    }
                }

            }
            if (randNum == 2 || randNum == 4 || randNum == 6)
            {
                gDice.FillEllipse(myBrush, iDiceDistance, iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                gDice.FillEllipse(myBrush, pbDice.Width - 3 * iDiceDistance, pbDice.Height - 3 * iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                if (randNum == 4 || randNum == 6)
                {
                    gDice.FillEllipse(myBrush, iDiceDistance, pbDice.Height - 3 * iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                    gDice.FillEllipse(myBrush, pbDice.Width - 3 * iDiceDistance, iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                    if (randNum == 6)
                    {
                        gDice.FillEllipse(myBrush, pbDice.Width / 2 - iDiceDistance, iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                        gDice.FillEllipse(myBrush, pbDice.Width / 2 - iDiceDistance, pbDice.Height - 3 * iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                    }
                }

            }
            if (randNum == 0)
            {
                gDice.DrawString("Roll", new Font("Times New Roman", 14 * (width_ratio + height_ratio) / 2, FontStyle.Italic), new SolidBrush(Color.Black), iDiceDistance * width_ratio, pbDice.Height / 2 - 2 * iDiceDistance * height_ratio);
            }
            return diceBitmap;
        }
        private void timerDice_Tick(object sender, EventArgs e)
        {

            if (timerCount > 15)
            {
                
                timerDice.Stop();
                timerCount = 0;
                moveCount = randNum;
                MoveFlag = true;
                RollFlag = false;
                //************************************************
                return;
            }
            Random rand = new Random();
            randNum = rand.Next(6) + 1;
            pbDice.Image = drawDice(gDice, diceBitmap, (int)(5 * (width_ratio + height_ratio) / 2), new Pen(Color.Black), new SolidBrush(Color.Black), randNum);
            timerCount++;

        }
        private void pbDice_Click_1(object sender, EventArgs e)
        {
            if (RollFlag)
                timerDice.Start();
        }
        public Keys SameDirection(Keys direction)
        {
            switch (direction)
            {
                //case Keys.Up:
                //    return Keys.Up;
                //case Keys.Down:
                //    return Keys.Down;
                //case Keys.Left:
                //    return Keys.Left;
                //case Keys.Right:
                //    return Keys.Right;
                case Keys.W:
                    return Keys.W;
                case Keys.S:
                    return Keys.S;
                case Keys.A:
                    return Keys.A;
                case Keys.D:
                    return Keys.D;
                default:
                    return Keys.Delete;

            }
        }
        public Keys OppositeDirection(Keys direction)
        {
            switch (direction)
            {
                //case Keys.Up:
                //    return Keys.Down;
                //case Keys.Down:
                //    return Keys.Up;
                //case Keys.Left:
                //    return Keys.Right;
                //case Keys.Right:
                //    return Keys.Left;
                case Keys.W:
                    return Keys.S;
                case Keys.S:
                    return Keys.W;
                case Keys.A:
                    return Keys.D;
                case Keys.D:
                    return Keys.A;
                default:
                    return Keys.Delete;

            }
        }
        private void FormGameBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (!MoveFlag)
                return;
            else
            {
                if (GameBoard.CheckMove(e.KeyData))
                {
                    GameBoard.Move(e.KeyData, moveCount);
                    moveCount--;
                }
                else
                {

                    if (GameBoard[GameBoard.Active].CurrentPosition.X == 5 && GameBoard[GameBoard.Active].CurrentPosition.Y == 3 && (e.KeyData == Keys.D || e.KeyData == Keys.Right) && (GameBoard.PreviousDirection[GameBoard.Active] != Keys.A && GameBoard.PreviousDirection[GameBoard.Active] != Keys.Left))
                    {
                        GameBoard[GameBoard.Active].X += 2;
                        GameBoard[GameBoard.Active].setAvatar(1);
                        moveCount--;
                        if (moveCount == 0)
                        {
                            GameBoard.PreviousDirection[GameBoard.Active] = Keys.Delete;
                            GameBoard.LastDirection[GameBoard.Active] = e.KeyData;
                        }
                        else
                            GameBoard.PreviousDirection[GameBoard.Active] = e.KeyData;
                    }
                    if (GameBoard[GameBoard.Active].CurrentPosition.X == 7 && GameBoard[GameBoard.Active].CurrentPosition.Y == 3 && (e.KeyData == Keys.A || e.KeyData == Keys.Left) && (GameBoard.PreviousDirection[GameBoard.Active] != Keys.D && GameBoard.PreviousDirection[GameBoard.Active] != Keys.Right))
                    {
                        GameBoard[GameBoard.Active].X -= 2;
                        GameBoard[GameBoard.Active].setAvatar(0);
                        moveCount--;
                        if (moveCount == 0)
                        {
                            GameBoard.PreviousDirection[GameBoard.Active] = Keys.Delete;
                            GameBoard.LastDirection[GameBoard.Active] = e.KeyData;
                        }
                        else
                            GameBoard.PreviousDirection[GameBoard.Active] = e.KeyData;
                    }
                }

                //dragon
                if (GameBoard[GameBoard.Active].X == 12 && GameBoard[GameBoard.Active].Y == 7)
                {
                    RefreshPlayers();
                    if (DialogResult.Yes == MessageBox.Show("Are you sure you want to fight the dragon? If you lose, you will respawn and lose all your bonus power.", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Player player1 = GameBoard[GameBoard.Active];
                        Player dragon = new Player("Dragon", 4);
                        dragon.setAvatar(0);
                        dragon.Power = 3;
                        FormBattle formBattle = new FormBattle(player1, dragon);
                        formBattle.StartPosition = FormStartPosition.CenterScreen;
                        formBattle.StartPosition = FormStartPosition.CenterScreen;
                        formBattle.ShowDialog();
                        formBattle.Lose.CurrentPosition = formBattle.Lose.StartPosition;
                        formBattle.Lose.Power = 1;
                        if (formBattle.Lose.Name == "Dragon")
                        {
                            FormWinner FormWinner = new FormWinner(GameBoard[GameBoard.Active].Name);
                            FormWinner.StartPosition = FormStartPosition.CenterScreen;
                            FormWinner.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            formBattle.Lose.CurrentPosition = formBattle.Lose.StartPosition;
                            formBattle.Lose.Power = 1;

                            RefreshPlayers();
                        }
                    }
                    moveCount = 0;
                    MoveFlag = false;
                    RollFlag = true;
                    if (GameBoard.Active == GameBoard.Count-1)
                    {
                        numTurns++;
                    }
                    if (GameBoard.Active + 1 == GameBoard.Count)
                        GameBoard.Active = 0;
                    else
                        GameBoard.Active++;
                    //skip the players turn if necessary
                    while (GameBoard.Skip[GameBoard.Active])
                    {
                        if (GameBoard.Active == GameBoard.Count-1)
                        {
                            numTurns++;
                        }
                        GameBoard.Skip[GameBoard.Active] = false;
                        if (GameBoard.Active + 1 == GameBoard.Count)
                        {
                            GameBoard.Active = 0;
                        }
                        else
                            GameBoard.Active++;
                    }
                    NextTurn(GameBoard[GameBoard.Active]);
                    if (autoRollToolStripMenuItem.Checked)
                        pbDice_Click_1(sender, e);
                    return;
                }

                if (moveCount <= 0)
                {
                    RefreshPlayers();
                    Point currentPosition = GameBoard[GameBoard.Active].CurrentPosition;
                    //other player
                    if (GameBoard.OtherPlayers(GameBoard[GameBoard.Active]))
                    {
                        Player player1 = GameBoard.GetOtherPlayer(GameBoard[GameBoard.Active]);
                        Player player2 = GameBoard[GameBoard.Active];
                        Battle[GameBoard.Active]++;
                        for (int i = 0; i < GameBoard.Count; i++)
                        {
                            if (i == GameBoard.Active)
                                continue;
                            if (GameBoard[i].CurrentPosition == GameBoard[GameBoard.Active].CurrentPosition)
                            {
                                Battle[i]++;
                                break;
                            }
                        }
                        FormBattle formBattle = new FormBattle(player1, player2);
                        formBattle.StartPosition = FormStartPosition.CenterScreen;
                        formBattle.ShowDialog();

                        Lose[GameBoard.Active]++;
                        formBattle.Lose.CurrentPosition = formBattle.Lose.StartPosition;
                        formBattle.Lose.Power = 1;
                        currentPosition = GameBoard[GameBoard.Active].CurrentPosition;
                        //count battles lost
                        for (int i = 0; i < GameBoard.Count; i++)
                        {
                            if (GameBoard[i] == formBattle.Lose)
                                Lose[i]++;
                        }
                    }
                    RefreshPlayers();
                    //powerups
                    if (GameBoard.Board[currentPosition.X, currentPosition.Y] == 2)
                    {
                        Random rand = new Random();
                        int eventnumber = rand.Next(17);
                        FormEvent = new FormEvent(eventnumber, dragonsword, GameBoard[GameBoard.Active].Power);
                        FormEvent.StartPosition = FormStartPosition.CenterScreen;
                        FormEvent.ShowDialog();
                        if (eventnumber < 5)
                        {
                            GameBoard[GameBoard.Active].Power++;
                        }
                        else if (eventnumber == 5 || eventnumber == 6)
                        {
                            GameBoard[GameBoard.Active].Power--;
                        }
                        else if (eventnumber == 7)
                        {
                            if (dragonsword == true)
                            {
                                GameBoard[GameBoard.Active].Power += 2;
                                dragonsword = false;
                            }
                            else
                            {
                                GameBoard[GameBoard.Active].Power++;
                            }
                        }
                        else if (eventnumber == 8 || eventnumber == 9) //roll again
                        {
                            if (GameBoard.Active - 1 < 0)
                                GameBoard.Active = GameBoard.Count - 1;
                            else
                                GameBoard.Active--;
                            if (GameBoard.Active == GameBoard.Count - 1)
                                numTurns--;

                        }
                        else if (eventnumber == 10) //lose next turn
                        {
                            GameBoard.Skip[GameBoard.Active] = true;
                        }
                        else if (eventnumber == 11) //advance 1
                        {
                            moveCount = 1;
                            GameBoard.PreviousDirection[GameBoard.Active] = SameDirection(GameBoard.LastDirection[GameBoard.Active]);
                            pbDice.Image = drawDice(gDice, diceBitmap, 5, new Pen(Color.Black), new SolidBrush(Color.Black), 1);
                            return;
                        }
                        else if (eventnumber == 12) //go back 2
                        {
                            moveCount = 2;
                            GameBoard.PreviousDirection[GameBoard.Active] = OppositeDirection(GameBoard.LastDirection[GameBoard.Active]);
                            pbDice.Image = drawDice(gDice, diceBitmap, 5, new Pen(Color.Black), new SolidBrush(Color.Black), 2);
                            return;
                        }
                        else if (eventnumber == 13) //go back 1
                        {
                            moveCount = 1;
                            GameBoard.PreviousDirection[GameBoard.Active] = OppositeDirection(GameBoard.LastDirection[GameBoard.Active]);
                            pbDice.Image = drawDice(gDice, diceBitmap, 5, new Pen(Color.Black), new SolidBrush(Color.Black), 1);
                            return;
                        }
                        else if (eventnumber == 14) //advance 2
                        {
                            moveCount = 2;
                            GameBoard.PreviousDirection[GameBoard.Active] = SameDirection(GameBoard.LastDirection[GameBoard.Active]);
                            pbDice.Image = drawDice(gDice, diceBitmap, 5, new Pen(Color.Black), new SolidBrush(Color.Black), 2);
                            return;
                        }
                        else if (eventnumber == 15) //respawn
                        {
                            players[GameBoard.Active].CurrentPosition = players[GameBoard.Active].StartPosition;
                            RefreshPlayers();
                        }
                        else //lose next turn, +1 power
                        {
                            players[GameBoard.Active].Power++;
                            GameBoard.Skip[GameBoard.Active] = true;
                        }
                    }
                    MoveFlag = false;
                    RollFlag = true;
                    if (GameBoard.Active == GameBoard.Count-1)
                    {
                        numTurns++;
                    }
                    if (GameBoard.Active + 1 == GameBoard.Count)
                        GameBoard.Active = 0;
                    else
                        GameBoard.Active++;
                    //skip the players turn if necessary
                    while (GameBoard.Skip[GameBoard.Active])
                    {
                        if (GameBoard.Active == GameBoard.Count-1)
                        {
                            numTurns++;
                        }
                        GameBoard.Skip[GameBoard.Active] = false;
                        if (GameBoard.Active + 1 == GameBoard.Count)
                        {
                            GameBoard.Active = 0;

                        }
                        else
                            GameBoard.Active++;
                    }
                    NextTurn(GameBoard[GameBoard.Active]);
                    if (autoRollToolStripMenuItem.Checked)
                        pbDice_Click_1(sender, e);
                    return;
                }
                RefreshPlayers();
            }
        }

        private void timerAnimate_Tick(object sender, EventArgs e)
        {

        }

        private void autoRollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autoRollToolStripMenuItem.Checked == true)
                autoRollToolStripMenuItem.Checked = false;
            else
                autoRollToolStripMenuItem.Checked = true;
        }
    }
}
