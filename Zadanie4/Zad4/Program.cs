using System;

class Osoba
{
    public string Imie;
    public int Wiek;

    public void PrzedstawSie()
    {
        Console.WriteLine($"Hej wszystkim! Mam na imię {Imie} i mam {Wiek} lat.");
    }
}

class Program
{
    static void Main()
    {
        Osoba o1 = new Osoba();
        o1.Imie = "Krzysztof";
        o1.Wiek = 27;

        Osoba o2 = new Osoba();
        o2.Imie = "Aleksandra";
        o2.Wiek = 32;

        Osoba o3 = new Osoba();
        o3.Imie = "Michał";
        o3.Wiek = 22;

        o1.PrzedstawSie();
        o2.PrzedstawSie();
        o3.PrzedstawSie();
    }
}
