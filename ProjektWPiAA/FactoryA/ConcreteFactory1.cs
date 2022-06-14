using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.Decorators;
using ProjektWPiAA.Facade;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.ProductBuilders;
using ProjektWPiAA.ProductBuilders.A;
using ProjektWPiAA.ProductBuilders.B;
using ProjektWPiAA.ProductBuilders.C;
using ProjektWPiAA.ProductDirectors;

namespace ProjektWPiAA.FactoryA
{
    class ConcreteFactory1 : IAbstractFactory
    {
        public string Name { get; set; }

        public ConcreteFactory1(){
            Name = "IKEA";
        }

        public IAbstractProductA CreateMinimalProductA(string name)
        {

            var facadeA1 = new FacadeA1(new DirectorProductA(), new BuilderProductA1(), new BuilderManualProductA1());

            return facadeA1.MinimalOperation(name);

        }
        public IAbstractProductA CreateFullProductA(string name)
        {
            
            var facadeA1 = new FacadeA1(new DirectorProductA(), new BuilderProductA1(),  new BuilderManualProductA1());

            return facadeA1.FullOperation(name);
        }
        public IAbstractProductB CreateMinimalProductB(string name)
        {

            var facadeB1 = new FacadeB1(new DirectorProductB(), new BuilderProductB1(), new BuilderManualProductB1());

            return facadeB1.MinimalOperation(name);

        }
        public IAbstractProductB CreateFullProductB(string name)
        {

            var facadeB1 = new FacadeB1(new DirectorProductB(), new BuilderProductB1(), new BuilderManualProductB1());

            return facadeB1.FullOperation(name);
        }
        public IAbstractProductC CreateMinimalProductC(string name)
        {

            var facadeC1 = new FacadeC1(new DirectorProductC(), new BuilderProductC1(), new BuilderManualProductC1());

            return facadeC1.MinimalOperation(name);

        }
        public IAbstractProductC CreateFullProductC(string name)
        {

            var facadeC1 = new FacadeC1(new DirectorProductC(), new BuilderProductC1(), new BuilderManualProductC1());

            return facadeC1.FullOperation(name);
        }
    }
}
