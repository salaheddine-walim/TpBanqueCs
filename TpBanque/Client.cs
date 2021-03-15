using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    class Client
    {
        protected  readonly string nom;
        protected readonly string prenom;
        private  string adresse;

        public Client( string nom,string prenom,string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
        }

        public void afficher()
        {
            Console.WriteLine($"Client: nom= {nom} prenom = {prenom} adresse = {adresse} ");
        }
    }
}
