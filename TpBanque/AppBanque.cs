using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    class AppBanque
    {
        public void test()
        {
            Client c = new Client("Salaheddine", "Walim", "Mabrouka");
            Compte salah = new CompteCourant(new MAD(1000),c);
            Compte elon = new CompteEpargne(c, 3);

            salah.crediter(new MAD(2000));
            elon.crediter(new MAD(10000));
            elon.debiter(new MAD(200));
            salah.verser(elon, new MAD(300));

            c.afficherListeComptes();
        }
    }
}
