using System.Collections.Generic;
using System;
using System.Linq;

namespace FormationDotnet5.Linq
{
    public static class LinkToObject
    {
        public static void calculAndFilterLinq()
        {
           List<int> _list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
            //1ere méthode de filtre
            foreach (int i in _list) {
            if (i > 5) {
                Console.WriteLine(i);
            }
        }


            IEnumerable<int> maList = from j in _list
                where j > 5
                select j;

            foreach (var k in maList)
            {
                Console.WriteLine(k);
            }
        }

        public static void clientLinqFilter()
        {
            List<Client> listeClients = new List<Client>
            {
                new Client { Identifiant = 1, Nom = "Nicolas", Age = 30},
                new Client { Identifiant = 2, Nom = "Jérémie", Age = 20},
                new Client { Identifiant = 3, Nom = "Delphine", Age = 30},
                new Client { Identifiant = 4, Nom = "Bob", Age = 10}
            };
            
            List<Commande> listeCommandes = new List<Commande>
            {
                new Commande{ Identifiant = 1, IdentifiantClient = 1, Prix = 150.05M},
                new Commande{ Identifiant = 2, IdentifiantClient = 2, Prix = 30M},
                new Commande{ Identifiant = 3, IdentifiantClient = 1, Prix = 99.99M},
                new Commande{ Identifiant = 4, IdentifiantClient = 1, Prix = 100M},
                new Commande{ Identifiant = 5, IdentifiantClient = 3, Prix = 80M},
                new Commande{ Identifiant = 6, IdentifiantClient = 3, Prix = 10M},
            };
            
            // IEnumerable<string> requete = from client in listeClients
            var requete = from client in listeClients
                where client.Age > 18
                orderby client.Age, client.Nom
                //select client.Nom;
                select new { client.Nom, client.Age  };

            foreach (var obj in requete)
            {
                //Console.WriteLine(obj);
                Console.WriteLine("{0} a {1} ans", obj.Nom, obj.Age);
            }
            
            
            //jointure entre commandes et clients

            var jointure = from commande in listeCommandes
                join client in listeClients
                    on commande.IdentifiantClient equals client.Identifiant
                select new {client.Nom, commande.Prix};

            foreach (var item in jointure)
            {
                Console.WriteLine("Le client {0} a payé {1}", item.Nom, item.Prix);
            }
            
            
            
            
            
            //into
            var liste = from commande in listeCommandes
                join client in listeClients on commande.IdentifiantClient equals client.Identifiant
                group commande by new {commande.IdentifiantClient, client.Nom} into commandesGroupees
                select
                    new
                    {
                        commandesGroupees.Key.IdentifiantClient,
                        commandesGroupees.Key.Nom,
                        NombreDeCommandes = commandesGroupees.Count()
                    };

            foreach (var element in liste)
            {
                Console.WriteLine("Le client {0} ({1}) a réalisé {2} commande(s)", element.Nom, element.IdentifiantClient, element.NombreDeCommandes);
            }
            
            
            
            //let
            var liste1 = from commande in listeCommandes
                join client in listeClients on commande.IdentifiantClient equals client.Identifiant
                group commande by new {commande.IdentifiantClient, client.Nom} into commandesGroupees
                let total = commandesGroupees.Sum(c => c.Prix)
                where total > 50
                orderby total
                select new
                {
                    commandesGroupees.Key.IdentifiantClient,
                    commandesGroupees.Key.Nom,
                    NombreDeCommandes = commandesGroupees.Count(),
                    PrixTotal = total
                };

            foreach (var element in liste1)
            {
                Console.WriteLine("Le client {0} ({1}) a réalisé {2} commande(s) pour un total de {3}", element.Nom, element.IdentifiantClient, element.NombreDeCommandes, element.PrixTotal);
            }
        }
    }
    
}