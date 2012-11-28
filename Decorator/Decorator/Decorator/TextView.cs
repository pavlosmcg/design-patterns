using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class TextView : VisualComponentBase
    {
        public override void Draw()
        {
            Console.WriteLine("Text view drawn.");
        }
        public override void Resize()
        {
            Console.WriteLine("Text view resized.");
        }
    }
}
