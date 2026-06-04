namespace MiniSistemZaRadUBiblioteci;

public abstract class Knjiga
{
    public string naslov;
    public string autor;
    public int godina;

    public Knjiga(string naslov, string autor, int godina)
    {
        this.naslov = naslov;
        this.autor = autor;
        this.godina = godina;
    }

    public virtual string PrikaziInfo()
    {
        return $"{naslov} - {autor} - {godina}";
    }
}