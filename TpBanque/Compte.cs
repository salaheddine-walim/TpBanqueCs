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
        private readonly Client titulaire;
        private MAD solde;

        public Compte(Client c)
        {
            num_compte = ++cpt;
            this.titulaire = c;
            solde = new MAD(0);
        }
        static Compte()
        {
            plafond = new MAD(2000);
            cpt = 0;
        }

        public bool debiter(MAD somme)
        {
            if (somme > new MAD(0) )
            {
                if (solde.comparer(somme) && plafond.comparer(somme))
                {
                    this.solde -=somme;
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
            if (somme > new MAD(0))
            {
                this.solde += somme;
                return true;
            }
            Console.WriteLine("impossible !!! somme negatif");
            return false;
        }

        public bool verser(Compte c,MAD somme)
        {
            if (this.debiter(somme) && c.crediter(somme))
                return true;
            return false;
        }

        public void consulter()
        {
            Console.WriteLine("Compte : "+num_compte);
            this.titulaire.afficher();
            this.solde.afficher();
        }
    }
}
