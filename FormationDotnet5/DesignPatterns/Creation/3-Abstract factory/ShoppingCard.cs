using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.DesignPatterns.Creation._3_Abstract_factory
{
    public class ShoppingCard
    {
        private readonly IVIPShppingFactory vIPShppingFactory;
        public ShoppingCard(IVIPShppingFactory shppingFactory) {
            this.vIPShppingFactory = shppingFactory;
        }
        public void PasserCommande()
        {
            var priority = vIPShppingFactory.GetPriorite().Priorite;
            var pourcentage = vIPShppingFactory.GetReduction().PourcentageReduction;

            Console.WriteLine("Priorite = " + priority);
            Console.WriteLine("Pourcentage = " + pourcentage);
        }
    }
}
