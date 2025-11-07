using System.Runtime.InteropServices;

//string product = Console.ReadLine();
//string city = Console.ReadLine();
//double quantity = double.Parse(Console.ReadLine());
//double cena = 0.0;

//if (city == "Sofia")
//{
//    switch (product)
//    {
//        case "coffee":
//            cena = 0.5;
//            break;
//        case "water":
//            cena = 0.8;
//            break;
//        case "beer":
//            cena = 1.2;
//            break;
//        case "sweets":
//            cena = 1.45;
//            break;
//        case "peanuts":
//            cena = 1.6;
//            break;
//    }
//}

//else if(city == "Plovdiv")
//{
//    switch (product)
//    {
//        case "coffee":
//            cena = 0.4;
//            break;
//        case "water":
//            cena = 0.7;
//            break;
//        case "beer":
//            cena = 1.15;
//            break;
//        case "sweets":
//            cena = 1.3;
//            break;
//        case "peanuts":
//            cena = 1.5;
//            break;
//    }
//}

//else if (city == "Varna")
//{
//    switch (product)
//    {
//        case "coffee":
//            cena = 0.45;
//            break;
//        case "water":
//            cena = 0.7;
//            break;
//        case "beer":
//            cena = 1.10;
//            break;
//        case "sweets":
//            cena = 1.35;
//            break;
//        case "peanuts":
//            cena = 1.55;
//            break;
//    }
//}


//double sum = cena * quantity;
//Console.WriteLine($"{sum:f2}");


int hour = int.Parse(Console.ReadLine());
string day  = Console.ReadLine();   

if (hour > 10 && hour < 18)
{
    switch (day)
    {
        case "Monday":
            Console.WriteLine("open");
            break;
        case "Tuesday":
            Console.WriteLine("open");
            break;
        case "Wednesday":
            Console.WriteLine("open");
            break;
        case "Thursday":
            Console.WriteLine("open");
            break;
        case "Friday":
            Console.WriteLine("open");
            break;
        case "Saturday":
            Console.WriteLine("open");
            break;
        case "Sunday":
            Console.WriteLine("closed");
            break;
        default:
            break;

    }
}