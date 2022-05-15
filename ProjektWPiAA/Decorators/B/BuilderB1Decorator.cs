using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Decorators.B
{
    class BuilderB1Decorator : BuilderBDecorator
    {
        public BuilderB1Decorator(IBuilderB builder) : base(builder)
        {
            this.Reset();
        }

        public void Reset()
        {
            _product = new ConcreteProductB1();
        }
        public override void SetName(string Name)
        {
            _product.Name = Name;
        }
        public override void BuildPartA()
        {

            //base.BuildPartA();
            base._product.Add("PART_A", 200);
            base._product.Add("PART_A_insurance", 99);
        }

        public override void BuildPartB()
        {
            //base.BuildPartB();
            base._product.Add("PART_B", 300);
            base._product.Add("PART_B_insurance", 199);
        }

        public ConcreteProductB1 GetProduct()
        {
            ConcreteProductB1 result = (ConcreteProductB1)this._product;

            this.Reset();

            return result;
        }
    }
}
