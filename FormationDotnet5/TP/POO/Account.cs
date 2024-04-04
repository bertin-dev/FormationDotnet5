using FormationDotnet5.TP.POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FormationDotnet5.TP.POO.Models.Operation;



namespace FormationDotnet5.TP.POO
{                                                             
    public abstract class Account
    {
        public string Owner { get; set; }

        protected List<Operation> OperationsList;

        protected virtual decimal Solde {

            get
            {
                decimal total = 0;

                foreach(Operation operation in OperationsList)
                {
                    if(OperationType.Credit == operation.TypeMouvement)
                    {
                        total += operation.Montant;
                    }
                    else
                    {
                        total -= operation.Montant;
                    }
                }

                return total;
            } 
        
        }

        protected Account()
        {
            OperationsList = new List<Operation>();
        }

        public void Crediter(decimal somme)
        {
            OperationsList.Add(new Operation() { Montant = somme, TypeMouvement = OperationType.Credit });
        }

        public void Crediter(decimal somme, Account account2)
        {
            Crediter(somme);        //créditer le compte
            Dediter(somme, account2);  //débite le compte passé en paramètres 
        }

         public void Dediter(decimal somme)
         {
            OperationsList.Add(new Operation() { Montant = somme, TypeMouvement = OperationType.Debit });
         }

         public void Dediter(decimal somme, Account account2)
         {
             Dediter(somme);        //débit le compte courant
             Crediter(somme, account2);  //crédit le compte passé en parametre
         }

        public abstract void AccountState();
    }
}


