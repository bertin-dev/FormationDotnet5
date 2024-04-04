using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.Interfaces
{
    public class Oiseau : IVolant
    {
        public int NombrePropulser { get; set; }

        public void Voler()
        {
            Console.WriteLine("Je vole grâce à " + NombrePropulser + " ailes");
        }
    }
}
