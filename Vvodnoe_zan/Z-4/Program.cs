using System;

namespace Z_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a * b;
            Console.WriteLine("c = {0}", c);
            Console.ReadLine();
        }
    }
}
