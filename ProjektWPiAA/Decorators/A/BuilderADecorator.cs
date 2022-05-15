using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.IProductBuilder;


namespace ProjektWPiAA.Decorators.A
{
    public abstract class BuilderADecorator : IBuilderA
    {

        protected IBuilderA _builder;

        public BuilderADecorator(IBuilderA builder)
        {
            this._builder = builder;
         
        }
        public void SetComponent(IBuilderA builder)
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
