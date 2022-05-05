﻿using ProjektWPiAA.FactoryA;
using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.ProductBuilders
{
    public class BuilderManualProductA1 : IBuilder
    {
        private ConcreteManualProductA1 _manual = new ConcreteManualProductA1();


        public BuilderManualProductA1()
        {
            this.Reset();
        }

        public void Reset()
        {
            _manual = new ConcreteManualProductA1();
        }

        public void BuildPartA()
        {
            this._manual.Add("PART_A");
        }

        public void BuildPartB()
        {
            this._manual.Add("PART_B");
        }

        public ConcreteManualProductA1 GetProduct()
        {
            ConcreteManualProductA1 result = this._manual;

            this.Reset();

            return result;
        }
    }
}
