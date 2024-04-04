using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.TP.POO.Models
{
    public class Operation
    {
        public enum OperationType { Credit, Debit }

        public decimal Montant { get; set; }    
        public OperationType TypeMouvement { get; set; }

      
    }
}
