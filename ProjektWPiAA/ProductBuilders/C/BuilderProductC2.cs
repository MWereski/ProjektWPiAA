using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.ProductBuilders.C
{
    public class BuilderProductC2 : IBuilderC
    {
        public BuilderProductC2()
        {
            this.Reset();
        }

        public void Reset()
        {
            _product = new ConcreteProductC2();
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
        public ConcreteProductC2 GetProduct()
        {
            ConcreteProductC2 result = (ConcreteProductC2)this._product;

            this.Reset();

            return result;
        }
    }
}
