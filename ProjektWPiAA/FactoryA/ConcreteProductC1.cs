using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.IFactory;

namespace ProjektWPiAA.FactoryA
{
    public class ConcreteProductC1 : IAbstractProductC
    {
        public string UsefulFunctionC()
        {
            return "You get C1 table";
        }
    }
}
