using System;

namespace MetodoGenerico
{
    class Program
    {
        // 1. Crear un arreglo de enteros, uno de dobles y otro de strings.
        //
        private static int[] _Enteros = { 11, 22, 33, 44, 55 };
        private static double[] _Flotantes = { 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };
        private static string[] _Cadenas = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

        // 2. Crear un metodo generico que reciba un arreglo y una posicion
        //    y retorne un string indicando el valor del elemento y el tipo
        //    del mismo.
        //
        public static string metodoGenerico<T>(T[] arreglo, int posicion) {
            if (arreglo == null)
                throw new ArgumentNullException("El arreglo no puede ser nulo");

            if (posicion < 0 || posicion >= arreglo.GetLength(0))
                throw new ArgumentOutOfRangeException("La posicion no puede ser menor a 0 ni mayor al tamaño del arreglo");

            return $"En el índice {posicion} hay un elemento de tipo {arreglo[posicion].GetType()} con el valor {arreglo[posicion]}";
        }

        static void Main(string[] args)
        {
            int index;

            for (index = 0; index < _Enteros.GetLength(0); index++) {
                Console.WriteLine(metodoGenerico<int>(_Enteros, index));
            }

            for (index = 0; index < _Flotantes.GetLength(0); index++) {
                Console.WriteLine(metodoGenerico<double>(_Flotantes, index));
            }

            for (index = 0; index < _Cadenas.GetLength(0); index++) {
                Console.WriteLine(metodoGenerico<string>(_Cadenas, index));
            }
        }
    }
}
