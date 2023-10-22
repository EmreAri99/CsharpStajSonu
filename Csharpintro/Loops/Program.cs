// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] krediler = new string[7];

krediler[0] = "hızlı kredi";
krediler[1] = "kredi 2";
krediler[2] = "kredi 3";
krediler[3] = "kredi 4";
krediler[4] = "kredi 5";
krediler[5] = "kredi 6";
krediler[6] = "kredi 7";

for (int i = 0;i<7;i++)
{

    Console.WriteLine(krediler[i]);
}

Console.WriteLine("for dongusu bitti");

foreach (string kredi in krediler)
{

    Console.WriteLine(kredi);
}


int sayac = 0;
while (sayac < 7)
{

  Console.WriteLine(krediler[sayac]);
  
    sayac++;

}

int sayac2= 0;

do
{
    Console.WriteLine(krediler[sayac2]);
    
     sayac2++;

} while (sayac2 < 7);

Console.WriteLine("bitti");