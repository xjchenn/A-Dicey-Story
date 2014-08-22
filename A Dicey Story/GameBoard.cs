using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using LevelClass;
using System.Windows.Forms;
namespace SurvivalOfTheLuckiest
{
    public enum DIRECTION
    {
        UP, DOWN, LEFT, RIGHT
    };
    class GameBoard
    {
        List<Player> Players;
        int active;
        int[,] board;
        List<Keys> previousDirection;
        List<bool> skip;
        List<Keys> lastDirection;
        public int Active
        {
            get { return active; }
            set 
            {
                active = value; 
                
            }
        }
        public int Count
        {
            get { return Players.Count; }
        }
        public List<Keys> PreviousDirection
        {
            get { return previousDirection; }
            set { previousDirection = value; }
        }
        public List<Keys> LastDirection
        {
            get { return lastDirection; }
            set { lastDirection = value; }
        }
        public List<bool> Skip
        {
            get { return skip; }
        }
        public GameBoard(List<Player> Players, Level level)
        {
            this.Players = Players;
            this.board = level.getArray();
            active = 0;
            previousDirection = new List<Keys>();
            lastDirection = new List<Keys>();
            skip = new List<bool>();
            foreach (Player player in this.Players)
            {
                previousDirection.Add(Keys.Delete);
                lastDirection.Add(Keys.Delete);
                skip.Add(false);
            }
        }
        public Player this[int i]
        {
            get { return Players[i]; }
            set
            {
                Players[i] = value;
            }
        }
        public int[,] Board
        {
            get { return board; }
        }
        public void Initialize()
        {
            List<Point> startPosition = new List<Point>(4);
            startPosition.Add(new Point(1, 9));
            startPosition.Add(new Point(1, 0));
            startPosition.Add(new Point(7, 0));
            startPosition.Add(new Point(14, 4));

            for (int i = startPosition.Count; i > 1; i--)
            {
                Random rand = new Random();
                int j = rand.Next(i);
                Point tmp = startPosition[j];
                startPosition[j] = startPosition[i - 1];
                startPosition[i - 1] = tmp;
            }
            for (int i = 0; i < Players.Count; i++)
            {
                Players[i].setStartPosition(startPosition[i]);
                if (startPosition[i].X >= 7)
                    Players[i].setAvatar(0);
                else
                    Players[i].setAvatar(1);
            }

        }

        private bool CheckBounds(int x, int y)
        {
            if (x < 0 || x > 14 || y < 0 || y > 9)
                return false;
            return true;
        }
        public bool doRestriction(Point position, Keys Direction)
        {
            if ((int)Direction > 40)
            {
                    if (!CheckMove2(Keys.W) && !CheckMove2(Keys.A) && !CheckMove2(Keys.S) && !CheckMove2(Keys.D))
                    {
                        return false;
                    }
            }
            else
            {
                    if (!CheckMove2(Keys.Up) && !CheckMove2(Keys.Down) && !CheckMove2(Keys.Left) && !CheckMove2(Keys.Right))
                    {
                        return false;
                    }
            }

            return true;
        }
        public bool CheckMove(Keys Direction)
        {
            if(doRestriction(this[active].CurrentPosition,Direction))
            if ((Math.Abs(Direction - previousDirection[active]) == 2 || Math.Abs(Direction - previousDirection[active]) == 3) || (Math.Abs(Direction - previousDirection[active]) == 4))
                return false;
            if ((Direction == Keys.W || Direction == Keys.Up)/*&&(previousDirection[active]!=Keys.S&&previousDirection[active]!=Keys.Down)*/)
            {
                if (CheckBounds(this[Active].CurrentPosition.X, this[Active].CurrentPosition.Y - 1))
                {
                    if (board[this[Active].CurrentPosition.X, this[Active].CurrentPosition.Y - 1] != 1)
                        return true;
                }
            }
            else if ((Direction == Keys.S || Direction == Keys.Down) /*&& (previousDirection[active] != Keys.W && previousDirection[active] != Keys.Up)*/)
            {
                if (CheckBounds(this[Active].CurrentPosition.X, this[Active].CurrentPosition.Y + 1))
                {
                    if (board[this[Active].CurrentPosition.X, this[Active].CurrentPosition.Y + 1] != 1)
                        return true;
                }
            }
            else if ((Direction == Keys.A || Direction == Keys.Left) /*&& (previousDirection[active] != Keys.D && previousDirection[active] != Keys.Right)*/)
            {
                if (CheckBounds(this[Active].CurrentPosition.X - 1, this[Active].CurrentPosition.Y))
                {
                    if (board[this[Active].CurrentPosition.X - 1, this[Active].CurrentPosition.Y] != 1)
                        return true;
                }
            }
            else if ((Direction == Keys.D || Direction == Keys.Right) /*&& (previousDirection[active] != Keys.A && previousDirection[active] != Keys.Left)*/)
            {
                if (CheckBounds(this[Active].CurrentPosition.X + 1, this[Active].CurrentPosition.Y))
                {
                    if (board[this[Active].CurrentPosition.X + 1, this[Active].CurrentPosition.Y] != 1)
                        return true;
                }
            }
            return false;

        }
        public bool CheckMove2(Keys Direction)
        {
            if ((Math.Abs(Direction - previousDirection[active]) == 2 || Math.Abs(Direction - previousDirection[active]) == 3) || (Math.Abs(Direction - previousDirection[active]) == 4))
                return false;
            if ((Direction == Keys.W || Direction == Keys.Up)/*&&(previousDirection[active]!=Keys.S&&previousDirection[active]!=Keys.Down)*/)
            {
                if (CheckBounds(this[Active].CurrentPosition.X, this[Active].CurrentPosition.Y - 1))
                {
                    if (board[this[Active].CurrentPosition.X, this[Active].CurrentPosition.Y - 1] != 1)
                        return true;
                }
            }
            else if ((Direction == Keys.S || Direction == Keys.Down) /*&& (previousDirection[active] != Keys.W && previousDirection[active] != Keys.Up)*/)
            {
                if (CheckBounds(this[Active].CurrentPosition.X, this[Active].CurrentPosition.Y + 1))
                {
                    if (board[this[Active].CurrentPosition.X, this[Active].CurrentPosition.Y + 1] != 1)
                        return true;
                }
            }
            else if ((Direction == Keys.A || Direction == Keys.Left) /*&& (previousDirection[active] != Keys.D && previousDirection[active] != Keys.Right)*/)
            {
                if (CheckBounds(this[Active].CurrentPosition.X - 1, this[Active].CurrentPosition.Y))
                {
                    if (board[this[Active].CurrentPosition.X - 1, this[Active].CurrentPosition.Y] != 1)
                        return true;
                }
            }
            else if ((Direction == Keys.D || Direction == Keys.Right) /*&& (previousDirection[active] != Keys.A && previousDirection[active] != Keys.Left)*/)
            {
                if (CheckBounds(this[Active].CurrentPosition.X + 1, this[Active].CurrentPosition.Y))
                {
                    if (board[this[Active].CurrentPosition.X + 1, this[Active].CurrentPosition.Y] != 1)
                        return true;
                }
            }
            return false;

        }
        public bool OtherPlayers(Player player)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (i == active)
                    continue;
                if (this[i].CurrentPosition == player.CurrentPosition)
                    return true;
            }
            return false;
        }
        public Player GetOtherPlayer(Player player)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (i == active)
                    continue;
                if (this[i].CurrentPosition == player.CurrentPosition)
                    return this[i];
            }
            return player;
        }
        public void Move(Keys Direction, int moveCount)
        {
            if (Direction == Keys.W || Direction == Keys.Up)
            {
                this[active].Y--;
            }
            else if (Direction == Keys.S || Direction == Keys.Down)
            {
                this[active].Y++;
            }
            else if (Direction == Keys.A || Direction == Keys.Left)
            {
                this[active].X--;
                this[active].setAvatar(0);
            }
            else if (Direction == Keys.D || Direction == Keys.Right)
            {
                this[active].X++;
                this[active].setAvatar(1);
            }
            if (moveCount == 1)
            {
                previousDirection[active] = Keys.Delete;
                lastDirection[active] = Direction;
            }
            else
                previousDirection[active] = Direction;

        }
        


    }
}
