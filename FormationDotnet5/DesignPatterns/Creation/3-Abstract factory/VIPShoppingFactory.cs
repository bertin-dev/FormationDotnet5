using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.DesignPatterns.Creation._3_Abstract_factory
{
    public class VIPShoppingFactory : IVIPShppingFactory
    {
        public IPrioriteCommand GetPriorite()
        {
            return new VIPPrioriteCommand();
        }

        public IPourcentageReduction GetReduction()
        {
            return new VIPPourcentageReduction();
        }
    }
}
