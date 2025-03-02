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


        // Wyświetlenie powitania i dodatkowych informacji
        Console.WriteLine($"\nWitaj, {imie}!");

    }
}
