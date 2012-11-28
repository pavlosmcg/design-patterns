using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public class Card : EquipmentBase
    {
        public Card(string Name, double Power,
            decimal NetPrice, decimal DiscountPrice)
            : base(Name, Power, NetPrice, DiscountPrice)
        { }

        public void SomethingCardsDo()
        {
            return;
        }

        public override void Accept(IEquipmentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
