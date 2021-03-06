using ProjektWPiAA.IProductBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Decorators.B
{
    class BuilderBDecorator : IBuilderB
    {
        protected IBuilderB _builder;

        public BuilderBDecorator(IBuilderB builder)
        {
            this._builder = builder;

        }
        public void SetComponent(IBuilderB builder)
        {
            this._builder = builder;
        }

        public override void BuildPartA()
        {
            if (this._builder != null)
            {
                this._builder.BuildPartA();
            }
        }

        public override void BuildPartB()
        {
            if (this._builder != null)
            {
                this._builder.BuildPartB();
            }
        }
        public override void BuildPartC()
        {
            if (this._builder != null)
            {
                this._builder.BuildPartC();
            }
        }

        public override void SetName(string name)
        {
            if (this._builder != null)
            {
                this._builder.SetName(name);
            }
        }
    }
}
