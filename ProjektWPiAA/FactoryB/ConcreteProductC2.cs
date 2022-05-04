using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.IFactory;

namespace ProjektWPiAA.FactoryB
{
    public class ConcreteProductC2 : IAbstractProductC
    {
        public string UsefulFunctionC()
        {
            return "This is Your END C2";
        }
    }
}
