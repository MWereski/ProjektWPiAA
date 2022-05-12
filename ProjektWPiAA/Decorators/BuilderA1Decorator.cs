using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Decorators
{
    public class BuilderA1Decorator : BuilderDecorator
    {
        public BuilderA1Decorator(IBuilder builder) : base(builder)
        {
            this.Reset();
        }

        private ConcreteProductA1 _product = new ConcreteProductA1();

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
            this._product.Add("PART_A_insurance", 199);
        }

        public override void BuildPartB()
        {
            this._product.Add("PART_B_insurance", 299);
        }

        public ConcreteProductA1 GetProduct()
        {
            ConcreteProductA1 result = this._product;

            this.Reset();

            return result;
        }

    }
}
