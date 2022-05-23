using System;

namespace Z_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление площади треугольника.");
            Console.WriteLine("Введите исходные данные:");
            Console.Write("Основание(см) —>");
            double base_triangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Высота(см) —>");
            double height = Convert.ToDouble(Console.ReadLine());
            double S = 0.5 * base_triangle * height;
            Console.Write("Площадь треугольника {0} кв.см.", S);
            Console.ReadLine();
        }
    }
}
