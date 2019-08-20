using System;

namespace EventsPassingArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            OtherPublisher g = new OtherPublisher("Big Generator");
            OtherSuscriber s1 = new OtherSuscriber("Suscriber1");
            g.NewNumberEvent += s1.MyEventHandler1;
            
            OtherSuscriber s2 = new OtherSuscriber("Suscriber2");
            g.NewNumberEvent += s2.MyEventHandler1;

            g.Run();
        }
    }
}
