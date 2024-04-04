using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.Abstraites
{
    public class Coeur
    {
        public void Battre()
        {
            Console.WriteLine("Boom Boom");
        }

        public void Stop()
        {
            Console.WriteLine("Mon coeur a arrêter de battre");
        }
    }
}
