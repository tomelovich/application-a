using System;

namespace Z_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х:");
            int x = Convert.ToInt32(Console.ReadLine());
            double y = (Math.Tan(Math.Sqrt(Math.Log(Math.Pow(Math.E, x + 1))))) -
                ((3 + Math.Sin(Math.Pow(x, 2)) / Math.Sin(Math.Pow(x, 2)) - Math.Cos(Math.Pow(x, 2))));
            Console.WriteLine("y = {0}", y);
        }
    }
}
