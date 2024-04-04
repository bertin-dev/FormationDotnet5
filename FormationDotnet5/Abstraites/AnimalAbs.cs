using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.Abstraites
{
    public abstract class AnimalAbs
    {

        private Coeur coeur;

        public AnimalAbs()
        {
            coeur = new Coeur();
        }

        public abstract void SeDeplacer();

        public void Mourir()
        {
            coeur.Stop();
        }

    }
}
