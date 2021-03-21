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
            if (t >= 0 && t <= 100)
            {
                this.TauxInteret = t;
            }
            else
                throw new Exception("Taux d'interet non valide");
        }
        public void calculInteret()
        {
            this.solde =solde+(solde*TauxInteret);
        }

    }
}
