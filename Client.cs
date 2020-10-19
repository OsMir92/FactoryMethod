using System;

namespace FactoryMethod
{
    class Client
    {
        public void Main()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:\n" +
                "[1] Create a Truck.\n" +
                "[2] Create a Ship.\n" +
                "[3] Exit.\n");

            string opc;
            opc = Console.ReadLine();

            switch (opc)
            {
                default:
                    Console.WriteLine("Please choose a valid option.");
                    Console.ReadKey();
                    Main();
                    break;
                case "1":
                    Console.WriteLine("Called the Truck Creator.");
                    ClientCode(new TruckCreator());
                    OneMore();
                    break;
                case "2":
                    Console.WriteLine("Called the Ship Creator.");
                    ClientCode(new ShipCreator());
                    OneMore();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
            }
        }
        // El Cliente funciona con una instancia de ConcreteCreator(Truck o Ship)
        // por medio de su interface. Siempre y cuando el cliente siga trabajando
        // con el Creator via la interface, se le puede pasar cualquier subclase Creator
        public void ClientCode(Creator creator)
        {   //No sabe de la clase creador pero aun asi la llama
             Console.WriteLine("Called the Client class\n" + creator.SomeDescription());
        }

        public void OneMore()
        {
            Console.WriteLine("\nDo you want to create another transportation vehicle?" +
                "\n[1] Yes. [2] No");
            string opc = Console.ReadLine();
            if (opc == "1")
            {
                Main();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}