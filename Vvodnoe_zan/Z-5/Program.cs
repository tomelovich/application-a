using System;

namespace Z_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int one, two, three;
            Console.WriteLine("Введите трёхзначное число:");
            string chislo = (Console.ReadLine());
            if ((chislo.Length < 4) && (chislo.Length > 2))
            {
                one = Int32.Parse(chislo[0].ToString());
                two = Int32.Parse(chislo[1].ToString());
                three = Int32.Parse(chislo[2].ToString());
                int proizv = one * two * three;
                Console.WriteLine("Произведение цифр числа = {0}", proizv);
                Console.ReadLine();
            }
        }
    }
}
