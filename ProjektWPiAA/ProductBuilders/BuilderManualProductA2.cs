using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.ProductBuilders
{
    public class BuilderManualProductA2 : IBuilder
    {
        private ConcreteManualProductA2 _manual = new ConcreteManualProductA2();


        public BuilderManualProductA2()
        {
            this.Reset();
        }

        public void Reset()
        {
            _manual = new ConcreteManualProductA2();
        }

        public void BuildPartA()
        {
            this._manual.Add("PART_A");
        }

        public void BuildPartB()
        {
            this._manual.Add("PART_B");
        }

        public ConcreteManualProductA2 GetProduct()
        {
            ConcreteManualProductA2 result = this._manual;

            this.Reset();

            return result;
        }
    }
}
