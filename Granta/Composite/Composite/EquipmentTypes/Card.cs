using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Card : EquipmentBase
    {
        public Card(string Name, double Power,
            decimal NetPrice, decimal DiscountPrice)
            : base(Name, Power, NetPrice, DiscountPrice)
        { }

        public void SomethingCardsDo()
        {
            // etc...
            return;
        }
    }
}
