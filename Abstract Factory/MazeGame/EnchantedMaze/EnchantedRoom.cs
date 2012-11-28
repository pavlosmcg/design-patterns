using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGame.EnchantedMaze
{
    public class EnchantedRoom : Room
    {
        private Spell spell;

        public EnchantedRoom(int n, Spell newSpell)
            : base(n)
        {
            spell = newSpell;
        }

        // other enchanted room implementation here
    }
}
