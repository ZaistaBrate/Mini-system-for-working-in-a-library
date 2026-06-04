namespace MiniSistemZaRadUBiblioteci;

public class Biblioteka
{
    private List<Knjiga> knjige;

    public Biblioteka()
    {
        knjige = new List<Knjiga>();
    }

    public void DodajKnjigu(Knjiga knjiga)
    {
        knjige.Add(knjiga);
        Console.WriteLine($"|  Knjiga {knjiga.naslov} je dodata u biblioteci!");
    }

    public Knjiga PronadjiKnjigu(string naslov)
    {
        foreach (var knjiga in knjige)
        {
            if (knjiga.naslov.Equals(naslov, StringComparison.OrdinalIgnoreCase))
            {
                return knjiga;
            }
        }
        Console.ForegroundColor = ConsoleColor.Red;
        throw new KnjigaNijePronadjenaException("Knjiga sa tim naslovom nije pronadjena!!!");
    }

    public void PrikaziSveKnjige()
    {
        foreach (var knjiga in knjige)
        {
            knjiga.PrikaziInfo();
        }
    }
}