using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    class MAD
    {
        private double valeur;

        public MAD(double val)
        {
            this.valeur = val;
        }
        public void afficher()
        {
            Console.WriteLine(valeur+" MAD");
        }

        public static MAD operator-(MAD somme1,MAD somme)
        {
            return new MAD(somme1.valeur - somme.valeur);
        }
        public static MAD operator+(MAD somme1, MAD somme)
        {
            return new MAD(somme1.valeur + somme.valeur);
        }
        public static bool operator >(MAD m,MAD m2)
        {
            return m.valeur - m2.valeur > 0;
        }
        public static bool operator <(MAD m,MAD m2)
        {
            return m.valeur - m2.valeur < 0;
        }

        public bool comparer(MAD somme)
        {
            return this.valeur - somme.valeur >= 0;
        }

    }
}
