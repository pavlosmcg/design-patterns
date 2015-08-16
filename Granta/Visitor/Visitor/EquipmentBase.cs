using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public abstract class EquipmentBase
    {
        private string name;
        private double power;
        private decimal netPrice;
        private decimal discountPrice;

        public EquipmentBase(string Name, double Power,
            decimal NetPrice, decimal DiscountPrice)
        {
            name = Name;
            power = Power;
            netPrice = NetPrice;
            discountPrice = DiscountPrice;
        }

        public string Name { get { return name; } }
        public double Power { get { return power; } }
        public decimal NetPrice { get { return netPrice; } }
        public decimal DiscountPrice { get { return discountPrice; } }

        public virtual void Add(EquipmentBase Equipment)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(EquipmentBase Equipment)
        {
            throw new NotImplementedException();
        }

        public abstract void Accept(IEquipmentVisitor EquipmentVisitor);
    }
}
