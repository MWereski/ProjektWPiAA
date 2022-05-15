using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.Facade;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.ProductBuilders;
using ProjektWPiAA.ProductBuilders.A;
using ProjektWPiAA.ProductBuilders.B;
using ProjektWPiAA.ProductBuilders.C;
using ProjektWPiAA.ProductDirectors;

namespace ProjektWPiAA.FactoryB
{
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateMinimalProductA(string name)
        {

            var facadeA2 = new FacadeA2(new DirectorProductA(), new BuilderProductA2(), new BuilderManualProductA2());

            return facadeA2.MinimalOperation(name + " A2");

        }
        public IAbstractProductA CreateFullProductA(string name)
        {

            var facadeA2 = new FacadeA2(new DirectorProductA(), new BuilderProductA2(), new BuilderManualProductA2());

            return facadeA2.FullOperation(name + " A2");
        }
        public IAbstractProductB CreateMinimalProductB(string name)
        {

            var facadeB2 = new FacadeB2(new DirectorProductB(), new BuilderProductB2(), new BuilderManualProductB2());

            return facadeB2.MinimalOperation(name + " B2");

        }
        public IAbstractProductB CreateFullProductB(string name)
        {

            var facadeB2 = new FacadeB2(new DirectorProductB(), new BuilderProductB2(), new BuilderManualProductB2());

            return facadeB2.FullOperation(name + " B2");
        }
        public IAbstractProductC CreateMinimalProductC(string name)
        {

            var facadeC2 = new FacadeC2(new DirectorProductC(), new BuilderProductC2(), new BuilderManualProductC2());

            return facadeC2.MinimalOperation(name + " C2");

        }
        public IAbstractProductC CreateFullProductC(string name)
        {

            var facadeC2 = new FacadeC2(new DirectorProductC(), new BuilderProductC2(), new BuilderManualProductC2());

            return facadeC2.FullOperation(name + " C2");
        }
    }
}
