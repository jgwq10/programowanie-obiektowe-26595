using System;


class Pojazd
{
    public virtual void Start() => Console.WriteLine("Pojazd został uruchomiony");
}

class Samochod : Pojazd
{
    public void Jedz() => Console.WriteLine("Samochód jedzie");
}

class ElektrycznySamochod : Samochod
{
    public void Laduj() => Console.WriteLine("Ładowanie baterii");
}

class Program
{
    static void Main(string[] args)
    {
       
        Pojazd pojazd = new Pojazd();
        pojazd.Start();
        Console.WriteLine();

        Samochod samochod = new Samochod();
        samochod.Start(); 
        samochod.Jedz();
        Console.WriteLine();

        ElektrycznySamochod eSamochod = new ElektrycznySamochod();
        eSamochod.Start(); 
        eSamochod.Jedz();  
        eSamochod.Laduj(); 
    }
}
