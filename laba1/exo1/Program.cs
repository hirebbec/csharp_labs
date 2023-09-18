using System;

namespace laba1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Vector v1 = new Vector(5, -4, 0);
            Vector v2 = new Vector(4, -4, -2);

            Console.WriteLine($"Вектор 1 -> {v1}");
            Console.WriteLine($"Вектор 2 -> {v2}");

            Vector vSum = v1 + v2;
            Vector vDif = v1 - v2;

            Console.WriteLine($"Вектор 1 + Вектор 2 = {vSum}");
            Console.WriteLine($"Вектор 1 - Вектор 2 = {vDif}");
            Console.WriteLine($"Вектор 1 * Вектор 2 = {v1 * v2}");

            Console.WriteLine($"Длинна Вектор 1 = {v1.len()}");
            Console.WriteLine($"Длинна Вектор 2 = {v2.len()}");

            Console.WriteLine($"Косинус между векторами 1 и 2 = {v1.cos(v2)}");
        }
    }
}
