using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public interface IEquipmentVisitor
    {
        void Visit(OpticalDrive opticalDrive);
        void Visit(Card card);
        void Visit(Chassis chassis);
        void Visit(MotherBoard motherBoard);
    }
}
