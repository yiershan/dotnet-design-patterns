using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConcreteClass10().Count(5);
            new ConcreteClass20().Count(5);
            Console.ReadLine();
        }
    }
}
