using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Chassis : CompositeEquipment
    {
        public Chassis(string Name, double Power,
            decimal NetPrice, decimal DiscountPrice)
            : base(Name, Power, NetPrice, DiscountPrice)
        { }
    }
}
