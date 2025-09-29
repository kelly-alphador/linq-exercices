using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using linq_exercices.Model;

namespace linq_exercices
{
    public class Solution
    {
        public void ExerciceJour1()
        {
            //Récupérer tous les clients habitant à Paris.
            var ClientParis = Donnees.Clients.Where(p => p.Ville == "Paris");
            //Trier les clients par nom croissant.
            var ClientCroissant = Donnees.Clients.OrderBy(p => p.Nom);
            //Sélectionner seulement le Nom et Email des clients.
            var NomEmail = Donnees.Clients.Select(c => new { c.Nom,c.Email });
            //Grouper les produits par catégorie.
            var GroupProdCategorie = Donnees.Produits.GroupBy(p => p.Categorie);
            //Lister les commandes avec le nom du client.
            var CommandeNomCLient = Donnees.Commandes.Join(Donnees.Clients, co => co.IdClient, cli => cli.Id, (co, cli) => new
            {
                co.Id,
                cli.Nom
            });
            //Récupérer les 5 premiers clients.
            var CinqProduit = Donnees.Produits.Take(5);
            //Trouver les clients dont le nom commence par "A".
            var ClientCommenceA = Donnees.Clients.Where(cli => cli.Nom.StartsWith("A"));
            //Calculer le prix moyen des produits.
            var PrixMoyen = Donnees.Produits.Average(p => p.Prix);
            //Ajouter un nouveau client.
            var newClient = new Client
            {
                Id = Donnees.Clients.Max(c=>c.Id)+1,
                Nom = "Dupont",
                Prenom = "Jean",
                Email = "jean.dupont@gmail.com",
                Ville = "Paris",
                DateInscription = new DateTime(2020, 5, 12)
            };
            Donnees.Clients.Add(newClient);
        }
    }
}
