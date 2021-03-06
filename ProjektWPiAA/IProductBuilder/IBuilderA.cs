using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.IProductBuilder
{
    public abstract class IBuilderA
    {
        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract void SetName(string name);

        public IAbstractProductA _product;
       
    }
}
 