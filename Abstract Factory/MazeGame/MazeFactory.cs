using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGame
{
    public class MazeFactory
    {
        // factory methods
        public virtual Maze MakeMaze()
        { return new Maze(); }
        public virtual Room MakeRoom(int n)
        { return new Room(n); }
        public virtual Wall MakeWall()
        { return new Wall(); }
        public virtual Door MakeDoor(Room r1, Room r2)
        { return new Door(r1, r2); }
    }
}
