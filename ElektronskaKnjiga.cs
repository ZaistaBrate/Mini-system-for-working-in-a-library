namespace MiniSistemZaRadUBiblioteci;

public sealed class ElektronskaKnjiga : Knjiga
{
    
    public ElektronskaKnjiga(string naslov, string autor, int godina) : base(naslov, autor, godina)
    {
        this.naslov = naslov;
        this.autor = autor;
        this.godina = godina;
    }

    public void PrikaziInfo()
    {
        Console.WriteLine($"Elektronska knjiga: \n {naslov} \n Autor: {autor} \n Izdata elektronski: {godina}"); 
    }

    public void Informacija()
    {
        Console.WriteLine("Elektronska knjiga je dostupna na sajtu biblioteke.");
    }

    public static void Preuzmi()
    {
        Console.WriteLine("|  Za preuzimanje elektronskih knjiga, morate ici na sajt: \n https://elektronskaknjiga.com/ ");
    }
}