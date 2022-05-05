using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.IProductBuilder
{
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void SetName(string name);

    }
}
