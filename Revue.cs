namespace AppConsoleLivres
{
    public class Revue : Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }


        public Revue(string titre, string auteur, int nombrePages, int numero, int annee) : base(titre, nombrePages,auteur) 
        {
            Numero = numero;
            Annee = annee;


        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur : {Auteur}, Nombredepages : {NombrePages}, Numero : {Numero} , Anee : {Annee}");

        }






    }
}
