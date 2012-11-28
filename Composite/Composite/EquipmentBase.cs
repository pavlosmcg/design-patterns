using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public abstract class EquipmentBase
    {
        public string Name { get; set; }
        public double Power { get; set; }
        public decimal NetPrice { get; set; }
        public decimal DiscountPrice { get; set; }

        public EquipmentBase(string name, double power, decimal netPrice, decimal discountPrice)
        {
            Name = name;
            Power = power;
            NetPrice = netPrice;
            DiscountPrice = discountPrice;
        }

        public virtual void Add(EquipmentBase Equipment)
        {
            throw new NotSupportedException();
        }
        public virtual void Remove(EquipmentBase Equipment)
        {
            throw new NotSupportedException();
        }

        public virtual decimal TotalCost()
        {
            return NetPrice;
        }
        public virtual decimal TotalDiscountCost()
        {
            return DiscountPrice;
        }
    }
}
