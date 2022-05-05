using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Models
{
    public class RecipeModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Sum { get; set; }
        public List<RecipeProductModel> RecipeProducts { get; set; }

    }
}
