using System;
using System.Collections.Generic;
using System.Linq;

namespace ElvisAndNullCoalescing
{

    /*
     * ? Se llama Operador Elvis
     * ?? Es Null Coalescing operator
     */
    class Program
    {
        static public double SumNumbers(List<double[]> setsOfNumbers, int indexOfSetToSum)
        {
            return setsOfNumbers?[indexOfSetToSum]?.Sum() ?? double.NaN;
        }
        static void Main(string[] args)
        {
            var sum1 = SumNumbers(null, 0);
            Console.WriteLine(sum1);  // output: NaN

            var numberSets = new List<double[]>
                            {
                                new[] { 1.0, 2.0, 3.0 },
                                null
                            };

            var sum2 = SumNumbers(numberSets, 0);
            Console.WriteLine(sum2);  // output: 6

            var sum3 = SumNumbers(numberSets, 1);
            Console.WriteLine(sum3);  // output: NaN

            //var sum4 = SumNumbers(numberSets, 10);
            //Console.WriteLine(sum4);
        }
    }
}
