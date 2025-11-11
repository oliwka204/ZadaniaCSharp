using System;

class Program
{
    static void Main(string[] args)
    {
        //Pobieramy wartości a, b ,c 
        Console.WriteLine("Podaj a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Używamy klasy DeltaCalculator z innego pliku!
        Delta.ObliczDelteOrazPierwiastki(a, b, c);
    }
}
