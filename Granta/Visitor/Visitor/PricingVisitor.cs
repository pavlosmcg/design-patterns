using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public class PricingVisitor : IEquipmentVisitor
    {
        public decimal TotalPrice { get; set; }
        public decimal TotalDiscountPrice { get; set; }

        public void Visit(OpticalDrive opticalDrive)
        {
            TotalPrice += opticalDrive.NetPrice;
            TotalDiscountPrice += opticalDrive.DiscountPrice;
        }

        public void Visit(Card card)
        {
            TotalPrice += card.NetPrice;
            TotalDiscountPrice += card.DiscountPrice;
        }

        public void Visit(Chassis chassis)
        {
            TotalPrice += chassis.NetPrice;
            TotalDiscountPrice += chassis.DiscountPrice;
        }

        public void Visit(MotherBoard motherBoard)
        {
            TotalPrice += motherBoard.NetPrice;
            TotalDiscountPrice += motherBoard.DiscountPrice;
        }
    }
}
