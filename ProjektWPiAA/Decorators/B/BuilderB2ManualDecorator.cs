using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Decorators.B
{
    class BuilderB2ManualDecorator : BuilderBDecorator
    {
        public BuilderB2ManualDecorator(IBuilderB builder) : base(builder)
        {
            this.Reset();
        }

        private ConcreteManualProductB2 _manual = new ConcreteManualProductB2();

        public void Reset()
        {
            _manual = new ConcreteManualProductB2();
        }
        public override void SetName(string Name)
        {

        }
        public override void BuildPartA()
        {
            this._manual.Add("PART_A");
            this._manual.Add("PART_A_insurance");
        }

        public override void BuildPartB()
        {
            this._manual.Add("PART_B");
            this._manual.Add("PART_B_insurance");
        }
        public override void BuildPartC()
        {
            this._manual.Add("PART_C");
            this._manual.Add("PART_C_insurance");
        }
        public ConcreteManualProductB2 GetProduct()
        {
            ConcreteManualProductB2 result = this._manual;

            this.Reset();

            return result;
        }
    }
}
