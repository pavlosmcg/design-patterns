using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            var monopoly = new Monopoly();
            monopoly.PlayerCount = 4;
            monopoly.PlayGame();
        }
    }
}
