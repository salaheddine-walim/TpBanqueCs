using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    class Devise:IEuro,IDollar
    {
        double valeur;
        double valEuro=10.5,valDollar=9.80;
        public Devise(double val)
        {
            this.valeur = val;
        }
        public Devise toDollar(MAD somme) => new Devise(somme.conversion(valDollar));
        public Devise toEuro(MAD somme) => new Devise(somme.conversion(valEuro));

    }
}
