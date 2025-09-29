using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_exercices.Model
{
    public class Commande
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public DateTime DateCommande { get; set; }
        public decimal MontantTotal { get; set; }
    }
}
