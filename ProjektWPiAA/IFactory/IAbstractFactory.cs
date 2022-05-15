using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.IFactory
{
    public interface IAbstractFactory
    {
        //IAbstractProductA CreateProductA();
        IAbstractProductA CreateMinimalProductA(string name);
        IAbstractProductA CreateFullProductA(string name);

        IAbstractProductB CreateMinimalProductB(string name);
        IAbstractProductB CreateFullProductB(string name);

        IAbstractProductC CreateMinimalProductC(string name);
        IAbstractProductC CreateFullProductC(string name);
    }
}
