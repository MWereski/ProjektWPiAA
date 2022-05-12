using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.IProductBuilder;


namespace ProjektWPiAA.Decorators
{
    public abstract class BuilderDecorator : IBuilder
    {

        protected IBuilder _builder;

        public BuilderDecorator(IBuilder builder)
        {
            this._builder = builder;
        }

        public void SetComponent(IBuilder builder)
        {
            this._builder = builder;
        }

        public override void BuildPartA()
        {
           if(this._builder != null)
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

        public override void SetName(string name)
        {
            if (this._builder != null)
            {
                this._builder.SetName(name);   
            }
        }
    }
}
