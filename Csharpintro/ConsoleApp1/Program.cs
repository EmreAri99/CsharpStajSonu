// See https://aka.ms/new-console-template for more information

int [] sayilar = new int [3];

sayilar[0] = 15;
sayilar[1] = 45;
sayilar[2] = 56;

string sayiBuyuk = "sayıEnBuyuk";
string sayiOrtanca = "sayiOrtanca";
string sayiKucuk = "sayiEnKucuk";


if (sayilar[0] < sayilar[1])
{

    Console.WriteLine( sayiKucuk );


}

else if (sayilar[1] < sayilar[2]) 
{

    Console.WriteLine(sayiOrtanca);
}


else 
{

    Console.WriteLine(sayiBuyuk);

}
