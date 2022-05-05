using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Models
{
    public class DbModel
    {
        public List<RecipeModel> Recipes { get; set; }

        public DbModel()
        {
            Recipes = new List<RecipeModel>();
        }
    }
}
