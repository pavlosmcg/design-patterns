using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGame
{
    public enum Direction { North, East, South, West }

    class Program
    {
        static void Main(string[] args)
        {
            // normal game
            MazeGame mazeGame = new MazeGame();
            Maze maze = mazeGame.CreateMaze();

            // another type of game
            EnchantedMazeGame enchantedMazeGame = new EnchantedMazeGame();
            Maze enchantedMaze = enchantedMazeGame.CreateMaze();
        }
    }
}
