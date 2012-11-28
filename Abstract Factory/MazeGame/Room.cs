using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGame
{
    public class Room : MapSite
    {
        public int RoomNumber { get; set; }
        private MapSite[] sides;

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            sides = new MapSite[4];
        }

        public MapSite GetSide(Direction direction)
        {
            return sides[(int)direction];
        }

        public void SetSide(Direction direction, MapSite newSide)
        {
            sides[(int)direction] = newSide;
        }

        public override void Enter()
        {
            // implement entering room
        }
    }
}
