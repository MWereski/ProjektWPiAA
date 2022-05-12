using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.IProductBuilder
{
    public interface IManual
    {
        List<object> Parts { get; set; }

        public void Add(string part);

        public string ListParts();

        public string WriteManual();
    }
}
