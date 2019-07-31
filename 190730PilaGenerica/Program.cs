using System;
using System.Collections.Generic;

namespace PilaGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(3);
            intStack.Push(4);
            intStack.Push(7);
            System.Console.WriteLine(intStack.Pop());
            System.Console.WriteLine(intStack.Pop());
            System.Console.WriteLine(intStack.Pop());
            System.Console.WriteLine(intStack.Pop());
        }
    }
}
