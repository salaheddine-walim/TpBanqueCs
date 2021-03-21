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
        public List<Compte> liste_comptes;

        public Client( string nom,string prenom,string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            liste_comptes = new List<Compte>();
        }

        public void afficherListeComptes()
        {
            Console.WriteLine($"Liste des comptes du client : {nom} {prenom}");
            foreach (Compte c in liste_comptes)
            {
                c.consulter();
                c.afficher_opeartions();
                Console.WriteLine();
            }
        }
        public void afficher()
        {
            Console.WriteLine($"Client: nom = {nom} prenom = {prenom} adresse = {adresse} ");
        }
    }
}
