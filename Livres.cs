using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    public class Livre
    {
        public string Titre {  get; set; }
        public string Auteur { get; set; }
        public int NombrePages { get; set; }

        public Livre(string titre, int nombrePages, string auteur)
        {

            Titre = titre;
            NombrePages = nombrePages;
            Auteur = auteur;

        }
        public void AfficherDetails()
        {
            Console.WriteLine($"Titre:{Titre},Auteur : {Auteur}, Nombredepages : {NombrePages}");
        }


    }
}
