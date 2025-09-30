using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_exercices
{
    public class Solution
    {
        public void ExercicesJour2()
        {
            //Trouver tous les produits dont le prix est supérieur à 100.
            var prodSupCent = Donnees.Produits.Where(p => p.Prix > 100);
            //Trier les produits par prix décroissant.
            var prodPrixDecrroissant=Donnees.Produits.OrderByDescending(p => p.Prix);
            //Projeter uniquement le Nom et Prix des produits.
            var prodNomPrix = Donnees.Produits.Select(p => new {p.Nom,p.Prix});
            //Grouper les clients par ville.
            var ClientParVille = Donnees.Clients.GroupBy(c => c.Ville);
            //Lister les lignes de commande avec nom du produit.
            var LigneCommandeProd = Donnees.LignesCommande.Join(Donnees.Produits, l => l.IdProduit, p => p.Id, (l, p) => new{ l.IdProduit,p.Nom } );
            //Ignorer les 10 premiers produits et afficher le reste.
            var prod = Donnees.Produits.Skip(10);
            //Rechercher les emails contenant "yahoo".
            var EmailYahoo = Donnees.Clients.Where(c => c.Email.Contains("yahoo"));
            //Trouver le produit le plus cher.
            var ProduitCher=Donnees.Produits.OrderByDescending(p=>p.Prix).FirstOrDefault();
            //Supprimer un client donné.
            var clientASupprimer = Donnees.Clients.FirstOrDefault(c => c.Id == 1);
            Donnees.Clients.Remove(clientASupprimer);
        }
    }
}
