using System;
using ConsoleApprectangle;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Création de différentes formes géométriques
        object[] shapes = new object[]
        {
            new rRectangle(10, 20),
            new Circle(5),
            new Triangle(10, 15),
            new rRectangle(5, 15),
            new Circle(3),
            new Triangle(8, 12)
        };

        // Calcul de la surface totale
        AreaCalculator calculator = new AreaCalculator();
        double totalArea = calculator.TotalArea(shapes);

        // Affichage du résultat
        Console.WriteLine($"La surface totale des formes est : {totalArea}");
    }
}
