// See https://aka.ms/new-console-template for more information
int not1, not2, sözlüNot,notHesaplama;
//%30 etkiliyor
Console.WriteLine("Birinci notunuzu giriniz: ");
not1 = Convert.ToInt32(Console.ReadLine());
//%30 etlikiyor
Console.WriteLine("İkinci notunuzu giriniz: ");
not2 = Convert.ToInt32(Console.ReadLine());

//%40 etkiliyor
Console.WriteLine("Sözlü notunuzu giriniz: ");
sözlüNot = Convert.ToInt32(Console.ReadLine());

notHesaplama = ((not1 * 30) / 100 + ((not2 * 30) / 100) + ((sözlüNot*40)/100));

if (notHesaplama >= 50)
{
    Console.WriteLine("Geçme notunuz : " + notHesaplama);

}
else 
{
    Console.WriteLine("Kalma notunuz : " + notHesaplama);

}