using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGame
{
    public class EnchantedMazeGame : MazeGame
    {
        public override Room MakeRoom(int n)
        {
            return new EnchantedRoom(n, CastSpell());
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            return new DoorNeedingSpell(r1, r2);
        }

        protected Spell CastSpell()
        {
            return new Spell();
        }
    }

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

    public class DoorNeedingSpell : Door
    {
        public DoorNeedingSpell(Room r1, Room r2)
            :base (r2,r2)
        {
        }
    }

    public class Spell
    {
        // some type of magic here
    }
}
