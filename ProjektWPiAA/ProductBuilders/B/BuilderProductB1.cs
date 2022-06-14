using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.ProductBuilders.B
{
    public class BuilderProductB1 : IBuilderB
    {
        public BuilderProductB1()
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
        public ConcreteProductB1 GetProduct()
        {
            ConcreteProductB1 result = (ConcreteProductB1)this._product;

            this.Reset();

            return result;
        }
    }
}
