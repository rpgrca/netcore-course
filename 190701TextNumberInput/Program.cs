using System;

namespace TextNumericInput {
    class Program {
        static void Main(string[] args) {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
        }
    }
}