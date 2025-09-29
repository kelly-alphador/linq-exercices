using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using linq_exercices.Model;

namespace linq_exercices
{
    //POUR QUOI ON MET STATIC ?
    //On n’a pas besoin d’instancier la classe pour accéder à ses membres. donc on est pas oblige de faire new
    public static class Donnees
    {
        public static List<Client> Clients = new List<Client>
        {
            new Client { Id = 1, Nom = "Dupont", Prenom = "Jean", Email = "jean.dupont@gmail.com", Ville = "Paris", DateInscription = new DateTime(2020, 5, 12) },
            new Client { Id = 2, Nom = "Martin", Prenom = "Sophie", Email = "sophie.martin@yahoo.fr", Ville = "Lyon", DateInscription = new DateTime(2021, 3, 8) },
            new Client { Id = 3, Nom = "Durand", Prenom = "Paul", Email = "paul.durand@outlook.com", Ville = "Marseille", DateInscription = new DateTime(2019, 11, 23) },
            new Client { Id = 4, Nom = "Bernard", Prenom = "Alice", Email = "alice.bernard@gmail.com", Ville = "Paris", DateInscription = new DateTime(2022, 7, 15) },
            new Client { Id = 5, Nom = "Petit", Prenom = "Lucas", Email = "lucas.petit@gmail.com", Ville = "Toulouse", DateInscription = new DateTime(2023, 2, 1) }
        };

        public static List<Produit> Produits = new List<Produit>
        {
            new Produit { Id = 1, Nom = "Ordinateur Pro X", Categorie = "Informatique", Prix = 1200, Stock = 5 },
            new Produit { Id = 2, Nom = "Smartphone Ultra", Categorie = "Électronique", Prix = 800, Stock = 10 },
            new Produit { Id = 3, Nom = "Casque Audio", Categorie = "Électronique", Prix = 150, Stock = 20 },
            new Produit { Id = 4, Nom = "Clavier Mécanique", Categorie = "Informatique", Prix = 90, Stock = 15 },
            new Produit { Id = 5, Nom = "Télévision 4K", Categorie = "Électronique", Prix = 700, Stock = 3 },
            new Produit { Id = 6, Nom = "Chaise Bureau", Categorie = "Mobilier", Prix = 200, Stock = 8 },
            new Produit { Id = 7, Nom = "Table Gaming", Categorie = "Mobilier", Prix = 350, Stock = 2 }
        };

        public static List<Commande> Commandes = new List<Commande>
        {
            new Commande { Id = 1, IdClient = 1, DateCommande = new DateTime(2023, 1, 10), MontantTotal = 1350 },
            new Commande { Id = 2, IdClient = 2, DateCommande = new DateTime(2023, 2, 5), MontantTotal = 800 },
            new Commande { Id = 3, IdClient = 1, DateCommande = new DateTime(2023, 3, 15), MontantTotal = 240 },
            new Commande { Id = 4, IdClient = 3, DateCommande = new DateTime(2023, 4, 20), MontantTotal = 700 },
            new Commande { Id = 5, IdClient = 4, DateCommande = new DateTime(2023, 5, 25), MontantTotal = 550 }
        };

        public static List<LigneCommande> LignesCommande = new List<LigneCommande>
        {
            new LigneCommande { Id = 1, IdCommande = 1, IdProduit = 1, Quantite = 1, PrixUnitaire = 1200 },
            new LigneCommande { Id = 2, IdCommande = 1, IdProduit = 3, Quantite = 1, PrixUnitaire = 150 },
            new LigneCommande { Id = 3, IdCommande = 2, IdProduit = 2, Quantite = 1, PrixUnitaire = 800 },
            new LigneCommande { Id = 4, IdCommande = 3, IdProduit = 4, Quantite = 2, PrixUnitaire = 90 },
            new LigneCommande { Id = 5, IdCommande = 3, IdProduit = 6, Quantite = 1, PrixUnitaire = 60 },
            new LigneCommande { Id = 6, IdCommande = 4, IdProduit = 5, Quantite = 1, PrixUnitaire = 700 },
            new LigneCommande { Id = 7, IdCommande = 5, IdProduit = 3, Quantite = 2, PrixUnitaire = 150 },
            new LigneCommande { Id = 8, IdCommande = 5, IdProduit = 6, Quantite = 1, PrixUnitaire = 250 },
            new LigneCommande { Id = 9, IdCommande = 5, IdProduit = 7, Quantite = 1, PrixUnitaire = 150 }
        };
    }
}
