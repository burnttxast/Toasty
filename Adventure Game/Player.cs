using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class Player
    {
        public string Name;
        public string Discriptor;

        public Player(string name, string discriptor)
        {
        Name = name;
        Discriptor = discriptor;
        }

        public string ReturnName()
        {
            return Name;
        }
    }
}
