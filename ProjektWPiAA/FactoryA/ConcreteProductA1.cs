using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using ProjektWPiAA.IProductBuilder;

namespace ProjektWPiAA.FactoryA
{
    public class ConcreteProductA1 : IAbstractProductA
    {
        private List<object> _parts = new List<object>();

        public int _sum;

        private string _name = "";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private IManual _manual;

        public IManual Manual
        {
            get { return _manual; }
            set { _manual = value; }
        }


        public void Add(string part, int costOfPart)
        {
            _parts.Add(part);
            this._sum += costOfPart;
        }

        public string ListParts()
        {
            string str = string.Empty;

            for(int i = 0; i < _parts.Count; i++)
            {
                str += _parts[i].ToString() + ", ";
            }

            return "Product Table parts: " + str + "\n";
        }

        public RecipeProductModel GetModelObject()
        {
            var obj = new RecipeProductModel();

            obj.Id = DateTime.Now.Ticks;
            obj.Name = _name;
            obj.Cost = _sum;
            obj.Manual = _manual.WriteManual();

            return obj;
        }
    }
}
