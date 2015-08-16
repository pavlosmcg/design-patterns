using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class BorderDecorator : DecoratorBase
    {
        private int _width;

        public BorderDecorator(VisualComponentBase component, int borderWidth)
            : base(component)
        {
            _width = borderWidth;
        }

        public override void Draw()
        {
            base.Draw();
            Program.DrawBorder(_width); 
        }
    }
}
