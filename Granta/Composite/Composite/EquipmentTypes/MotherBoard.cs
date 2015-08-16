using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class MotherBoard : CompositeEquipment
    {
        public MotherBoard(string Name, double Power,
            decimal NetPrice, decimal DiscountPrice)
            : base(Name, Power, NetPrice, DiscountPrice)
        { }
    }
}
