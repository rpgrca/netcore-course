using System;

namespace ParImparLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> IsOdd = x => ((x & 1) == 1);
            int value = new Random().Next();
            string type = IsOdd(value)? "impar" : "par";

            Console.WriteLine($"El numero {value} es {type}.");
        }
    }
}
