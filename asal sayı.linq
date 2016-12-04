<Query Kind="Program" />

void Main()
{
	int sayi;
Console.Write("Sayı giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());
if (sayi == 0 || sayi == 1)
{
Console.WriteLine("Bu sayı asal bir sayı değildir.");
}

for (int i = 2; i <= sayi / 2; i++)
{
if (sayi % i == 0)
{
Console.WriteLine("Bu sayı asal bir sayı değildir."); 
return;
}
}
Console.WriteLine("Bu sayı asal bir sayıdır."); 
}

// Define other methods and classes here
