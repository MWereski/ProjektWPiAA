using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Decorators.C
{
    class BuilderC1Decorator : BuilderCDecorator
    {
        public BuilderC1Decorator(IBuilderC builder) : base(builder)
        {
            this.Reset();
        }

        public void Reset()
        {
            _product = new ConcreteProductC1();
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
        public override void BuildPartC()
        {
            //base.BuildPartB();
            base._product.Add("PART_C", 400);
            base._product.Add("PART_C_insurance", 299);
        }
        public override void BuildPartD()
        {
            //base.BuildPartB();
            base._product.Add("PART_D", 500);
            base._product.Add("PART_D_insurance", 399);
        }
        public ConcreteProductC1 GetProduct()
        {
            ConcreteProductC1 result = (ConcreteProductC1)this._product;

            this.Reset();

            return result;
        }
    }
}
