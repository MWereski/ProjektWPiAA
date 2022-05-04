using ProjektWPiAA.FactoryA;
using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IFactory;
using System;

namespace ProjektWPiAA
{

    class Client {
    
        public void Main()
        {
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactory2());

        }

        public static void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();
            var productC = factory.CreateProductC();    

            Console.WriteLine(productA.UsefulFunctionA());
            Console.WriteLine(productC.UsefulFunctionC());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
           new Client().Main();
        }
    }
}
