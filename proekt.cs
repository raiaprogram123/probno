using System.Security.Authentication.ExtendedProtection;

int years=int.Parse(Console.ReadLine());
int klient=int.Parse(Console.ReadLine());   
int days=int.Parse(Console.ReadLine());
double bilet = 12;
double cena = 0;
if (years < 0||klient<1||klient>4||days<1||days>7)
{
    Console.WriteLine("NEVALIDEN VHOD");
}
else 
{
    if (years < 7)
            cena = 0.0;
    else
    
    if (klient == 1)    
        cena = bilet - (bilet * 0.5);
     else 
           if (klient == 2)
           cena = bilet - (bilet * 0.7);
          else 
              if (klient == 3)
                  cena = bilet - (bilet * 0.6);
             else 
                  cena = bilet;


    if (days == 6 || days == 7)
        cena = cena - (cena * 0.1);

    Console.WriteLine($"{cena:F2}");


}
