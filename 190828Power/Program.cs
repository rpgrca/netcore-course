using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = new Random().Next(1, 10);
            Func<int, int> cuadrado = x => x * x;
            Console.WriteLine($"El cuadrado de {value} es {cuadrado(value)}.");
        }
    }
}
