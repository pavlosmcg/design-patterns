using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGame
{
    public class Maze
    {
        private List<Room> rooms;

        public Maze()
        {
            rooms= new List<Room>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        // ... other maze implementation
    }
}
