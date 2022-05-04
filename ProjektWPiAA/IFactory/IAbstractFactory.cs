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
        IAbstractProductA CreateMinimalProductA();
        IAbstractProductA CreateFullProductA();

        IAbstractProductB CreateProductB();

        IAbstractProductC CreateProductC();
    }
}
