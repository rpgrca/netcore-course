using System;

namespace EventsPassingArgs
{
    public class OtherSuscriber
    {
        public string Name { get; }

        public OtherSuscriber(string name)
        {
            Name = name;
        }

        /*Este es el manejador de eventos*/
        public void MyEventHandler1(object sender, int number)
        {
            var publisher = sender as OtherPublisher;
            Console.WriteLine($"Soy {this.Name} Y  {publisher.Name} me informa el numero {number}");
        }

    }
}