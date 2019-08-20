using System;

namespace EventsWithEventHandler
{
public class OtherPublisher
    {
        /* Opcion con EventHandler
         */
        public event EventHandler GeneratingNumberEvent;

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
                int generated = rnd.Next();
                Console.WriteLine($"Soy {this.Name} y genere el numero: {generated}");
                if (GeneratingNumberEvent != null)
                {
                    //El 2do argumento indica que no quiero pasarle
                    //argumentos al EventHandler
                    GeneratingNumberEvent(this, EventArgs.Empty);
                }
            }
        }
    }
}