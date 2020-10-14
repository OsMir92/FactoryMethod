/*Factory Method Design Pattern
Intent: Provee una interface para crear objetos en una superclase, pero
permite a subclases alterar el tipo de objetos que se crearan.*/

using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
            Console.ReadKey();
        }
    }
}