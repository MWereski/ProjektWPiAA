using ProjektWPiAA.Decorators;
using ProjektWPiAA.Decorators.A;
using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.IProductBuilder;
using ProjektWPiAA.ProductBuilders;
using ProjektWPiAA.ProductBuilders.A;
using ProjektWPiAA.ProductDirectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektWPiAA.Facade
{
    public class FacadeA2
    {
        protected DirectorProductA _directorA;

        protected BuilderProductA2 _builderA;
        protected BuilderManualProductA2 _builderManualA;

        public FacadeA2(DirectorProductA directorA, BuilderProductA2 builderA, BuilderManualProductA2 builderManualA)
        {
            this._directorA = directorA;
            this._builderA = builderA;
            this._builderManualA = builderManualA;
        }

        public IAbstractProductA MinimalOperation(string name)
        {
            _directorA.Builder = _builderA;

            _directorA.BuildMinimalViableProduct(name);

            var readyProduct = _builderA.GetProduct();

            _directorA.Builder = _builderManualA;

            _directorA.BuildMinimalViableProduct(name);

            var readyManual = _builderManualA.GetProduct();

            readyProduct.Manual = readyManual;

            return readyProduct;
        }
         
        public IAbstractProductA FullOperation(string name)
        {
            var decorator = new BuilderA2Decorator(_builderA);
            var manualDecorator = new BuilderA2ManualDecorator(_builderManualA);

            _directorA.Builder = decorator;

            _directorA.BuildFullFeaturedProduct(name);

            var readyProduct = decorator.GetProduct();

            _directorA.Builder = manualDecorator;

            _directorA.BuildFullFeaturedProduct(name);

            var readyManual = manualDecorator.GetProduct();

            readyProduct.Manual = readyManual;

            return readyProduct;
        }
    }
}
