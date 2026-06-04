namespace MiniSistemZaRadUBiblioteci;

public class Roman : Knjiga , IPozajmljivo
{
    public Roman(string naslov, string autor, int godina) : base(naslov , autor , godina)
    {
        
    }
    public override string PrikaziInfo()
    {
        return $"Roman: {naslov} \n, Autor: {autor} \n, Izdat: {godina} \n";
    }

    public void Pozajmi()
    {
        Console.WriteLine($"da li zelis da pozajmis {naslov} roman?");
        List<string> odgovori = new List<string>()
        {
            "da" , "Da" , "DA" , "Hocu" , "hocu" , "Ocu" , "Ocu" , "Moze" , "moze"
        };
        List<string> negOdgovori = new List<string>()
        {
            "ne" , "Ne" , "NE" , "Necu" , "necu" , "Ne zelim" , "ne zelim"
        };
        string odgovor = Console.ReadLine();
        if (odgovori.Contains(odgovor)) //resiti odgovor u konzoli da moze se odgovarati sa da i Da
        {
            Console.WriteLine($"Pozajmio si {naslov} roman");
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
        Console.WriteLine($"da li zelis da vratis {naslov} roman?");
        List<string> odgovori = new List<string>()
        {
            "da" , "Da" , "DA" , "Hocu" , "hocu" , "Ocu" , "Ocu" , "Moze" , "moze"
        };
        List<string> negOdgovori = new List<string>()
        {
            "ne" , "Ne" , "NE" , "Necu" , "necu" , "Ne zelim" , "ne zelim"
        };
        string odgovor = Console.ReadLine();
        if (odgovori.Contains(odgovor)) //isto vazi za ovo
        {
            Console.WriteLine($"Vratio si {naslov} roman");
        }
        else if (negOdgovori.Contains(odgovor))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Ne vratis li na vreme, dolazim ti na kucu!!!");
        }//negiranje vracanja knjige dolazi ti na kucu
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Ne vratis li na vreme, dolazim ti na kucu.");
        }
        
    }
}