using System;

namespace EventsWithDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher g = new Publisher("Big Generator");
            Suscriber s1 = new Suscriber("Suscriber1");
            g.GeneratingNumberEvent += s1.MyEventHandler;
            Suscriber s2 = new Suscriber("Suscriber2");
            g.GeneratingNumberEvent += s2.MyEventHandler;

            g.Run();
            Console.WriteLine("----- Suscriber2 se desuscribe ----");
            g.GeneratingNumberEvent -= s2.MyEventHandler;
            g.Run();
        }
    }
}
