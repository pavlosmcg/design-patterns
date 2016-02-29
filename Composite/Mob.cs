using System.Collections.Generic;

namespace Composite
{
    public class Mob
    {
        public List<Meerkat> Members { get; set; }

        public Mob()
        {
            Members = new List<Meerkat>();
        }

        public void InviteEveryoneInFamilyToMyMostStupendousParty()
        {
            foreach (var meerkat in Members)
            {
                meerkat.InviteMyMostStupendousParty();
            }
        }
    }
}