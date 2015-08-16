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
            // create a seemingly incompatible TextView object
            TextView textView = new TextView(new Point { X = 1, Y = 1 }, new Point { X = 10, Y = 2 });

            // create a text shape (subclass of shape in this project)
            TextShape textShape = new TextShape(textView);

            // drawing editor (client)
            DrawingEditior editor = new DrawingEditior();
            editor.Shapes= new List<Shape>();
            editor.Shapes.Add(textShape);

            // manipulate them in some way
            editor.ManipulateShapes();
        }
    }

    class DrawingEditior
    {
        public List<Shape> Shapes { get; set; }

        
        public void ManipulateShapes()
        {
            foreach (Shape shape in Shapes)
            {
                var manipulator = shape.CreateManipulator();
                manipulator.Display();
            }
        }
    }
}
