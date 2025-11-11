using System;

public class Delta
{
    // Metoda obliczająca deltę i pierwiastki
    public static void ObliczDelteOrazPierwiastki(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;
        Console.WriteLine($"Delta wynosi: {delta}");
        //Warunki liczenia pierwiastków z równania
        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Pierwiastki równania wynoszą: x1 = {x1}, x2 = {x2}.");
        }
        else if (delta == 0)
        {
            double x0 = -b / (2 * a);
            Console.WriteLine($"Pierwiastek x0 = {x0}.");
        }
        else
        {
            Console.WriteLine("Delta wynosi mniej niż zero! Brak pierwiastków rzeczywistych.");
        }
    }
}
