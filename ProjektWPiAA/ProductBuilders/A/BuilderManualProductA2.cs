using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.ProductBuilders.A
{
    public class BuilderManualProductA2 : IBuilderA
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

        public override void BuildPartA()
        {
            this._manual.Add("PART_A");
        }

        public override void BuildPartB()
        {
            this._manual.Add("PART_B");
        }

        public IManual GetProduct()
        {
            ConcreteManualProductA2 result = this._manual;

            this.Reset();

            return result;
        }

        public override void SetName(string name)
        {

        }
    }
}
