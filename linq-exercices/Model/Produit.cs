using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_exercices.Model
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Categorie { get; set; }
        public decimal Prix { get; set; }
        public int Stock { get; set; }
    }
}
