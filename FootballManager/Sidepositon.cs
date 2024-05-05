using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSITIONS;
using System.Drawing;
using PLAYER;

namespace FootballManager
{
    [Serializable]
    class Deffend : FieldPostion
    {
        public Deffend (int num,string postion,string side)
            {
            this.NUM = num;
            this.SIDE = side;
            this.POSITION = postion;
            this.Y = 500;
            this.X = 200;

            }

        public override void Draw(Graphics g)
        {
            
                SolidBrush br = new SolidBrush(Color.Blue);
                Pen pen = new Pen(Color.White, 2);
                g.FillRectangle(br, X - width / 2, Y - height / 2, width, height);
                g.DrawRectangle(pen, X - width / 2, Y - height / 2, width, height);
                Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                Font font2 = new Font("Arial", 40, FontStyle.Bold, GraphicsUnit.Point);
                string text1 = @"" + this.SIDE + this.POSITION;
                string text2 = @"" + this.NUM + "\n";
                if (this.NUM < 10)
                {
                    g.DrawString(text2, font2, Brushes.White, X - width / 4 - 4, Y - height / 4);
                }
                else
                {
                    g.DrawString(text2, font2, Brushes.White, X - width / 4 - 19, Y - height / 4);

                }
                g.DrawString(text1, font1, Brushes.White, X - width / 4 + 4, Y - height / 2 + 2);

            }
    }
    [Serializable]
    class Midfielder : FieldPostion
    {
        public Midfielder(int num, string position,  string side)
        {
            this.NUM = num;
            this.POSITION = position;
            this.SIDE = side;
            this.Y = 338;
            this.X = 200;
        }
        public override void Draw(Graphics g)
            {
                SolidBrush br = new SolidBrush(Color.Green);
                Pen pen = new Pen(Color.White, 2);
                g.FillRectangle(br, X - width / 2, Y - height / 2, width, height);
                g.DrawRectangle(pen, X - width / 2, Y - height / 2, width, height);
                Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                Font font2 = new Font("Arial", 40, FontStyle.Bold, GraphicsUnit.Point);
                string text1 = @"" + this.SIDE + this.POSITION;
                string text2 = @"" + this.NUM + "\n";
                if (this.NUM < 10)
                {
                    g.DrawString(text2, font2, Brushes.White, X - width / 4 - 4, Y - height / 4);
                }
                else
                {
                    g.DrawString(text2, font2, Brushes.White, X - width / 4 - 19, Y - height / 4);

                }
                g.DrawString(text1, font1, Brushes.White, X - width / 4 + 4, Y - height / 2 + 2);

            }

    }
    [Serializable]
    class Striker : FieldPostion
    {
        public Striker(int num, string position, string side)
        {
            this.NUM = num;
            this.POSITION = position;
            this.SIDE = side;
            this.Y = 178;
            this.X = 200;
        }
        public override void Draw(Graphics g)
        {
            {
                SolidBrush br = new SolidBrush(Color.Red);
                Pen pen = new Pen(Color.White, 2);
                g.FillRectangle(br, X - width / 2, Y - height / 2, width, height);
                g.DrawRectangle(pen, X - width / 2, Y - height / 2, width, height);
                Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                Font font2 = new Font("Arial", 40, FontStyle.Bold, GraphicsUnit.Point);
                string text1 = @"" + this.SIDE + this.POSITION;
                string text2 = @"" + this.NUM + "\n";
                if (this.NUM < 10)
                {
                    g.DrawString(text2, font2, Brushes.White, X - width / 4 - 4, Y - height / 4);
                }
                else
                {
                    g.DrawString(text2, font2, Brushes.White, X - width / 4 - 19, Y - height / 4);

                }
                g.DrawString(text1, font1, Brushes.White, X - width / 4 + 4, Y - height / 2 + 2);

            }

        }
    }
}


