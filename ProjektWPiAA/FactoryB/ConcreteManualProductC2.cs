
using System.Collections.Generic;
using ProjektWPiAA.IProductBuilder;

namespace ProjektWPiAA.FactoryB
{
    public class ConcreteManualProductC2 : IManual
    {
        private List<object> _parts = new List<object>();
        public List<object> Parts
        {
            get { return _parts; }
            set { _parts = value; }
        }
        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < _parts.Count; i++)
            {
                str += _parts[i].ToString() + ", ";
            }

            return "Product C2 parts: " + str + "\n";
        }

        public string WriteManual()
        {
            string str = "MANUAL PRODUCT C2: \n";

            for (int i = 0; i < _parts.Count; i++)
            {
                str += "MANUAL OF PART: " + _parts[i].ToString() + "\n";
            }

            return str + "END OF MANUAL OF PRODUCT C2" + "\n";
        }
    }
}
