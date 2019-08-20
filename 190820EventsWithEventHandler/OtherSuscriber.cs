using System;

namespace EventsWithEventHandler
{
    public class OtherSuscriber
    {
        public string Name { get; }

        public OtherSuscriber(string name)
        {
            Name = name;
        }

        /*Este es el manejador de eventos*/
        public void MyEventHandler(object sender, EventArgs e)
        {
            //Publisher publisher = (Publisher)sender; Si hago este casteo revienta por excepcion
            //var publisher =sender as Publisher; Casteo seguro; pero al tipo incorrecto
            
            var publisher =sender as OtherPublisher;
            if(publisher ==null){
                Console.WriteLine("Todo maaaal no reconozco el tipo del sender");
                return;
            }
            Console.WriteLine($"Soy {this.Name} Y  {publisher.Name} informa que genero un numero");
        }

    }
}