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
        public IAbstractProductA CreateProductA()
        {
            var director = new DirectorProductA2();
            var builder = new BuilderProductA2();

            director.Builder = builder;

            Console.WriteLine("Standard basic product A2:");
            director.BuildMinimalViableProduct();

            var readyProduct = builder.GetProduct();

            Console.WriteLine(readyProduct.ListParts());

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
