using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class OpticalDrive : EquipmentBase
    {
        public OpticalDrive(string Name, double Power,
            decimal NetPrice, decimal DiscountPrice)
            : base(Name, Power, NetPrice, DiscountPrice)
        { }

        public void SomethingOpticalDrivesDo()
        {
            return;
        }
    }
}
