using System;
using System.Collections.Generic;
using System.Text;

namespace RoomsGame
{
    class Player
    {
        public string Name { get; set; }
        public int Life { get; set; }

        public Player(string aName, int aLife)
        {
            Name = aName;
            Life = aLife;
        }
    }
}
