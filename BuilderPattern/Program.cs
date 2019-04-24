using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            People people1 = new Builder("厨师", "张三")
                .WithHairColor("黑")
                .WithHairType("波浪卷发")
                .Build();
            Console.WriteLine(people1.Show());

            People people2 = new Builder("程序员", "李四")
                .WithHairColor("白")
                .Build();
            Console.WriteLine(people2.Show());
            Console.ReadLine();
        }
    }
}
