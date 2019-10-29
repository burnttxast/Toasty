using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class Item
    {
        string Name;
        string Details;

        public Item(string name, string details)
        {
            Name = name;
            Details = details;
        }

        public string returnName()
        {
            return Name;
        }

        public string returnDetails()
        {
            return Details;
        }
    }
}
