using System;

class Program
{
    static void Main()
    {
        // Pobranie imienia od użytkownika
        Console.WriteLine("Podaj swoje imię:");
        string imie = Console.ReadLine();

        // Pobranie wieku od użytkownika
        Console.WriteLine("Podaj swój wiek:");
        int wiek = int.Parse(Console.ReadLine());

        // Wyświetlenie powitania
        Console.WriteLine($"Witaj, {imie}! Masz {wiek} lat.");
    }
}
