using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextLibrary;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a text shape (subclass of Text View in referenced library)
            TextShape textShape = new TextShape(new Point { X = 1, Y = 1 }, new Point { X = 10, Y = 2 });

            // drawing editor (client)
            DrawingEditior editor = new DrawingEditior();
            editor.Shapes= new List<IShape>();
            editor.Shapes.Add(textShape);

            // manipulate them in some way
            editor.ManipulateShapes();
        }
    }

    class DrawingEditior
    {
        public List<IShape> Shapes { get; set; }

        
        public void ManipulateShapes()
        {
            foreach (IShape shape in Shapes)
            {
                var manipulator = shape.CreateManipulator();
                manipulator.Display();
            }
        }
    }
}
