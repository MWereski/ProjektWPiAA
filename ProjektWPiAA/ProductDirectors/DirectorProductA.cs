using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.IProductBuilder;

namespace ProjektWPiAA.ProductDirectors
{
    public class DirectorProductA
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }

        }
        public void BuildMinimalViableProduct(string name)
        {
            this._builder.SetName(name);
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct(string name)
        {
            this._builder.SetName(name);
            this._builder.BuildPartA();
            this._builder.BuildPartB();
        }

    }
}
