
using System.Drawing;

string figura = Console.ReadLine();
double lice = 0.0;

if (figura == "square")
{
    double a = double.Parse(Console.ReadLine());
    lice = a * a;
    Console.WriteLine($"{lice:F3}");
}
else if (figura == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    lice = a * b;
    Console.WriteLine($"{lice:F3}");
}
else if (figura == "circle")
{
    
    double r = double.Parse(Console.ReadLine());
    lice = Math.PI * r*r; 
    Console.WriteLine($"{lice:F3}");
}
else if (figura == "triangle")
{
    double a = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    lice = (a * h) / 2;
    Console.WriteLine($"{lice:F3}");
}


