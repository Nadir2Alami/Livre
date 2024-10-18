using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        Revue revue1 = new Revue("la fin ", "Nadir alami", 10, 20, 2004);
        Revue revue2 = new Revue("Le debut", "Alaoui Nabil", 11, 21, 2003);
        Revue revue3 = new Revue("le milieu", "Ali Nasser", 12, 22, 2002);

        revue1.AfficherDetails();
        revue2.AfficherDetails();
        revue3.AfficherDetails();




           
    }
}