using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.ProductBuilders.C
{
    public class BuilderManualProductC1 : IBuilderC
    {
        private ConcreteManualProductC1 _manual = new ConcreteManualProductC1();


        public BuilderManualProductC1()
        {
            this.Reset();
        }

        public void Reset()
        {
            _manual = new ConcreteManualProductC1();
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
        public override void BuildPartD()
        {
            this._manual.Add("PART_D");
        }

        public IManual GetProduct()
        {
            ConcreteManualProductC1 result = this._manual;

            this.Reset();

            return result;
        }

        public override void SetName(string name)
        {

        }
    }
}
