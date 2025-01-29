

class Ksiazka
{
    public string Tytul { get; set; }
    public string Autor { get; set; }
    public int RokWydania { get; set; }

    public Ksiazka(string tytul, string autor, int rokWydania)
    {
        Tytul = tytul;
        Autor = autor;
        RokWydania = rokWydania;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Tytuł: {Tytul}, Autor: {Autor}, Rok wydania: {RokWydania}");
    }
}

class Program
{
    static void Main()
    {
        Ksiazka ksiazka1 = new Ksiazka("Władca Pierścieni", "J.R.R. Tolkien", 1954);
        Ksiazka ksiazka2 = new Ksiazka("Harry Potter i Kamień Filozoficzny", "J.K. Rowling", 1997);
        Ksiazka ksiazka3 = new Ksiazka("Zbrodnia i kara", "Fiodor Dostojewski", 1866);

        ksiazka1.WyswietlInformacje();
        ksiazka2.WyswietlInformacje();
        ksiazka3.WyswietlInformacje();
    }
}