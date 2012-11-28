using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class DecoratorBase : VisualComponentBase
    {
        protected VisualComponentBase _component;

        public DecoratorBase(VisualComponentBase component)
        {
            _component = component;
        }

        public override void Draw()
        {
            _component.Draw();
        }

        public override void Resize()
        {
            _component.Resize();
        }
    }
}
