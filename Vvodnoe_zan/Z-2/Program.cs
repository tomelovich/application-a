using System;

namespace Z_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string one, two, three;
            Console.Write("Введите N: ");
            string N = Console.ReadLine();
            one = (N[0].ToString());
            two = (N[1].ToString());
            three = (N[2].ToString());
            int X = Int32.Parse(two + three + one);
            Console.WriteLine("X = {0}", X);
            Console.ReadLine();
        }
    }
}
