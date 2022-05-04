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
            var productMinA = factory.CreateMinimalProductA();
            var productFullA = factory.CreateFullProductA();
            var productB = factory.CreateProductB();
            var productC = factory.CreateProductC();

            Console.WriteLine("Min Product: " + productMinA.ListParts() + "\n" + productMinA.UsefulFunctionA());
            Console.WriteLine("Full Product: " + productFullA.ListParts() + "\n" + productFullA.UsefulFunctionA());
            //Console.WriteLine(productA.UsefulFunctionA());
            Console.WriteLine(productC.UsefulFunctionC());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productC));
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
