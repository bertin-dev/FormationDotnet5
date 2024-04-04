using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.Structure
{
    public struct Person
    {
        public string Prenom { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Prenom + " a " + Age + " ans";
        }

    }
}
