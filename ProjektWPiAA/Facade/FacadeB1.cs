using ProjektWPiAA.Decorators;
using ProjektWPiAA.Decorators.B;
using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.IProductBuilder;
using ProjektWPiAA.ProductBuilders;
using ProjektWPiAA.ProductBuilders.B;
using ProjektWPiAA.ProductDirectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektWPiAA.Facade
{
    public class FacadeB1
    {
        protected DirectorProductB _directorB;

        protected BuilderProductB1 _builderB;
        protected BuilderManualProductB1 _builderManualB;

        public FacadeB1(DirectorProductB directorB, BuilderProductB1 builderB, BuilderManualProductB1 builderManualB)
        {
            this._directorB = directorB;
            this._builderB = builderB;
            this._builderManualB = builderManualB;
        }

        public IAbstractProductB MinimalOperation(string name)
        {
            _directorB.Builder = _builderB;

            _directorB.BuildMinimalViableProduct(name);

            var readyProduct = _builderB.GetProduct();

            _directorB.Builder = _builderManualB;

            _directorB.BuildMinimalViableProduct(name);

            var readyManual = _builderManualB.GetProduct();

            readyProduct.Manual = readyManual;

            return readyProduct;
        }
         
        public IAbstractProductB FullOperation(string name)
        {
            var decorator = new BuilderB1Decorator(_builderB);
            var manualDecorator = new BuilderB1ManualDecorator(_builderManualB);

            _directorB.Builder = decorator;

            _directorB.BuildFullFeaturedProduct(name);

            var readyProduct = decorator.GetProduct();

            _directorB.Builder = manualDecorator;

            _directorB.BuildFullFeaturedProduct(name);

            var readyManual = manualDecorator.GetProduct();

            readyProduct.Manual = readyManual;

            return readyProduct;
        }
    }
}
