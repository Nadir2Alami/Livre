using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    public class Roman : Livre
    {
        public string Genre { get; set; }

        public Roman(string titre,string auteur,int nombrePages ,string genre ):base(titre,nombrePages,auteur)
        {
            Genre = genre;

        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"Titre : {Titre} , Auteur : {Auteur}, Nombredepages : {NombrePages}, Genre : {Genre}");
        }
    }   
}
