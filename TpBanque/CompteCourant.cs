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
        public CompteCourant(MAD decouvert,Client c):base(c)
        {
            this.decouvert = decouvert;
        }

        public override bool debiter(MAD somme)
        {
            string op = "Debitement";
            if (somme > new MAD(0))
            {
                if (solde.comparer(somme+decouvert))
                {
                    this.solde -= somme;
                    lop.Add(new Operation(op, somme, true));
                    return true;
                }
                else
                {
                    Console.WriteLine("impossible !!! Decouvert ");
                    return false;
                }
            }
            Console.WriteLine("impossible !!! somme negatif");
            return false;
        }


    }
}
