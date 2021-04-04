using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    class CompteCourant:Compte
    {
        private MAD decouvert;
        private CarteBancaire carteBancaire;
        public CompteCourant(MAD decouvert,Client c,CarteBancaire carteBancaire=null):base(c)
        {
            this.decouvert = decouvert;
            this.carteBancaire = carteBancaire;
        }

        public override bool debiter(MAD somme)
        {
            string op = "Debitage";
            if (somme > new MAD(0))
            {
                if (this.comparer(somme+decouvert))
                {
                    this.minus(somme);
                    lop.Add(new Operation(op, somme, true));
                    return true;
                }
                else
                {
                    Console.WriteLine("impossible !!! Decouvert");
                    return false;
                }
            }
            Console.WriteLine("impossible !!! somme negatif");
            return false;
        }


    }
}
