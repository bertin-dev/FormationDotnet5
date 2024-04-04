using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.DesignPatterns.Creation._2_Factory_method
{
    // Fabrique abstraite
    public abstract class Factory
    {
        public abstract IProduct CreateProduct();
    }
}
