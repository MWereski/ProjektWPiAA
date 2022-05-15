using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.ProductBuilders.C
{
    public class BuilderManualProductC2 : IBuilderC
    {
        private ConcreteManualProductC2 _manual = new ConcreteManualProductC2();


        public BuilderManualProductC2()
        {
            this.Reset();
        }

        public void Reset()
        {
            _manual = new ConcreteManualProductC2();
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
            ConcreteManualProductC2 result = this._manual;

            this.Reset();

            return result;
        }

        public override void SetName(string name)
        {

        }
    }
}
