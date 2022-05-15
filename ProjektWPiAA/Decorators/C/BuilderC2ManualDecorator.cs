using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Decorators.C
{
    class BuilderC2ManualDecorator : BuilderCDecorator
    {
        public BuilderC2ManualDecorator(IBuilderC builder) : base(builder)
        {
            this.Reset();
        }

        private ConcreteManualProductC2 _manual = new ConcreteManualProductC2();

        public void Reset()
        {
            _manual = new ConcreteManualProductC2();
        }
        public override void SetName(string Name)
        {

        }
        public override void BuildPartA()
        {
            this._manual.Add("PART_A_insurance");
        }

        public override void BuildPartB()
        {
            this._manual.Add("PART_B_insurance");
        }

        public ConcreteManualProductC2 GetProduct()
        {
            ConcreteManualProductC2 result = this._manual;

            this.Reset();

            return result;
        }
    }
}
