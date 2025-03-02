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

        // Pobranie ulubionego koloru od użytkownika
        Console.WriteLine("Podaj swój ulubiony kolor:");
        string kolor = Console.ReadLine();

        // Pobranie hobby od użytkownika
        Console.WriteLine("Jakie jest Twoje hobby?");
        string hobby = Console.ReadLine();

        // Kalkulacja - ile lat użytkownik będzie miał za 10 lat
        int wiekZa10Lat = wiek + 10;

        // Wyświetlenie powitania i dodatkowych informacji
        Console.WriteLine($"\nWitaj, {imie}!");
        Console.WriteLine($"Masz {wiek} lat i za 10 lat będziesz miał {wiekZa10Lat} lat.");
        Console.WriteLine($"Twój ulubiony kolor to {kolor}, a Twoje hobby to {hobby}.");
    }
}
