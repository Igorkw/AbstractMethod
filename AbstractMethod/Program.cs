using AbstractMethod.Entities;
using AbstractMethod.Entities.Enums;
using System.Globalization;

Console.Write("How many shapes? ");
int nShapes = int.Parse(Console.ReadLine());

List<Shape> list = new List<Shape>();

for (int i = 1; i <= nShapes; i++)
{
    Console.WriteLine($"Shape #{i} data: ");
    Console.Write("Rectangle or circle (r/c)? ");
    string chosenShape = Console.ReadLine();

    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (chosenShape == "r")
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Rectangle(width, height, color));
    }
    else
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Cicle(radius, color));
    }
}
Console.WriteLine("\nShape areas:");
foreach (Shape shapes in list)
{
    Console.WriteLine($"{shapes.Area().ToString("F2", CultureInfo.InvariantCulture)}");
}
