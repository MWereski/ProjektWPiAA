﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.IProductBuilder;
using ProjektWPiAA.FactoryA;

namespace ProjektWPiAA.ProductBuilders
{
    public class BuilderProductA1 : IBuilder
    {
        private ConcreteProductA1 _product = new ConcreteProductA1();


        public BuilderProductA1()
        {
            this.Reset();
        }

        public void Reset()
        {
            _product = new ConcreteProductA1();
        }
        public void SetName(string Name)
        {
            _product.Name = Name;
        }
        public void BuildPartA()
        {
            this._product.Add("PART_A", 100);
        }

        public void BuildPartB()
        {
            this._product.Add("PART_B", 200);
        }

        public ConcreteProductA1 GetProduct()
        {
            ConcreteProductA1 result = this._product;

            this.Reset();

            return result;
        }

    }
}
