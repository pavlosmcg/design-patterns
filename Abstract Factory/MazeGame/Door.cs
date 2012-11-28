using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGame
{
    public class Door : MapSite
    {
        public bool IsOpen { get; set; }
        private readonly Room room1, room2;

        public Door(Room Room1, Room Room2)
        {
            room1 = Room1;
            room2 = Room2;
        }

        public Room OtherSideFrom(Room room)
        {
            if (room.RoomNumber == room1.RoomNumber)
                return room2;

            if (room.RoomNumber == room2.RoomNumber)
                return room1;

            return null;
        }

        public override void Enter()
        {
            if (IsOpen)
            {
                // implement entering door
            }
        }
    }
}
