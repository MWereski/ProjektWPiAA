using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Models
{
    public class RecipeProductModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Manual { get; set; }
        public int Cost { get; set; }
    }
}
