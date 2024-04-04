using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5
{
    public class Animal
    {
        public virtual void manger()
        {
            Console.WriteLine("je suis entrain de manger");
            Console.WriteLine("Ensuite je vais me reposer");
        }
    }
    
}
