using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLAYER;
using System.Drawing;


namespace POSITIONS
{
    [Serializable]
    public class GoalkeeperPostion : Player
    {
        public GoalkeeperPostion (int num)
        {
            this.NUM = num;
            this.X = 300;
            this.Y = 600;
            this.POSITION = "GK";
        }

        public override void Draw(Graphics g)
        {
            {
                SolidBrush br = new SolidBrush(Color.Black);
                Pen pen = new Pen(Color.White, 2);
                g.FillRectangle(br, X - width / 2, Y - height / 2, width, height);
                g.DrawRectangle(pen, X - width / 2, Y - height / 2, width, height);
                Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                Font font2 = new Font("Arial", 40, FontStyle.Bold, GraphicsUnit.Point);
                string text1 = @"" +this.POSITION;
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
[Serializable]
public abstract class FieldPostion : Player
{
    string side;
    public string SIDE
    {

        get
        {
            return side;
        }
        set
        {
            side = value;
        }

    }


}
