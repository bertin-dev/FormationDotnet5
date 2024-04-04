using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5
{
    public class Chien : Animal
    {
        public override void manger()
        {
            Console.WriteLine("Demarrage");
            base.manger();
            Console.WriteLine("Jai fini");
        }
    }
}
