using System;

class Program
{
    static void Main()
    {
        int liczba;

        do
        {
            Console.Write("Podaj liczbę większą od zera: ");
            string input = Console.ReadLine();

            // Próba konwersji — sprawdzamy czy wpisano liczbę
            if (!int.TryParse(input, out liczba))
            {
                Console.WriteLine("To nie jest poprawna liczba.");
                continue;
            }

            if (liczba <= 0)
            {
                Console.WriteLine("Liczba musi być większa od zera.");
            }

        } while (liczba <= 0);

        Console.WriteLine($"Poprawnie. Podałeś liczbę: {liczba}");
    }
}
