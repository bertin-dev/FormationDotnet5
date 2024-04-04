using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.Interfaces
{
    public class Voiture : IComparable
    {
        public string Marque { get; set; }
        public string Vitesse { get; set; }


        public int CompareTo(object obj)
        {
            Voiture voiture = obj as Voiture;
            return Vitesse.CompareTo(voiture.Vitesse);
        }
    }
}
