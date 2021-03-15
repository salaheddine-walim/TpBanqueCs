using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    class CompteEpargne : Compte
    {
        private double TauxInteret;
        public CompteEpargne(Client c,double t ):base(c)
        {
            this.TauxInteret = t;
        }
        public void calculInteret()
        {
            this.solde *= TauxInteret;
        }

    }
}
