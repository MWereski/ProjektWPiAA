using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Decorators.B
{
    class BuilderB1ManualDecorator : BuilderBDecorator
    {
        public BuilderB1ManualDecorator(IBuilderB builder) : base(builder)
        {
            this.Reset();
        }

        private ConcreteManualProductB1 _manual = new ConcreteManualProductB1();

        public void Reset()
        {
            _manual = new ConcreteManualProductB1();
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

        public ConcreteManualProductB1 GetProduct()
        {
            ConcreteManualProductB1 result = this._manual;

            this.Reset();

            return result;
        }
    }
}
