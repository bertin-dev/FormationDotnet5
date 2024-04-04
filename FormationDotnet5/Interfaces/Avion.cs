using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.Interfaces
{
    internal class Avion : IVolantMotorise
    {
        public int NombrePropulser { get; set; }

        public void DemarrerLeMoteur()
        {
            throw new NotImplementedException();
        }

        public void Voler()
        {
            Console.WriteLine("Je vole grâce à " + NombrePropulser + " moteurs");
        }
    }
}
