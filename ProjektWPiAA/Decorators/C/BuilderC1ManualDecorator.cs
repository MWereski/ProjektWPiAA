using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Decorators.C
{
    class BuilderC1ManualDecorator : BuilderCDecorator
    {
        public BuilderC1ManualDecorator(IBuilderC builder) : base(builder)
        {
            this.Reset();
        }

        private ConcreteManualProductC1 _manual = new ConcreteManualProductC1();

        public void Reset()
        {
            _manual = new ConcreteManualProductC1();
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
        public override void BuildPartD()
        {
            this._manual.Add("PART_D");
            this._manual.Add("PART_D_insurance");
        }
        public ConcreteManualProductC1 GetProduct()
        {
            ConcreteManualProductC1 result = this._manual;

            this.Reset();

            return result;
        }
    }
}
