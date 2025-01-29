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

class Biblioteka
{
    private List<Ksiazka> ksiazki;

    public Biblioteka()
    {
        ksiazki = new List<Ksiazka>
        {
            new Ksiazka("Władca Pierścieni", "J.R.R. Tolkien", 1954),
            new Ksiazka("Harry Potter i Kamień Filozoficzny", "J.K. Rowling", 1997),
            new Ksiazka("Zbrodnia i kara", "Fiodor Dostojewski", 1866)
        };
    }

    public void DodajKsiazke(Ksiazka ksiazka)
    {
        ksiazki.Add(ksiazka);
    }

    public void UsunKsiazke(string tytul)
    {
        if (!ksiazki.RemoveAll(k => k.Tytul == tytul).Equals(0))
        {
            Console.WriteLine("Książka została usunięta.");
        }
        else
        {
            Console.WriteLine("Nie znaleziono książki o podanym tytule.");
        }
    }

    public void EdytujKsiazke(string tytul, string nowyTytul, string nowyAutor, int nowyRok)
    {
        var ksiazka = ksiazki.FirstOrDefault(k => k.Tytul == tytul);
        if (ksiazka != null)
        {
            ksiazka.Tytul = nowyTytul;
            ksiazka.Autor = nowyAutor;
            ksiazka.RokWydania = nowyRok;
            Console.WriteLine("Książka została zaktualizowana.");
        }
        else
        {
            Console.WriteLine("Nie znaleziono książki o podanym tytule.");
        }
    }

    public void WyswietlKsiazki()
    {
        if (ksiazki.Count == 0)
        {
            Console.WriteLine("Biblioteka jest pusta.");
            return;
        }

        foreach (var ksiazka in ksiazki)
        {
            ksiazka.WyswietlInformacje();
        }
    }

    public void WyswietlKsiazkiAutora(string autor)
    {
        var znalezione = ksiazki.Where(k => k.Autor == autor).ToList();
        if (znalezione.Count == 0)
        {
            Console.WriteLine("Brak książek tego autora.");
            return;
        }

        foreach (var ksiazka in znalezione)
        {
            ksiazka.WyswietlInformacje();
        }
    }

    public void WyswietlKsiazkiZRoku(int rok)
    {
        var znalezione = ksiazki.Where(k => k.RokWydania == rok).ToList();
        if (znalezione.Count == 0)
        {
            Console.WriteLine("Brak książek z tego roku.");
            return;
        }

        foreach (var ksiazka in znalezione)
        {
            ksiazka.WyswietlInformacje();
        }
    }
}

class Program
{
    static void Main()
    {
        Biblioteka biblioteka = new Biblioteka();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Dodaj książkę");
            Console.WriteLine("2. Usuń książkę");
            Console.WriteLine("3. Edytuj książkę");
            Console.WriteLine("4. Wyświetl wszystkie książki");
            Console.WriteLine("5. Wyświetl książki autora");
            Console.WriteLine("6. Wyświetl książki z roku");
            Console.WriteLine("7. Wyjdź");
            Console.Write("Wybierz opcję: ");

            string opcja = Console.ReadLine();
            switch (opcja)
            {
                case "1":
                    Console.Write("Podaj tytuł: ");
                    string tytul = Console.ReadLine();
                    Console.Write("Podaj autora: ");
                    string autor = Console.ReadLine();
                    Console.Write("Podaj rok wydania: ");
                    int rok = int.Parse(Console.ReadLine());
                    biblioteka.DodajKsiazke(new Ksiazka(tytul, autor, rok));
                    break;

                case "2":
                    Console.Write("Podaj tytuł książki do usunięcia: ");
                    string tytulUsun = Console.ReadLine();
                    biblioteka.UsunKsiazke(tytulUsun);
                    break;

                case "3":
                    Console.Write("Podaj tytuł książki do edycji: ");
                    string tytulEdytuj = Console.ReadLine();
                    Console.Write("Podaj nowy tytuł: ");
                    string nowyTytul = Console.ReadLine();
                    Console.Write("Podaj nowego autora: ");
                    string nowyAutor = Console.ReadLine();
                    Console.Write("Podaj nowy rok wydania: ");
                    int nowyRok = int.Parse(Console.ReadLine());
                    biblioteka.EdytujKsiazke(tytulEdytuj, nowyTytul, nowyAutor, nowyRok);
                    break;

                case "4":
                    biblioteka.WyswietlKsiazki();
                    break;

                case "5":
                    Console.Write("Podaj autora: ");
                    string autorWyszukaj = Console.ReadLine();
                    biblioteka.WyswietlKsiazkiAutora(autorWyszukaj);
                    break;

                case "6":
                    Console.Write("Podaj rok wydania: ");
                    int rokWyszukaj = int.Parse(Console.ReadLine());
                    biblioteka.WyswietlKsiazkiZRoku(rokWyszukaj);
                    break;

                case "7":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Nieprawidłowa opcja.");
                    break;
            }
        }
    }
}

