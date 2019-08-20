using System;

namespace Delegados
{
    public delegate int Operacion(int a, int b);
    public delegate void Del(string message);

    class Program
    {
        public static int Suma(int a, int b)
        {
            int suma =a+b;
            Console.WriteLine($"Suma de {a} y {b} es: {suma}");
            return suma;
        }

        public static int Resta(int r, int t)
        {
            int resta = r-t;
            Console.WriteLine($"Resta de {r} y {t} es: {resta}");
            return resta;
        }

        public static int Multiplicacion(int x, int y)
        {
            int multiplicacion =x * y;

            Console.WriteLine($"Multiplicacion de {x} por {y} es: {multiplicacion}");
            return multiplicacion;
        }

        public void DelegateMethod(string message)
        {
            System.Console.WriteLine(message);
        }

        static void RunEjemplo1(){
            
            //Instanciando a los delegados
            Operacion mas = new Operacion(Suma);
            Operacion menos = new Operacion(Resta);
            Operacion por = Multiplicacion;

            //Invocando a los delegados
            int r1 = mas(4, 5); // r1 es igual a 9
            int r2 = menos(4, 5); // r2 es igual a -1
            int r3 = por(4, 5); // r3 es igual a 20

            //Concatentando delegados
            Operacion combinado = mas;
            combinado += por; // combinación con el operador +=

            Console.WriteLine("----------------------");
            //Ejecutando la concatenacion
            int r4 = combinado(3, 3);
            Console.WriteLine($"Combinado retorna {r4}");
        }

        static void RunEjemplo2(){
            
            //Instanciando a los delegados
            Program program =new Program();
            Del handler = new Del(program.DelegateMethod);
            //Invocando a los delegados
            handler("Hello World");
        }

        static void Main(string[] args)
        {
            RunEjemplo1();
            RunEjemplo2();
        }
    }
}
