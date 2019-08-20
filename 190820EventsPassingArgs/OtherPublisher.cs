using System;
using System.Threading;

namespace EventsPassingArgs
{
public class OtherPublisher
    {
        ///Opcion con pasaje de argumentos
        public event EventHandler<int> NewNumberEvent;
         
        public string Name { get; }

        public OtherPublisher(string name)
        {
            Name =name;
        }

        public void Run()
        {
            Random rnd = new Random();

            // Generate 10 temperatures between 0 and 100 randomly.
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int _generated = rnd.Next();

                Console.WriteLine($"Soy {this.Name} y genere el numero: {_generated}");

                if (NewNumberEvent != null)
                {
                    NewNumberEvent(this, _generated);
                }
                Thread.Sleep(2000);
            }
        }
    }
}