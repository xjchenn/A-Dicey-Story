using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
namespace SurvivalOfTheLuckiest
{
    public class Player
    {
        Bitmap avatar;
        Point startPosition;
        Point currentPosition;
        int avatarnumber;
        string name;
        int power;
        public int Power
        {
            get { return power; }
            set
            {
                if (value < 1)
                {
                    power = 1;
                }
                else if (value > 4)
                {
                    power = 4;
                }
                else
                    power = value;
            }
        }
        public Bitmap Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }
        public int AvatarNumber
        {
            get { return avatarnumber; }
            set { avatarnumber = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Point StartPosition
        {
            get { return startPosition; }
            set { startPosition = value; }
        }
        public Point CurrentPosition
        {
            get { return currentPosition; }
            set { currentPosition = value; }
        }
        public int X
        {
            get { return currentPosition.X; }
            set { currentPosition.X = value; }
        }
        public int Y
        {
            get { return currentPosition.Y; }
            set { currentPosition.Y = value; }
        }
        public Player(string name, int avatarnumber)
        {
            this.name = name;
            this.avatarnumber = avatarnumber;
            this.Power = 1;
        }
        public void setStartPosition(Point start)
        {
            startPosition = start;
            currentPosition = startPosition;
        }
        public void setAvatar(int direction)
        {
            if (direction == 0)
            {
                switch (avatarnumber)
                {
                    case 0:
                        avatar = new Bitmap(Image.FromFile(@"Sprites\a1.png"));
                        break;
                    case 1:
                        avatar = new Bitmap(Image.FromFile(@"Sprites\m1.png"));
                        break;
                    case 2:
                        avatar = new Bitmap(Image.FromFile(@"Sprites\t1.png"));
                        break;
                    case 3:
                        avatar = new Bitmap(Image.FromFile(@"Sprites\w1.png"));
                        break;
                    case 4:
                        avatar = new Bitmap(Image.FromFile(@"manondragon.png"));
                        break;
                }
            }
            else if (direction == 1)
            {
                switch (avatarnumber)
                {
                    case 0:
                        avatar = new Bitmap(Image.FromFile(@"Sprites\a5.png"));
                        break;
                    case 1:
                        avatar = new Bitmap(Image.FromFile(@"Sprites\m5.png"));
                        break;
                    case 2:
                        avatar = new Bitmap(Image.FromFile(@"Sprites\t5.png"));
                        break;
                    case 3:
                        avatar = new Bitmap(Image.FromFile(@"Sprites\w5.png"));
                        break;
                    case 4:
                        avatar = new Bitmap(Image.FromFile(@"manondragon.png"));
                        break;
                }
            }

        }
        public Bitmap getAvatar(int direction)
        {
            if (direction == -1)
            {
                switch (avatarnumber)
                {
                    case 0:
                        return new Bitmap(Image.FromFile(@"Sprites\ag.png"));
                    case 1:
                        return new Bitmap(Image.FromFile(@"Sprites\mg.png"));
                    case 2:
                        return new Bitmap(Image.FromFile(@"Sprites\tg.png"));
                    default:
                        return new Bitmap(Image.FromFile(@"Sprites\wg.png"));

                }
            }
            if (direction == 0)
            {
                switch (avatarnumber)
                {
                    case 0:
                        return new Bitmap(Image.FromFile(@"Sprites\a1.png"));
                    case 1:
                        return new Bitmap(Image.FromFile(@"Sprites\m1.png"));
                    case 2:
                        return new Bitmap(Image.FromFile(@"Sprites\t1.png"));
                    case 4:
                        return new Bitmap(Image.FromFile(@"manondragon.png"));
                    default:
                        return new Bitmap(Image.FromFile(@"Sprites\w1.png"));

                }
            }
            else
            {
                switch (avatarnumber)
                {
                    case 0:
                        return new Bitmap(Image.FromFile(@"Sprites\a5.png"));
                    case 1:
                        return new Bitmap(Image.FromFile(@"Sprites\m5.png"));
                    case 2:
                        return new Bitmap(Image.FromFile(@"Sprites\t5.png"));
                    default:
                        return new Bitmap(Image.FromFile(@"Sprites\w5.png"));

                }
            }

        }
    }
}
