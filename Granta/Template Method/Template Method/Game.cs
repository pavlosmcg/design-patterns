using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    public abstract class Game 
    {
        public int PlayerCount { get; set; }
        protected bool EndOfGame { get; set; }

        protected abstract void InitializeGame();
        protected abstract void MakePlay(int player);
 
        // template method 
        public void PlayGame() 
        {
            InitializeGame();
            int j = 0;
            while (!EndOfGame) {
                MakePlay(j);
                j = (j + 1) % PlayerCount;
            }
            PrintWinner(j);
        }

        private void PrintWinner(int player)
        {
            Console.WriteLine(player.ToString() + " is the winner!");
        }
    }
 
    //Now we can extend this class in order 
    //to implement actual games:
 
    public class Monopoly : Game 
    {

        /* Implementation of necessary concrete methods */
        protected override void InitializeGame() 
        {
            EndOfGame = false;
            // Initialize players
            // Initialize money
        }
        protected override void MakePlay(int player)
        {
            var rand = new Random();
            if (rand.Next(1, 3)==1)
            {
                EndOfGame = true;
            }
        }

        /* Specific declarations for the Monopoly game. */
 
        // ...
    }
 
    public class Chess : Game 
    {

        /* Implementation of necessary concrete methods */
        protected override void InitializeGame()
        {
            EndOfGame = false;
            // Initialize pieces on board
        }
        protected override void MakePlay(int player)
        {
            // Process one turn of player
        }

        /* Specific declarations for the chess game. */
 
        // ...
    }
}
