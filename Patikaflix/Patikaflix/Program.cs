using System;
using System.Collections.Generic;
using System.Linq;

class Dizi
{
    public string DiziAdi { get; set; }
    public int YapimYili { get; set; }
    public string DiziTuru { get; set; }
    public int YayinaBaslamaYili { get; set; }
    public string Yonetmen { get; set; }
    public string IlkPlatform { get; set; }

    public Dizi(string diziAdi, int yapimYili, string diziTuru, int yayinaBaslamaYili, string yonetmen, string ilkPlatform)
    {
        DiziAdi = diziAdi;
        YapimYili = yapimYili;
        DiziTuru = diziTuru;
        YayinaBaslamaYili = yayinaBaslamaYili;
        Yonetmen = yonetmen;
        IlkPlatform = ilkPlatform;
    }

    public override string ToString()
    {
        return $"Dizi Adı: {DiziAdi}, Yönetmen: {Yonetmen}, Yapım Yılı: {YapimYili}, Türü: {DiziTuru}, Yayına Başlama Yılı: {YayinaBaslamaYili}, İlk Platform: {IlkPlatform}";
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine(this.ToString());
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Dizi> diziler = new List<Dizi>
        {
            new Dizi("Avrupa Yakası", 2004, "Komedi", 2004, "Yüksel Aksu", "Kanal D"),
            new Dizi("Yalan Dünya", 2012, "Komedi", 2012, "Gülseren Buda Başkaya", "Fox TV"),
            new Dizi("Jet Sosyete", 2018, "Komedi", 2018, "Gülseren Buda Başkaya", "TV8"),
            new Dizi("Dadı", 2006, "Komedi", 2006, "Yusuf Pirhasan", "Kanal D"),
            new Dizi("Belalı Baldız", 2007, "Komedi", 2007, "Yüksel Aksu", "Kanal D"),
            new Dizi("Arka Sokaklar", 2004, "Polisiye, Dram", 2004, "Orhan Oğuz", "Kanal D"),
            new Dizi("Aşk-ı Memnu", 2008, "Dram, Romantik", 2008, "Hilal Saral", "Kanal D"),
            new Dizi("Muhteşem Yüzyıl", 2011, "Tarihi, Dram", 2011, "Mercan Çilingiroğlu", "Star TV"),
            new Dizi("Yaprak Dökümü", 2006, "Dram", 2006, "Serdar Akar", "Kanal D")
        };

        bool yeniDiziEkle = true;

        while (yeniDiziEkle)
        {
            Console.Write("Dizi Adı: ");
            string diziAdi = Console.ReadLine();

            Console.Write("Yapım Yılı: ");
            int yapimYili = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dizi Türü: ");
            string diziTuru = Console.ReadLine();

            Console.Write("Yayına Başlama Yılı: ");
            int yayinaBaslamaYili = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yönetmen: ");
            string yonetmen = Console.ReadLine();

            Console.Write("İlk Platform: ");
            string ilkPlatform = Console.ReadLine();

            Dizi yeniDizi = new Dizi(diziAdi, yapimYili, diziTuru, yayinaBaslamaYili, yonetmen, ilkPlatform);
            diziler.Add(yeniDizi);

            Console.Write("Yeni bir dizi eklemek ister misiniz? (e/h): ");
            string cevap = Console.ReadLine().ToLower();

            yeniDiziEkle = cevap == "e";
        }

        // Komedi dizilerinden yeni bir liste oluşturma
        List<Dizi> komediDizileri = diziler
            .Where(dizi => dizi.DiziTuru.ToLower().Contains("komedi"))
            .OrderBy(dizi => dizi.DiziAdi)
            .ThenBy(dizi => dizi.Yonetmen)
            .ToList();

        Console.WriteLine("\nKomedi Dizileri Listesi:");
        foreach (var dizi in komediDizileri)
        {
            dizi.BilgileriYazdir();
        }
    }
}
