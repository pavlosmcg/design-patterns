using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Window
    {
        private IVisualComponent _contents;

        public void SetContents(IVisualComponent contents)
        {
            _contents = contents;
        }

        public void DrawContents()
        {
            _contents.Draw();
        }
    }
}
