using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MazeGame.EnchantedMaze;

namespace MazeGame
{
    public enum Direction { North, East, South, West }

    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();
            MazeFactory factory = new EnchantedMazeFactory();

            Maze maze = mazeGame.CreateMaze(factory);
        }
    }
}
