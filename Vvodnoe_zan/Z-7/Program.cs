using System;

namespace Z_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a, b, c:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double x = -b / (2 * a);
            double y = a * x * x + b * x + c;
            Console.WriteLine("Координаты: x = {0}, y = {1}", x, y);
            Console.ReadLine();
        }
    }
}
