//int number=int.Parse(Console.ReadLine());
//double bonus = 0.0;
//if (number <= 100)
//{
//    bonus = 5;
//}
//else if (number > 1000)
//{
//    bonus = number * 0.1;
//}
//else
//{
//    bonus = number * 0.2;
//}

//if (number%2==0)
//{
//    bonus = bonus + 1;
//}
//else if(number%10==5)
//{
//    bonus += 2;
//}
//Console.WriteLine(bonus);
//Console.WriteLine(number+bonus);

// int chas = int.Parse(Console.ReadLine());
// int minuti = int.Parse(Console.ReadLine());
//minuti = minuti + 15;
//if(minuti>60)
//{
//    chas = chas + 1;
//    minuti = minuti - 60;
//}
//if (chas==24)
//{
//    chas = 0;
//}
//if (minuti<10)
//{
//    Console.WriteLine($"{chas}:0{minuti}");
//}
//else
//{
//    Console.WriteLine($"{chas}:{minuti}");
//}

double eks=double.Parse(Console.ReadLine());
int puzel=int.Parse(Console.ReadLine());
int kukli=int.Parse(Console.ReadLine());
int meche=int.Parse(Console.ReadLine());
int min=int.Parse(Console.ReadLine());
int kam=int.Parse(Console.ReadLine());

int sum_igr = puzel + kukli + meche + min + kam;
double sum = puzel * 2.6 + kukli * 3 + meche * 4.1 + min * 8.2 + kam * 2;

if (sum_igr>=50)
{

}
