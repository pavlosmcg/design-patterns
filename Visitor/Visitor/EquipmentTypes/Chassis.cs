using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public class Chassis : CompositeEquipment
    {
        public Chassis(string Name, double Power,
            decimal NetPrice, decimal DiscountPrice)
            : base(Name, Power, NetPrice, DiscountPrice)
        { }

        public override void Accept(IEquipmentVisitor visitor)
        {
            // visit all sub parts
            EquipmentList.ForEach(i => i.Accept(visitor));

            // then visit current part
            visitor.Visit(this);
        }
    }
}
