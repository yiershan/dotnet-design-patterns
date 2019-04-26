using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Sheep original = new Sheep("Jolly");
            Sheep cloned = original.Clone() as Sheep;
            Sheep cloned1 = original.Clone1();
            Sheep cloned2 = original.Clone2();
            original.Name = "original";
            original.Children.Add(new Sheep("originalChild1"));
            original.Children.Add(new Sheep("originalChild2"));

            Console.WriteLine("名字：{0}，孩子个数{1}",original.Name,original.Children.Count);
            Console.WriteLine("名字：{0}，孩子个数{1}", cloned.Name, cloned.Children.Count);
            Console.WriteLine("名字：{0}，孩子个数{1}", cloned1.Name, cloned1.Children.Count);
            Console.WriteLine("名字：{0}，孩子个数{1}", cloned2.Name, cloned2.Children.Count);
            Console.ReadLine();
        }
    }
}
