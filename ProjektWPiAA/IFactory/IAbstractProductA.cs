using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.IFactory
{
    public interface IAbstractProductA
    {
        string UsefulFunctionA();

        void Add(string part);

        string ListParts();


    }
}
