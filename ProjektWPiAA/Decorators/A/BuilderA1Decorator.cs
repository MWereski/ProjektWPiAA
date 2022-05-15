using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Decorators.A
{
    public class BuilderA1Decorator : BuilderADecorator
    {
        public BuilderA1Decorator(IBuilderA builder) : base(builder)
        {
            this.Reset();
        }

        public void Reset()
        {
            _product = new ConcreteProductA1();
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

        public ConcreteProductA1 GetProduct()
        {
            ConcreteProductA1 result = (ConcreteProductA1)this._product;

            this.Reset();

            return result;
        }

    }
}
