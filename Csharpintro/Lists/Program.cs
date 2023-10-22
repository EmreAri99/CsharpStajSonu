// See https://aka.ms/new-console-template for more information


string[] sehirler = new string[] { "ankara", "istanbul", "izmir" };
Console.WriteLine(sehirler.Length);


sehirler = new string[4];
sehirler[3] = "bursa";

foreach (var sehir in sehirler)
{
    Console.WriteLine(sehir); 
    
}

List<string> sehirler2 = new List<string>() { "ankara", "istanbul", "izmir" }; 
Console.WriteLine(sehirler2.Count);
sehirler2.Add("bursa");

foreach (var sehir in sehirler2)
{

    Console.WriteLine(sehir);
}

sehirler2.Add("adana");
sehirler2.Remove("istanbul");
bool sonuc = sehirler2.Contains("izmir");








