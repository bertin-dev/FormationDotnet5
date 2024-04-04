using FormationDotnet5.DesignPatterns.Creation._3_Abstract_factory;
using FormationDotnet5.DesignPatterns.Creation.Singleton1;
using System;
using System.Collections.Generic;
using FormationDotnet5.delegates;
using FormationDotnet5.TP.POO;
using FormationDotnet5.Structure;

namespace FormationDotnet5
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Appel du design pattern singleton et verification si les 2 instances de singleton pointent vers le même objet
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton1 == singleton2);
            singleton1.Add("time", DateTime.Now); 
            Console.WriteLine(singleton2.Get("time"));


            //Abstract Factory
            var customer = new Customer();
            var customerVIP = new Customer { Orders = new int[50] };

            IVIPShppingFactory factory1 = GetFactory(customer);
            IVIPShppingFactory factory2 = GetFactory(customerVIP);


            var shoppingCard1 = new ShoppingCard(factory1);
            Console.WriteLine("Shopping cart 1");
            shoppingCard1.PasserCommande();

            var shoppingCard2 = new ShoppingCard(factory2);
            Console.WriteLine("Shopping cart 2");
            shoppingCard2.PasserCommande();


            int[] tableau = new int[] { 4, 1, 6, 10, 8, 5 };
            new TrieurDeTableau().DemoTri(tableau);
            
            
            //utilisation du mot clé yield
            //lorsqu'il est asscié à return, il permet de renvoyer un élément d'une collection et passer à l'élément suivant
            foreach (string prenom in ObtenirListeDePrenoms())
            {
                Console.WriteLine(prenom);
            }


            /*#region TP POO
            Account CurrentAccountNicolas = new CurrentAccount(2000) { Owner = "Nicolas" };
            Account SavingsAccountNicolas = new SavingsAccount(2) { Owner = "Nicolas" };
            Account CurrentAccountGeremi = new CurrentAccount(500) { Owner = "Geremi" };


            CurrentAccountNicolas.Crediter(100);     //salaire
            CurrentAccountNicolas.Dediter(50); //  achat carburant    

            //CurrentAccountNicolas.Dediter(20);   //debit du compte courrant pour créditer le compte d'epargne
            SavingsAccountNicolas.Crediter(20, CurrentAccountNicolas);  //crédter le compte epargne de 20euro

            SavingsAccountNicolas.Crediter(100);    //il reçoit un cadeau de la banque de 100€
            SavingsAccountNicolas.Dediter(20, CurrentAccountNicolas);  //Il remet ses 20€ sur son compte bancaire


            CurrentAccountGeremi.Dediter(500);     //Jérémie achète un nouveau PC : 500€
            CurrentAccountGeremi.Dediter(200, CurrentAccountNicolas);     //il rembourse ses dettes à Nicolas : 200€
            //CurrentAccountNicolas.Crediter(100);    //il reçoit un rembourssement de 200€

            Console.WriteLine("Résumé du compte de Nicolas");
            CurrentAccountNicolas.AccountState();
            Console.WriteLine("\n");

            Console.WriteLine("Résumé du compte épargne de Nicolas");
            SavingsAccountNicolas.AccountState();
            Console.WriteLine("\n");

            #endregion*/


            #region Strucure

            Person person = new Person() { Age = 17, Prenom = "Bertin" };
            Console.WriteLine(person.ToString());
            FaitVieillir(ref person);
            Console.WriteLine(person.Age);


            #endregion
        }
        private static void FaitVieillir(ref Person person)
        {
            person.Age++;
        }

        private static IVIPShppingFactory GetFactory(Customer customer)
        {
            if(customer.Orders.Length > 20)
            {
                return new VIPShoppingFactory();
            }
            return new StandardShoppingFactory();
        }

        
        public static IEnumerable<string> ObtenirListeDePrenoms()
        {
            yield return "Nicolas";
            yield return "Jérémie";
            yield return "Delphine";
        }



        //REQUETE LINQ
        //LinkToObject.clientLinqFilter();
    }
}
