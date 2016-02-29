using System;

namespace CompositeExample
{
    class Leaf : IPlantMatter
    {
        public string Name { get; set; }

        public void Prune()
        {
            Console.WriteLine("Pruning {0}", Name);
        }
    }
}
