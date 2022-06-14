using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.ProductBuilders.B
{
    public class BuilderProductB2 : IBuilderB
    {
        public BuilderProductB2()
        {
            this.Reset();
        }

        public void Reset()
        {
            _product = new ConcreteProductB2();
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
        public ConcreteProductB2 GetProduct()
        {
            ConcreteProductB2 result = (ConcreteProductB2)this._product;

            this.Reset();

            return result;
        }
    }
}
