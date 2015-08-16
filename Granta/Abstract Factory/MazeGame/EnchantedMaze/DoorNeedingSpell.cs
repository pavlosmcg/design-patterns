using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGame.EnchantedMaze
{
    public class DoorNeedingSpell: Door
    {
        public DoorNeedingSpell(Room r1, Room r2)
            : base(r2, r2)
        {
        }
    }
}
