using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.IProductBuilder;

namespace ProjektWPiAA.Decorators.A
{
    public class BuilderA2ManualDecorator : BuilderADecorator
    {
        public BuilderA2ManualDecorator(IBuilderA builder) : base(builder)
        {
            this.Reset();
        }

        private ConcreteManualProductA2 _manual = new ConcreteManualProductA2();

        public void Reset()
        {
            _manual = new ConcreteManualProductA2();
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

        public ConcreteManualProductA2 GetProduct()
        {
            ConcreteManualProductA2 result = this._manual;

            this.Reset();

            return result;
        }
    }
}
