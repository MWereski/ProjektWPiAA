﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.FactoryB
{
    public class ConcreteManualProductA2
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < _parts.Count; i++)
            {
                str += _parts[i].ToString() + ", ";
            }

            return "Product A2 parts: " + str + "\n";
        }

        public string WriteManual()
        {
            string str = "MANUAL PRODUCT A2: \n";

            for (int i = 0; i < _parts.Count; i++)
            {
                str += "MANUAL OF PART: " + _parts[i].ToString() + "\n";
            }

            return str + "END OF MANUAL OF PRODUCT A2" + "\n";
        }
    }
}