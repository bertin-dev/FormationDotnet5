using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FormationDotnet5.TP.POO.Models.Operation;

namespace FormationDotnet5.TP.POO
{
    public class SavingsAccount : Account
    {
        public double TauxAbonnement { get; set; }

        public SavingsAccount(double taux)
        {
            TauxAbonnement = taux/100;
        }

        protected override decimal Solde => base.Solde * (decimal)(1 + TauxAbonnement);

        public override void AccountState()
        {
            Console.WriteLine("Résumé du compte épargne de {0}", this.Owner);
            Console.WriteLine("########################################################");
            Console.WriteLine("Compte épargne Entreprise de {0}", this.Owner);
            Console.WriteLine("Solde : {0}", this.Solde);
            Console.WriteLine("Taux : {0}", this.TauxAbonnement);
            Console.WriteLine("Opérations : ");
            foreach (var item in this.OperationsList)
            {
                if(item.TypeMouvement == OperationType.Credit)
                {
                    Console.WriteLine("\t +");
                }
                else
                {
                    Console.WriteLine("\t -");
                }
                Console.WriteLine("{0} ", item.Montant);
            }
            Console.WriteLine("########################################################");
        }
    }
}
