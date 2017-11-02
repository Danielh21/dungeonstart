using System;
using System.Collections.Generic;
using System.Text;

namespace RoomsGame
{
    class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Room LeftNeighbor { get; set; }
        public Room RightNeighbor { get; set; }

        public Room(string aName, string aDescription)
        {
            Name = aName;
            Description = aDescription;
        }
    }
}
