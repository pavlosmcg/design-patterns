using System;

namespace CompositeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaf1 = new Leaf { Name = "First leaf" };
            var leaf2 = new Leaf { Name = "Second leaf" };
            var leaf3 = new Leaf { Name = "Thrid leaf" };
            var leaf4 = new Leaf { Name = "Forth leaf" };
            var leaf5 = new Leaf { Name = "Fifth leaf" };
            var leaf6 = new Leaf { Name = "Sixth leaf" };
            var leaf7 = new Leaf { Name = "Seventh leaf" };
            var leaf8 = new Leaf { Name = "Eigth leaf" };
            var leaf9 = new Leaf { Name = "Ninth leaf" };
            var leaf10 = new Leaf { Name = "Tenth leaf" };
            var branch1 = new Branch { Name = "First Branch", Growth = { leaf3, leaf4, leaf5 } };
            var branch3 = new Branch { Name = "Third Branch", Growth = { leaf6, leaf7, leaf8 } };
            var branch2 = new Branch { Name = "Second Branch", Growth = { branch3, leaf9, leaf10 } };

            var tree = new Branch { Name = "Tree", Growth = { leaf1, leaf2, branch1, branch2 } };

            tree.Prune();

            Console.ReadLine();
        }
    }
}
