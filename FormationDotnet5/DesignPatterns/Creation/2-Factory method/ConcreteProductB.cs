using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.DesignPatterns.Creation._2_Factory_method
{
    // Implémentation concrète d'un autre produit
    public class ConcreteProductB : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Operation from ConcreteProductB");
        }
    }
}
