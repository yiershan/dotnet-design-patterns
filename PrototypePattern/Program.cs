using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Sheep original = new Sheep("Jolly");
            Sheep cloned = original.Clone();
            cloned.Name="Dolly";
            Console.WriteLine(original.Name);
            Console.WriteLine(cloned.Name);
            Console.ReadLine();
        }
    }
}
