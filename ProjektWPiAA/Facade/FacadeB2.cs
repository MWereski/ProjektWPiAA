using ProjektWPiAA.Decorators;
using ProjektWPiAA.Decorators.B;
using ProjektWPiAA.FactoryB;
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
    public class FacadeB2
    {
        protected DirectorProductB _directorB;

        protected BuilderProductB2 _builderB;
        protected BuilderManualProductB2 _builderManualB;

        public FacadeB2(DirectorProductB directorB, BuilderProductB2 builderB, BuilderManualProductB2 builderManualB)
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
            var decorator = new BuilderB2Decorator(_builderB);
            var manualDecorator = new BuilderB2ManualDecorator(_builderManualB);

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
