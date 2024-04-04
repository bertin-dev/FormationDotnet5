using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.DesignPatterns.Creation._2_Factory_method
{
    // Implémentation concrète de la fabrique
    public class ConcreteFactory : Factory
    {
        public override IProduct CreateProduct()
        {
            // Logique de création du produit
            return new ConcreteProductA();
        }
    }
}
