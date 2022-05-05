using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.ProductBuilders;
using ProjektWPiAA.ProductDirectors;

namespace ProjektWPiAA.FactoryA
{
    class ConcreteFactory1 : IAbstractFactory
    { 

        public IAbstractProductA CreateMinimalProductA(string name)
        {
            //return new ConcreteProductA1();

            var director = new DirectorProductA();
            var builder = new BuilderProductA1();

            director.Builder = builder;

            Console.WriteLine("Standard basic product A1:");
            director.BuildMinimalViableProduct(name + " A1");

            var readyProduct = builder.GetProduct();

            Console.WriteLine(readyProduct.ListParts());

            var manualBuider = new BuilderManualProductA1();

            director.Builder = manualBuider;
            Console.WriteLine("Create MANUAL");

            director.BuildMinimalViableProduct(name + " A1");

            var readyManual = manualBuider.GetProduct();

            readyProduct.Manual = readyManual;

            Console.WriteLine(readyProduct.Manual.WriteManual());

            return readyProduct;

        }
        public IAbstractProductA CreateFullProductA(string name)
        {
            var director = new DirectorProductA();
            var builder = new BuilderProductA1();

            director.Builder = builder;

            Console.WriteLine("Full product A1:");
            director.BuildFullFeaturedProduct(name + " A1");

            var readyProduct = builder.GetProduct();

            Console.WriteLine(readyProduct.ListParts());

            var manualBuider = new BuilderManualProductA1();

            director.Builder = manualBuider;
            Console.WriteLine("Create MANUAL");

            director.BuildFullFeaturedProduct(name + " A1");

            var readyManual = manualBuider.GetProduct();

            readyProduct.Manual = readyManual;

            Console.WriteLine(readyProduct.Manual.WriteManual());

            return readyProduct;
        }
        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }

        public IAbstractProductC CreateProductC()
        {
            return new ConcreteProductC1();
        }
    }
}
