using MiniSistemZaRadUBiblioteci;

Biblioteka biblioteka = new Biblioteka();

biblioteka.DodajKnjigu(new Roman("Na Drini Cuprija" , "Ivo Andric" , 1945));
biblioteka.DodajKnjigu(new Strip("Vagabond" , "Mijamoto Musasi" , 1967));
biblioteka.DodajKnjigu(new Udzbenik("Likovna kultura" , "Klet" , 2011));
biblioteka.DodajKnjigu(new Roman("Most na Zepi" , "Ivo Andric" , 1945));
biblioteka.DodajKnjigu(new Strip("Politikin zabavnik" , "Neko" , 1967));
biblioteka.DodajKnjigu(new Udzbenik("Muzicka kultura" , "Klet" , 2011));
biblioteka.DodajKnjigu(new ElektronskaKnjiga("Programiranje" , "Obama" , 2008));
biblioteka.DodajKnjigu(new ElektronskaKnjiga("Baze podataka" , "Neznam" , 2011));
Console.WriteLine();
biblioteka.PrikaziSveKnjige();
ElektronskaKnjiga.Preuzmi();

try
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Unesi knjigu koju biste zeleli da pozajmite:");
    var knjiga = biblioteka.PronadjiKnjigu(Console.ReadLine()); // dodati funkcionalnost biranja knjige u konzoli
    knjiga.PrikaziInfo(); //ostalo je u redu za sad

    if (knjiga is IPozajmljivo pozajmljivo)
    {
        pozajmljivo.Pozajmi();
        Thread.Sleep(3000); //dodata nova funkcija za time
        pozajmljivo.Vrati();
    }

    if (knjiga is ElektronskaKnjiga eknjiga)
    {
        eknjiga.PrikaziInfo();
        eknjiga.Informacija();
    }
}

catch (KnjigaNijePronadjenaException e)
{
    Console.WriteLine(e.Message);
}

