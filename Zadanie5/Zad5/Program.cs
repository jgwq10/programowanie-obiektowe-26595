using System;

class KontoBankowe
{
    private double saldo;

    public void Wplata(double kwota)
    {
        saldo += kwota;
    }

    public bool Wyplata(double kwota)
    {
        if (kwota <= saldo)
        {
            saldo -= kwota;
            Console.WriteLine("Wypłata udana: " + kwota);
            return true; // wypłata udana
        }
        else
        {
            Console.WriteLine("Brak wystarczających środków. Saldo: " + saldo);
            return false; // brak środków
        }
    }

    public double PobierzSaldo()
    {
        return saldo;
    }
}

class Program
{
    static void Main()
    {
        KontoBankowe konto = new KontoBankowe();

        konto.Wplata(1000);
        Console.WriteLine("Saldo po wpłacie: " + konto.PobierzSaldo());

        bool wynikWyplaty = konto.Wyplata(500);
        Console.WriteLine("Saldo po wypłacie: " + konto.PobierzSaldo());

        wynikWyplaty = konto.Wyplata(600);
        Console.WriteLine("Saldo po próbie wypłaty: " + konto.PobierzSaldo());
    }
}
