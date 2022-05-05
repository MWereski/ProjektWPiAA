using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.ProductBuilders
{
    public class BuilderProductA2 : IBuilder
    {
        private ConcreteProductA2 _product = new ConcreteProductA2();


        public BuilderProductA2()
        {
            this.Reset();
        }

        public void Reset()
        {
            _product = new ConcreteProductA2();
        }
        public void SetName(string Name)
        {
            _product.Name = Name;
        }
        public void BuildPartA()
        {
            this._product.Add("PART_A", 200);
        }

        public void BuildPartB()
        {
            this._product.Add("PART_B", 300);
        }

        public ConcreteProductA2 GetProduct()
        {
            ConcreteProductA2 result = this._product;

            this.Reset();

            return result;
        }
    }
}
