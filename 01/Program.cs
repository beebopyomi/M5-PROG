namespace _01;

class Program
{
    public static int score = 67;
    public static int leven = 100;
    static void Main(string[] args)
    {
        Console.WriteLine("Welkom gebruiker.");
        Console.WriteLine("Wat is jou naam jongen man?");
        string naam = Console.ReadLine();
        Console.WriteLine("mhm, mhm... ok...");
        Console.WriteLine("en uhh... leef je wel?? Wel of Niet...?");
        string leeft = Console.ReadLine();
        Console.WriteLine("ok dus jij bent...");
        Console.WriteLine(naam);
        Console.WriteLine("ok jou hart klopt dus " + leeft);
        Console.WriteLine(score);
        if (leeft == "nee")
        {
            leven = 0;
        }
        Console.WriteLine("jou leven's scoren is nu... " + leven);
    }
}
