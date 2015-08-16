using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Window
    {
        private VisualComponentBase _contents;

        public void SetContents(VisualComponentBase contents)
        {
            _contents = contents;
        }

        public void DrawContents()
        {
            _contents.Draw();
        }
    }
}
