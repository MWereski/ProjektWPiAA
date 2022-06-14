using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.ProductBuilders.C
{
    public class BuilderProductC1 : IBuilderC
    {
        public BuilderProductC1()
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
            this._product.Add("PART_A", 100);
        }

        public override void BuildPartB()
        {
            this._product.Add("PART_B", 200);
        }
        public override void BuildPartC()
        {
            this._product.Add("PART_C", 300);
        }
        public override void BuildPartD()
        {
            this._product.Add("PART_D", 400);
        }
        public ConcreteProductC1 GetProduct()
        {
            ConcreteProductC1 result = (ConcreteProductC1)this._product;

            this.Reset();

            return result;
        }
    }
}
