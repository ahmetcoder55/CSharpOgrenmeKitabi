Console.WriteLine("=== C# HESAP MAKİNESİNE HOŞ GELDİNİZ ===");
Console.WriteLine("---------------------------------------");

// 1. Sayıyı alma ve dönüştürme
Console.Write("İlk Sayıyı Giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

// 2. Sayıyı alma ve dönüştürme
Console.Write("İkinci Sayıyı Giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

// Matematiksel İşlemler
int toplam = sayi1 + sayi2;
int fark = sayi1 - sayi2;
int carpi = sayi1 * sayi2;

// Sonuçları Ekrana Yazdırma
Console.WriteLine("\n--- SONUÇLAR ---");
Console.WriteLine("Toplama Sonucu: " + toplam);
Console.WriteLine("Çıkarma Sonucu: " + fark);
Console.WriteLine("Çarpma Sonucu: " + carpi);
