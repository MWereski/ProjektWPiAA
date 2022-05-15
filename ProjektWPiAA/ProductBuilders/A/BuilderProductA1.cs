using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.IProductBuilder;
using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IFactory;

namespace ProjektWPiAA.ProductBuilders.A
{
    public class BuilderProductA1 : IBuilderA
    {
        //private ConcreteProductA1 _product = new ConcreteProductA1();


        public BuilderProductA1()
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
            this._product.Add("PART_A", 100);
        }

        public override void BuildPartB()
        {
            this._product.Add("PART_B", 200);
        }

        public ConcreteProductA1 GetProduct()
        {
            ConcreteProductA1 result = (ConcreteProductA1)this._product;

            this.Reset();

            return result;
        }

    }
}
