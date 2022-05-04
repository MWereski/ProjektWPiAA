using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.IFactory;

namespace ProjektWPiAA.FactoryA
{
    class ConcreteProductB1 : IAbstractProductB
    {

        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }

        public string AnotherUsefulFunctionB(IAbstractProductC collaborator)
        {
            var result = collaborator.UsefulFunctionC();

            return $"The result of the B1 collaborating with the ({result})";
        }

    }
}
