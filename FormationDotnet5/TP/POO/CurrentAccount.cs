using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FormationDotnet5.TP.POO.Models.Operation;

namespace FormationDotnet5.TP.POO
{
    public class CurrentAccount : Account
    {

        public decimal DecouvertAutorise { get; }
        public CurrentAccount(decimal decouvert)
        {
            DecouvertAutorise = decouvert;
        }

        public override void AccountState()
        {
            Console.WriteLine("Résumé du compte de {0}", this.Owner);
            Console.WriteLine("*******************************************");
            Console.WriteLine("Compte courant de {0}", this.Owner);
            Console.WriteLine("Solde: {0}", this.Solde);
            Console.WriteLine("Découvert autorisé : {0}", this.DecouvertAutorise);
            Console.WriteLine("Opérations : ");
            foreach (var item in this.OperationsList) 
            {
                if (item.TypeMouvement == OperationType.Credit)
                {
                    Console.WriteLine("\t +");
                }
                else
                {
                    Console.WriteLine("\t -");
                }
                Console.WriteLine("{0} ", item.Montant);
            }
            Console.WriteLine("*******************************************");
        }
    }
}
