using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.Abstraites
{
    public class ChienAbs : AnimalAbs
    {
        public override void SeDeplacer()
        {
            Console.WriteLine("Je me déplace en marchant sur mes 4 pattes");
        }
    }
}
