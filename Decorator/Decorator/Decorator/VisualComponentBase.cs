using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public abstract class VisualComponentBase
    {
        public abstract void Draw();
        public abstract void Resize();
        // etc...
    }
}
