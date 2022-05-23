using System;

namespace Z_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X:");
            double x = Convert.ToDouble(Console.ReadLine());
            double z1 = (Math.Pow(x, 2) + 2 * x - 3 + (x + 1) * (Math.Sqrt(Math.Pow(x, 2) - 9))) /
                (Math.Pow(x, 2) - 2 * x - 3 + (x - 1) * (Math.Sqrt(Math.Pow(x, 2) - 9)));
            double z2 = Math.Sqrt((x + 3) / (x - 3));
            Console.WriteLine("z1 = {0} z2 = {1}", z1, z2);
            Console.ReadLine();
        }
    }
}
