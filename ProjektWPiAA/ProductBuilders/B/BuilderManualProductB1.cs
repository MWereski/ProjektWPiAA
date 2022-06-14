using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.ProductBuilders.B
{
    public class BuilderManualProductB1 : IBuilderB
    {
        private ConcreteManualProductB1 _manual = new ConcreteManualProductB1();


        public BuilderManualProductB1()
        {
            this.Reset();
        }

        public void Reset()
        {
            _manual = new ConcreteManualProductB1();
        }

        public override void BuildPartA()
        {
            this._manual.Add("PART_A");
        }

        public override void BuildPartB()
        {
            this._manual.Add("PART_B");
        }

        public override void BuildPartC()
        {
            this._manual.Add("PART_C");
        }

        public IManual GetProduct()
        {
            ConcreteManualProductB1 result = this._manual;

            this.Reset();

            return result;
        }

        public override void SetName(string name)
        {

        }
    }
}
