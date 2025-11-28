using System;

class Zwierze
{
    public virtual void DajGlos() => Console.WriteLine("Zwierzę wydaje odgłos");
}

class Pies : Zwierze
{
    public override void DajGlos() => Console.WriteLine("Hau hau!");
}

class Kot : Zwierze
{
    public override void DajGlos() => Console.WriteLine("Meow!");
}

class Program
{
    static void Main(string[] args)
    {
        Zwierze[] zwierzeta = new Zwierze[]
        {
            new Pies(),
            new Kot(),
            new Zwierze(),
            new Kot(),
            new Pies()
        };

        foreach (Zwierze z in zwierzeta)
        {
            z.DajGlos();
        }
    }
}
