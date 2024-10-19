using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        Revue revue1 = new Revue("la fin ", "Nadir alami", 10 , 20, 2004);
        Revue revue2 = new Revue("Le debut", "Alaoui Nabil", 11 , 21, 2003);
        Revue revue3 = new Revue("le milieu", "Ali Nasser", 12 , 22, 2002);

        revue1.AfficherDetails();
        revue2.AfficherDetails();
        revue3.AfficherDetails();

        Roman R1 = new Roman("boiteamarveille", "Personn1", 10, "Triste");
        Roman R2 = new Roman("Dernier_Jour", "Personn2", 101, "Amusante");

        Roman R3 = new Roman("Antigone", "Personn3", 120, "Tragique");


        R1.AfficherDetails();
        R2.AfficherDetails();
        R3.AfficherDetails();




        List<Livre> livres = new List<Livre>();
        livres.Add(revue1);
        livres.Add(revue2);
        livres.Add(revue3);
        livres.Add(R1);
        livres.Add(R2);
        livres.Add(R3);
        foreach (Livre livre in livres)
        {
            livre.AfficherDetails();

        }
        











    }
}