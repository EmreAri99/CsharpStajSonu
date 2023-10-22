
int aboneSayisi = 34000;
int yas = 24;
short yil = 1999;
byte sayi = 245;

string duyuru = " duyurumuz var ";

bool deger = false;

double piyasaDun = 1123345.6;
double piyasaBugun = 1123345.6;
bool sonuc = piyasaBugun > piyasaDun;
string mesajArtis = "Artis Oku";
string mesajAzalis = "Azalis Oku";
string mesajAyni = "Ayni Oku";

if (piyasaBugun>piyasaDun)
{

    Console.WriteLine("mesajArtis");


}
else if (piyasaBugun==piyasaDun)
{


    Console.WriteLine("mesajAyni");


}


else 
{

    Console.WriteLine("mesajAzalis");

}

