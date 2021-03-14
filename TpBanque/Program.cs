using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TpBanque
{
    class Program
    {
        //public static  List<Compte> lc = new List<Compte>();
        //static public void menu()
        //{
        //    Console.WriteLine("----------------Menu------------------");
        //    Console.WriteLine(" 1-crediter un compte");
        //    Console.WriteLine(" 2-debiter un compte");
        //    Console.WriteLine(" 3-verser vers un compte");
        //}
        //private static void verser()
        //{
        //    throw new NotImplementedException();
        //}

        //private static void debiterCompte()
        //{
        //    throw new NotImplementedException();
        //}

        //private static void crediterCompte()
        //{
        //    for (int i = 0; i < Program.lc.Count; i++)
        //    {
        //        Console.WriteLine($"{i} - {Program.lc[i].ToString()}");
        //    }
        //}


        static void Main(string[] args)
        {
            Client c = new Client("Salaheddine", "Walim", "Mabrouka");
            Client c2 = new Client("Elon", "Musk", "Nevada");
            Compte salah = new Compte(c);
            Compte elon = new Compte(c2);

            salah.crediter(new MAD(2000));
            salah.consulter();

            elon.consulter();
            elon.crediter(new MAD(1200000000));
            elon.consulter();
            elon.verser(salah, new MAD(12000));
            elon.consulter();

            Console.ReadKey();

            //Program.lc.Add(salah);
            //Program.lc.Add(elon);
            //string continuer;
            //int choix = 0;
            //do
            //{
            //    Program.menu();
            //    choix = int.Parse(Console.ReadLine());
            //    switch (choix)
            //    {
            //        case 1:
            //            Program.crediterCompte();
            //            break;
            //        case 2:
            //            Program.debiterCompte();
            //            break;
            //        case 3:
            //            Program.verser();
            //            break;

            //        default:
            //            break;
            //    }


            //    Console.WriteLine("y pour continuer, n pour quitter ");
            //    continuer = Console.ReadLine();
            //} while (continuer == "y");


        }
    }
}
