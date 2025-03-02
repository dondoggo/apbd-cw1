using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Pobranie imienia od użytkownika
        Console.WriteLine("Podaj swoje imię:");
        string imie = Console.ReadLine();

        // Pobranie wieku od użytkownika
        int wiek = 0;
        bool wiekPoprawny = false;

        while (!wiekPoprawny)
        {
            Console.WriteLine("Podaj swój wiek:");
            string wiekInput = Console.ReadLine();

            // Walidacja, czy wiek jest liczbą
            if (int.TryParse(wiekInput, out wiek) && wiek > 0)
            {
                wiekPoprawny = true;
            }
            else
            {
                Console.WriteLine("Wiek musi być liczbą dodatnią. Spróbuj ponownie.");
            }
        }

        // Pobranie ulubionego koloru od użytkownika
        Console.WriteLine("Podaj swój ulubiony kolor:");
        string kolor = Console.ReadLine();

        // Pobranie hobby od użytkownika
        Console.WriteLine("Jakie jest Twoje hobby?");
        string hobby = Console.ReadLine();

        // Kalkulacja - ile lat użytkownik będzie miał za 10 lat
        int wiekZa10Lat = wiek + 10;

        // Obliczenie roku urodzenia
        int rokUrodzenia = DateTime.Now.Year - wiek;

        // Wyświetlenie powitania i dodatkowych informacji
        Console.WriteLine($"\nWitaj, {imie}!");
        Console.WriteLine($"Masz {wiek} lat i za 10 lat będziesz miał {wiekZa10Lat} lat.");
        Console.WriteLine($"Twój ulubiony kolor to {kolor}, a Twoje hobby to {hobby}.");
        Console.WriteLine($"Urodziłeś się w roku {rokUrodzenia}.");

        // Zapisanie odpowiedzi do pliku tekstowego
        string sciezkaPliku = "dane_uzytkownika.txt";
        using (StreamWriter writer = new StreamWriter(sciezkaPliku))
        {
            writer.WriteLine($"Imię: {imie}");
            writer.WriteLine($"Wiek: {wiek}");
            writer.WriteLine($"Ulubiony kolor: {kolor}");
            writer.WriteLine($"Hobby: {hobby}");
            writer.WriteLine($"Rok urodzenia: {rokUrodzenia}");
        }

        Console.WriteLine("\nDane zostały zapisane do pliku 'dane_uzytkownika.txt'.");
    }
}
