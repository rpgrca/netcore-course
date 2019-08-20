using System;

namespace EventsWithDelegates
{
    public class Suscriber
    {
        public string Name { get; }

        public Suscriber(string name)
        {
            Name = name;
        }

        /*Este es el manejador de eventos*/
        public void MyEventHandler(Publisher sender)
        {
            Console.WriteLine($"Soy {this.Name} Y  {sender.Name} me informa que genero el numero {sender.LastNumber}");
        }
    }
}