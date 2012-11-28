using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public abstract class CompositeEquipment : EquipmentBase
    {
        protected List<EquipmentBase> EquipmentList;

        public CompositeEquipment(string Name, double Power,
            decimal NetPrice, decimal DiscountPrice)
            : base(Name, Power, NetPrice, DiscountPrice)
        {
            EquipmentList = new List<EquipmentBase>();
        }

        public override void Add(EquipmentBase Equipment)
        {
            EquipmentList.Add(Equipment);
        }

        public override void Remove(EquipmentBase Equipment)
        {
            EquipmentList.Remove(Equipment);
        }
    }
}
