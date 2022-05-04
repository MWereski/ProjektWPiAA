using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.IFactory;

namespace ProjektWPiAA.FactoryA
{
    public class ConcreteProductA1 : IAbstractProductA
    {
        private List<object> _parts = new List<object>();
        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for(int i = 0; i < _parts.Count; i++)
            {
                str += _parts[i].ToString() + ", ";
            }

            return "Product A1 parts: " + str + "\n";
        }

        public string UsefulFunctionA()
        {
            return "The Result Of the product A1";
        }
    }
}
