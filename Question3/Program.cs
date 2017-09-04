using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Введите х");
            while (!Double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Неверный ввод");

            Console.WriteLine("Введите у");
            while (!Double.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Неверный ввод");

            bool D = false;
            D = x * x + y * y < 1 & y > Math.Abs(x);

            double ans = 0;
            if (D) ans = Math.Sqrt(Math.Abs(x * x - 1));
            else ans = x + y;

            Console.WriteLine("Принадлежит области: " + D);
            Console.WriteLine("u = " + ans);
            Console.ReadKey();
        }
    }
}
