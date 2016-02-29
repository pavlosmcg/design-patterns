using System;
using System.Collections.Generic;

namespace Composite
{
    public class Mob
    {
        public string Name { get; set; }
        public List<Meerkat> Members { get; set; }

        public Mob()
        {
            Members = new List<Meerkat>();
        }

        public void InviteEveryoneInFamilyToMyMostStupendousParty()
        {
            Console.WriteLine("To all the meerkat in {0}", Name);

            foreach (var meerkat in Members)
            {
                meerkat.InviteMyMostStupendousParty();
            }
        }
    }
}