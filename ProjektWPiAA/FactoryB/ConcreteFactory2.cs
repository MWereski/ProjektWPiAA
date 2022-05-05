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
        public IAbstractProductA CreateMinimalProductA()
        {
            //return new ConcreteProductA1();

            var director = new DirectorProductA2();
            var builder = new BuilderProductA2();

            director.Builder = builder;

            Console.WriteLine("Standard basic product A2:");
            director.BuildMinimalViableProduct();

            var readyProduct = builder.GetProduct();

            Console.WriteLine(readyProduct.ListParts());

            var manualBuider = new BuilderManualProductA2();

            director.Builder = manualBuider;
            Console.WriteLine("Create MANUAL");

            director.BuildMinimalViableProduct();

            var readyManual = manualBuider.GetProduct();

            readyProduct.Manual = readyManual;

            Console.WriteLine(readyProduct.Manual.WriteManual());

            return readyProduct;

        }
        public IAbstractProductA CreateFullProductA()
        {
            var director = new DirectorProductA2();
            var builder = new BuilderProductA2();

            director.Builder = builder;

            Console.WriteLine("Full product A2:");
            director.BuildFullFeaturedProduct();

            var readyProduct = builder.GetProduct();

            Console.WriteLine(readyProduct.ListParts());

            var manualBuider = new BuilderManualProductA2();

            director.Builder = manualBuider;
            Console.WriteLine("Create MANUAL");

            director.BuildFullFeaturedProduct();

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
