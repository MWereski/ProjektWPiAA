using ProjektWPiAA.Decorators;
using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.IProductBuilder;
using ProjektWPiAA.ProductBuilders;
using ProjektWPiAA.ProductDirectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektWPiAA.Facade
{
    public class FacadeA1
    {
        protected DirectorProductA _directorA;

        protected BuilderProductA1 _builderA;
        protected BuilderManualProductA1 _builderManualA;

        public FacadeA1(DirectorProductA directorA, BuilderProductA1 builderA, BuilderManualProductA1 builderManualA)
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
            var decorator = new BuilderA1Decorator(_builderA);
            var manualDecorator = new BuilderA1ManualDecorator(_builderManualA);

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
