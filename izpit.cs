// Определете вида на триъгълника

int a=int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a + b > c && a + c > b && b + c > a)
{
    if (a == b && b == c)
    {
        Console.WriteLine("Ravnostranen");
    }
    else if (a == b ||a==c || b==c)
    {
        Console.WriteLine("Ravnobedren");
    }
    else
    {
        Console.WriteLine("Raznostranen");
    }
}
