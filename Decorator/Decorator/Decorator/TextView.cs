using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class TextView : IVisualComponent
    {
        public void Draw()
        {
			GUI.DrawTextView ();
        }
    }
}
