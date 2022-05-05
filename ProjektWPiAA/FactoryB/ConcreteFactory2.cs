using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.ProductBuilders;
using ProjektWPiAA.ProductDirectors;

namespace ProjektWPiAA.FactoryB
{
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateMinimalProductA(string name)
        {
            //return new ConcreteProductA1();

            var director = new DirectorProductA();
            var builder = new BuilderProductA2();

            director.Builder = builder;

            Console.WriteLine("Standard basic product A2:");
            director.BuildMinimalViableProduct(name + " A2");

            var readyProduct = builder.GetProduct();

            Console.WriteLine(readyProduct.ListParts());

            var manualBuider = new BuilderManualProductA2();

            director.Builder = manualBuider;
            Console.WriteLine("Create MANUAL");

            director.BuildMinimalViableProduct(name + " A2");

            var readyManual = manualBuider.GetProduct();

            readyProduct.Manual = readyManual;

            Console.WriteLine(readyProduct.Manual.WriteManual());

            return readyProduct;

        }
        public IAbstractProductA CreateFullProductA(string name)
        {
            var director = new DirectorProductA();
            var builder = new BuilderProductA2();

            director.Builder = builder;

            Console.WriteLine("Full product A2:");
            director.BuildFullFeaturedProduct(name + " A2");

            var readyProduct = builder.GetProduct();

            Console.WriteLine(readyProduct.ListParts());

            var manualBuider = new BuilderManualProductA2();

            director.Builder = manualBuider;
            Console.WriteLine("Create MANUAL");

            director.BuildFullFeaturedProduct(name + " A2");

            var readyManual = manualBuider.GetProduct();

            readyProduct.Manual = readyManual;

            Console.WriteLine(readyProduct.Manual.WriteManual());

            return readyProduct;
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }

        public IAbstractProductC CreateProductC()
        {
            return new ConcreteProductC2();
        }
    }
}
