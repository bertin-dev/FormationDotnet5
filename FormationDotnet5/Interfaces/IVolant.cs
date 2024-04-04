using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.Interfaces
{
    public interface IVolant
    {
        public int NombrePropulser { get; set; }
        void Voler();
    }
}
