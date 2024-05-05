using System;
using System.Drawing;
using System.Windows.Forms;
using PLAYER;
using POSITIONS;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FootballManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PlayerList pts = new PlayerList();
        int PlayerCount = 0, goalkeepers = 0, curIndex = -1,i;
        bool flag = true;


    private void button1_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
        saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
        saveFileDialog1.FilterIndex = 1;
        saveFileDialog1.RestoreDirectory = true;
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            IFormatter formatter = new BinaryFormatter();
            IFormatter formatter1 = new BinaryFormatter();
            IFormatter formatter2 = new BinaryFormatter();

            using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))

            {
                //!!!!
                formatter.Serialize(stream, pts);
                formatter1.Serialize(stream, goalkeepers);
                formatter2.Serialize(stream, PlayerCount);

            }

        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
        openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
        openFileDialog1.FilterIndex = 1;
        openFileDialog1.RestoreDirectory = true;
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
           
             pts = (PlayerList)binaryFormatter.Deserialize(stream);
            goalkeepers = (int)binaryFormatter.Deserialize(stream);
            PlayerCount = (int)binaryFormatter.Deserialize(stream);
            pictureBox1.Invalidate();
        }
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        pts.DrawAll(g);
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        curIndex = -1;
    }

    private void New_Player_Click(object sender, EventArgs e)
    {
        if (Position_txt.Text == "")
        {
            MessageBox.Show("You have to enter position!");
        }
        else
            for (i = 0; i < pts.NextIndex; i++)
            {
                if (Convert.ToInt32(Num_txt.Text) == pts[i].NUM)
                {
                    MessageBox.Show("You already used that number!");
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
        if (flag)
        {
            if (PlayerCount == 11)
            {
                MessageBox.Show("You cant add more than 11 players!");
            }
            else
            {
                if (Position_txt.Text == "GoalKeeper")
                {
                    if (goalkeepers != 0)
                    {
                        MessageBox.Show("You can have only one goalkeeper!");
                    }

                    else if (Side_txt.Text != " " && Side_txt.Text != "")
                    {
                        MessageBox.Show("GoalKeeper has no side!");
                    }
                    else if (Num_txt.Text == "")
                    {
                        MessageBox.Show("You have to enter number!");
                    }
                    else
                    {
                        if (goalkeepers == 0 && flag)
                        {
                            pts[pts.NextIndex] = new GoalkeeperPostion(Convert.ToInt32(Num_txt.Text));
                            goalkeepers++;
                            PlayerCount++;
                        }
                    }
                }
                if (Position_txt.Text == "Defender")
                {
                    if (PlayerCount == 10 && goalkeepers == 0)
                    {
                        MessageBox.Show("You must have at least one GoalKeeper!");
                    }
                    else if (Side_txt.Text == "" || Side_txt.Text == " ")
                    {
                        MessageBox.Show("You have to choose side!");
                    }
                    else
                    {
                        {
                                if (Num_txt.Text == "")
                                {
                                    MessageBox.Show("You have to choose number!");
                                }
                                else
                                {
                                    pts[pts.NextIndex] = new Deffend(Convert.ToInt32(Num_txt.Text), "B", Side_txt.Text);
                                    PlayerCount++;
                                }
                        }
                    }
                }

                if (Position_txt.Text == "Midfielder")
                {
                    if (PlayerCount == 10 && goalkeepers == 0)
                    {
                        MessageBox.Show("You must have at least one GoalKeeper!");
                    }
                    else if (Side_txt.Text == "" || Side_txt.Text == " ")
                    {
                        MessageBox.Show("You have to choose side!");
                    }
                    else
                    {
                            if (Num_txt.Text == "")
                            {
                                MessageBox.Show("You have to choose number!");
                            }
                            else
                            {
                                pts[pts.NextIndex] = new Midfielder(Convert.ToInt32(Num_txt.Text), "M", Side_txt.Text);
                                PlayerCount++;
                            }
                    }
                }
                if (Position_txt.Text == "Striker")
                {
                    if (PlayerCount == 10 && goalkeepers == 0)
                    {
                        MessageBox.Show("You must have at least one GoalKeeper!");
                    }
                    else if (Side_txt.Text == "" || Side_txt.Text == " ")
                    {
                        MessageBox.Show("You have to choose side!");
                    }
                    else
                    {
                            if (Num_txt.Text == "")
                            {
                                MessageBox.Show("You have to choose number!");
                            }
                            else
                            {
                                pts[pts.NextIndex] = new Striker(Convert.ToInt32(Num_txt.Text), "S", Side_txt.Text);
                                PlayerCount++;
                            }
                    }

                }
                curIndex = pts.NextIndex - 1;
                pictureBox1.Invalidate();
            }
        }
    }
    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        curIndex = -1;
        for (int i = 0; i < pts.NextIndex; i++)
        {
            if (pts[i].IsInside(e.X, e.Y))
            {
                curIndex = i;
                string s = e.Button.ToString();
                if (s == "Right") //if Right button pressed - Remove
                {
                    if (pts[curIndex].POSITION == "GK")
                    {
                        goalkeepers--;
                    }
                    PlayerCount--;
                    pts.Remove(curIndex);
                    curIndex = -1;
                    pictureBox1.Invalidate();
                    return;
                }
                break;
            }
        }
    }
    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
        if (curIndex >= 0)
        {
            Player c = pts[curIndex];
            if (e.X >= 547)
            {
                c.X = 547;
            }
            else if (e.X <= 63)
            {
                c.X = 63;
            }
            else
                c.X = e.X;//x
            if (c.POSITION == "GK")
            {
                if (e.Y >= 618)
                    c.Y = 618;
                else if (e.Y <= 590)
                    c.Y = 590;
                else
                    c.Y = e.Y;
                    if (e.X <= 167)
                        c.X = 167;
                    else if (e.X >= 443)
                        c.X = 443;
                    else
                        c.X = e.X;
            }
            if (c.POSITION == "M")
            {
                if (e.Y >= 516)
                    c.Y = 516;
                else if (e.Y <= 160)
                    c.Y = 160;
                else
                    c.Y = e.Y;
            }
            if (c.POSITION == "S")
            {
                if (e.Y >= 300)
                    c.Y = 300;
                else if (e.Y <= 55)
                    c.Y = 55;
                else
                    c.Y = e.Y;
            }
            if (c.POSITION == "B")
            {
                if (e.Y >= 618)
                    c.Y = 618;
                else if (e.Y <= 375)
                    c.Y = 375;
                else
                    c.Y = e.Y;
            }
            pictureBox1.Invalidate();
        }
    }
}
}

   
