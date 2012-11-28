using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class ScrollDecorator : DecoratorBase
    {
        private int _topLine;

        public ScrollDecorator(VisualComponentBase component, int topLine)
            : base(component)
        {
            _topLine = topLine;
        }

        public override void Draw()
        {
            base.Draw();
            Program.DisplayScrollBar(_topLine); 
        }
    }
}
