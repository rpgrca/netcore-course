using System;

namespace EventsWithEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            OtherPublisher g = new OtherPublisher("Big Generator");
            OtherSuscriber s1 = new OtherSuscriber("Suscriber1");
            g.GeneratingNumberEvent += s1.MyEventHandler;
            
            OtherSuscriber s2 = new OtherSuscriber("Suscriber2");
            g.GeneratingNumberEvent += s2.MyEventHandler;

            g.Run();
        }
    }
}
