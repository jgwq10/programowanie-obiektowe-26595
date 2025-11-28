using System;

class Program
{
    static void Main()
    {
        string haslo = "";
        string poprawnehaslo = "admin123";

        while (haslo != poprawnehaslo)
        {
            Console.Write("Podaj hasło: ");
            haslo = Console.ReadLine();
        }

        Console.WriteLine("Hasło poprawne.");
    }
}
