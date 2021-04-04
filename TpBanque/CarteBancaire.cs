using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    class CarteBancaire
    {
        static int cpt;
        int code;
        string type;
        public CarteBancaire(string type)
        {
            this.code = ++cpt;
            this.type = type;
        }

    }
}
