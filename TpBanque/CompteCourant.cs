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

    }
}
