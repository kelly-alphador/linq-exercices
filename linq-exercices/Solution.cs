using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_exercices
{
    public class Solution
    {
        public void ExercicesJour3()
        {
            //Récupérer toutes les commandes effectuées en 2024.
            var commandes = Donnees.Commandes.Where(c => c.DateCommande.Year == 2024);
            //Trier les commandes par date la plus récente d’abord
            var commanderecente = Donnees.Commandes.OrderByDescending(c => c.DateCommande);
            //Récupérer uniquement l’Id et Date des commandes
            var IdDateCommande = Donnees.Commandes.Select(c => new { c.Id, c.DateCommande });
            //Grouper les commandes par année
            var commande = Donnees.Commandes.GroupBy(c => c.DateCommande.Year);
            //Associer commandes et clients.
            var commandeClient = Donnees.Commandes.Join(Donnees.Clients, com => com.IdClient, cli => cli.Id, (com, cli) => new { com.Id, cli.Nom });
            //Récupérer les 3 commandes les plus récentes.
            var Troiscommande=commanderecente.Take(3).ToList();
            //Trouver les produits contenant "Pro" dans le nom.
            var ProduitPro = Donnees.Produits.Where(p => p.Nom.Contains("Pro"));
            //Trouver le produit le moins cher.
            var Produitcher=Donnees.Produits.OrderBy(p=>p.Prix).FirstOrDefault();
            
           
        }
    }
}
