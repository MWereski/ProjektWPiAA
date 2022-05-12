using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.IProductBuilder;

namespace ProjektWPiAA.Decorators
{
    public class BuilderA1ManualDecorator : BuilderDecorator
    {
        public BuilderA1ManualDecorator(IBuilder builder) : base(builder)
        {
            this.Reset();
        }

        private ConcreteManualProductA1 _manual = new ConcreteManualProductA1();

        public void Reset()
        {
            _manual = new ConcreteManualProductA1();
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

        public ConcreteManualProductA1 GetProduct()
        {
            ConcreteManualProductA1 result = this._manual;

            this.Reset();

            return result;
        }
    }
}
