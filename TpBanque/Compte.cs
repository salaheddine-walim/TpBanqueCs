using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    class Compte
    {
        private static MAD plafond;
        private static int cpt;
        private int num_compte;
        protected readonly Client titulaire;
        protected MAD solde;
        private List<Operation> lop;

        public Compte(Client c)
        {
            num_compte = ++cpt;
            this.titulaire = c;
            solde = new MAD(0);
            lop = new List<Operation>();
            c.liste_comptes.Add(this);
        }
        static Compte()
        {
            plafond = new MAD(2000);
            cpt = 0;
        }

        public bool debiter(MAD somme)
        {
            string op = "Debitement";
            if (somme > new MAD(0) )
            {
                if (solde.comparer(somme) && plafond.comparer(somme))
                {
                    this.solde -=somme;
                    lop.Add(new Operation(op, somme,true));
                    return true;
                }
                else if(somme > plafond)
                {
                    Console.WriteLine("valeur superieur au plafond");
                    return false;
                }
                else
                {
                    Console.WriteLine("impossible !!! somme insuffisant");
                    return false;
                }
            }
            Console.WriteLine("impossible !!! somme negatif");
            return false;
        }

        public bool crediter(MAD somme)
        {
            string op = "Creditement";
            if (somme > new MAD(0))
            {
                this.solde += somme;
                lop.Add(new Operation(op, somme,false));
                return true;
            }
            Console.WriteLine("impossible !!! somme negatif");
            return false;
        }

        public bool verser(Compte c,MAD somme)
        {
            if (this.debiter(somme) && c.crediter(somme))
            {
                return true;
            }
            return false;
        }

        public void consulter()
        {
            Console.WriteLine("Compte : "+num_compte);
            this.titulaire.afficher();
            this.solde.afficher();
        }

        public void afficher_opeartions()
        {
            if (lop.Count > 0)
            {
                Console.WriteLine("\nListe des operations");
                foreach (Operation operation in lop)
                {
                    operation.afficher();
                }
                return;
            }
            Console.WriteLine("\nCompte vierge");
        }
    }
}
