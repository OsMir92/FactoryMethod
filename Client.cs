using System;

namespace FactoryMethod
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Called the Truck Creator.");
            ClientCode(new TruckCreator());

            Console.WriteLine("");

            Console.WriteLine("Called the Ship Creator.");
            ClientCode(new ShipCreator());
        }
        // El Cliente funciona con una instancia de ConcreteCreator(Truck o Ship)
        // por medio de su interface. Siempre y cuando el cliente siga trabajando
        // con el Creator via la interface, se le puede pasar cualquier subclase Creator
        public void ClientCode(Creator creator)
        {   //No sabe de la clase creador pero aun asi la llama
             Console.WriteLine("Called the Client class\n" + creator.SomeDescription());
        }
    }
}