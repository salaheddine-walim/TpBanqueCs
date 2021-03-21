using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    class Operation
    {
        public static int cpt=20165;
        public int ref_op;
        public DateTime date_op;
        public string libelle;
        public MAD montant;
        public bool minus;
        public Operation(string libelle,MAD montant,bool minus)
        {
            this.ref_op = ++cpt;
            this.date_op = DateTime.Now;
            this.libelle = libelle;
            this.montant = montant;
            this.minus = minus;
        }

        public void afficher()
        {
            string type = minus?"-":"";
            Console.Write($"Exemple : {date_op.ToShortDateString()} | n {ref_op} ||{type}");
            montant.afficher();
        }
    }
}
