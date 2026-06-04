namespace MiniSistemZaRadUBiblioteci;

public class Strip : Knjiga , IPozajmljivo
{
    public Strip(string naslov, string autor, int godina) : base(naslov , autor , godina)
    {
        
    }
    public override string PrikaziInfo()
    {
        return $"Strip: {naslov} \n, Autor: {autor} \n , Proizveden i izdat: {godina} \n";
    }
    
    public void Pozajmi()
    {
        Console.WriteLine($"da li zelis da pozajmis {naslov} strip?");
        string odgovor = Console.ReadLine();
        List<string> odgovori = new List<string>()
        {
            "da" , "Da" , "DA" , "Hocu" , "hocu" , "Ocu" , "Ocu" , "Moze" , "moze"
        };
        List<string> negOdgovori = new List<string>()
        {
            "ne" , "Ne" , "NE" , "Necu" , "necu" , "Ne zelim" , "ne zelim"
        };
        if(odgovori.Contains(odgovor))
        {
            Console.WriteLine($"Pozajmio si {naslov} strip");
        }
        else if (negOdgovori.Contains(odgovor))
        {
            Console.WriteLine("Svako dobro!!!");
            Environment.Exit(0); //dodata opcija za prekidanje programa ukoliko se odbije pozajmljivanje knjige
        }
        else
        {
            Console.WriteLine("Razmislite, pa nam dodjite opet :D");
            Environment.Exit(0);
        }
    }

    public void Vrati()
    {
        Console.WriteLine($"da li zelis da vratis {naslov} strip?");
        List<string> odgovori = new List<string>()
        {
            "da" , "Da" , "DA" , "Hocu" , "hocu" , "Ocu" , "Ocu" , "Moze" , "moze"
        };
        List<string> negOdgovori = new List<string>()
        {
            "ne" , "Ne" , "NE" , "Necu" , "necu" , "Ne zelim" , "ne zelim"
        };
        string odgovor = Console.ReadLine();
        if (odgovori.Contains(odgovor))
        {
            Console.WriteLine($"Vratio si {naslov} strip");
        }
        else if (negOdgovori.Contains(odgovor))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Ne vratis li na vreme, dolazim ti na kucu!!!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Ne vratis li na vreme, dolazim ti na kucu.");
        }
    }
}