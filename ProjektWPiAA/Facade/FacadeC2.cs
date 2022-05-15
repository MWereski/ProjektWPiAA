using ProjektWPiAA.Decorators;
using ProjektWPiAA.Decorators.C;
using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.IProductBuilder;
using ProjektWPiAA.ProductBuilders;
using ProjektWPiAA.ProductBuilders.C;
using ProjektWPiAA.ProductDirectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektWPiAA.Facade
{
    public class FacadeC2
    {
        protected DirectorProductC _directorC;

        protected BuilderProductC2 _builderC;
        protected BuilderManualProductC2 _builderManualC;

        public FacadeC2(DirectorProductC directorC, BuilderProductC2 builderC, BuilderManualProductC2 builderManualC)
        {
            this._directorC = directorC;
            this._builderC = builderC;
            this._builderManualC = builderManualC;
        }

        public IAbstractProductC MinimalOperation(string name)
        {
            _directorC.Builder = _builderC;

            _directorC.BuildMinimalViableProduct(name);

            var readyProduct = _builderC.GetProduct();

            _directorC.Builder = _builderManualC;

            _directorC.BuildMinimalViableProduct(name);

            var readyManual = _builderManualC.GetProduct();

            readyProduct.Manual = readyManual;

            return readyProduct;
        }
         
        public IAbstractProductC FullOperation(string name)
        {
            var decorator = new BuilderC2Decorator(_builderC);
            var manualDecorator = new BuilderC2ManualDecorator(_builderManualC);

            _directorC.Builder = decorator;

            _directorC.BuildFullFeaturedProduct(name);

            var readyProduct = decorator.GetProduct();

            _directorC.Builder = manualDecorator;

            _directorC.BuildFullFeaturedProduct(name);

            var readyManual = manualDecorator.GetProduct();

            readyProduct.Manual = readyManual;

            return readyProduct;
        }
    }
}
