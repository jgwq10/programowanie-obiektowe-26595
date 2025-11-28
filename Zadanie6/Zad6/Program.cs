
public class Zwierze
{
    public string Imie { get; set; }
    public int Wiek { get; set; }

    public void Jedz()
    {
        Console.WriteLine($"{Imie} je swój pokarm.");
    }
}

// Klasa Kot dziedzicząca po Zwierze
public class Kot : Zwierze
{
    // Metoda charakterystyczna dla kota
    public void Miaucz()
    {
        Console.WriteLine($"{Imie} Meow");
    }
}

// Przykład
class Program
{
    static void Main(string[] args)
    {
        Kot mojKot = new Kot();
        mojKot.Imie = "Mleko";
        mojKot.Wiek = 2;

        mojKot.Jedz();     // metoda odziedziczona po Zwierze
        mojKot.Miaucz();   // metoda specyficzna dla Kota
    }
}
