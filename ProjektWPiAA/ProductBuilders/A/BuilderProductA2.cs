using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.ProductBuilders.A
{
    public class BuilderProductA2 : IBuilderA
    {
        //private ConcreteProductA2 _product = new ConcreteProductA2();

        public BuilderProductA2()
        {
            this.Reset();
        }

        public void Reset()
        {
            _product = new ConcreteProductA2();
        }
        public override void SetName(string Name)
        {
            _product.Name = Name;
        }
        public override void BuildPartA()
        {
            this._product.Add("PART_A", 200);
        }

        public override void BuildPartB()
        {
            this._product.Add("PART_B", 300);
        }

        public ConcreteProductA2 GetProduct()
        {
            ConcreteProductA2 result = (ConcreteProductA2)this._product;

            this.Reset();

            return result;
        }
    }
}
