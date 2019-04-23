using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory[] factories = new Factory[2];

            factories[0] = new FactoryA();
            factories[1] = new FactoryB();

            foreach (var factory in factories)
            {
                Product product = factory.CreateProduct();
                Console.WriteLine(product.GetName());
            }
            Console.ReadLine();
        }
    }
}
