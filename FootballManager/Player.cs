using System.Drawing;

namespace PLAYER
{
    using System;
    using System.Collections;
    [Serializable]
    public abstract class Player
    {
        int num;
        string position;
        public int width=75;
        public int height=75;
        public int x=50;
        public int y=50;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }




        public int NUM
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }


        public string POSITION
        {

            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }

        public abstract void Draw(Graphics g);
        public bool IsInside(int xP, int yP)
        {
            return Math.Abs(xP - X) <= width / 2 && Math.Abs(yP - Y) <= height / 2;

        }
    }

        [Serializable]  
                       
        public class PlayerList
        {
        SortedList players;
            public PlayerList()
            {
                players = new SortedList();
            }
            public int NextIndex
            {
                get
                {
                    return players.Count;
                }
               
            }
            public Player this[int index]
            {
                get
                {
                      if (index >= players.Count)
                              return null;
                    //SortedList internal method
                    return (Player)players.GetByIndex(index);
                }
                set
                {
                    if (index <= players.Count)
                        players[index] = value;		
                }
            }
        public void Remove(int element)
        {
            if (element >= 0 && element < players.Count)
            {
                for (int i = element; i < players.Count - 1; i++)
                    players[i] = players[i + 1];
                players.RemoveAt(players.Count - 1);
            }
        }

        
        public void DrawAll(Graphics g)
        {
            for (int i = 0; i < players.Count; i++)
                ((Player)players[i]).Draw(g);
        }

    }
    
}