using System;

public class BaseKisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public void KisiBilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
    }
}

public class Ogrenci : BaseKisi
{
    public string OgrenciNumarasi { get; set; }

    public void OgrenciBilgileriYazdir()
    {
        Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
        KisiBilgileriYazdir(); // BaseKisiden gelen metodu cagiriyoruz
    }
}

public class Ogretmen : BaseKisi
{
    public decimal MaasBilgisi { get; set; }

    public void OgretmenBilgileriYazdir()
    {
        Console.WriteLine($"Maaş Bilgisi: {MaasBilgisi}");
        KisiBilgileriYazdir(); // BaseKisiden gelen metodu cagiriyoruz
    }
}

class Program
{
    static void Main(string[] args)
    {
        // ogrenci nesnesi tanimlama ve deger atama
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Mahir",
            Soyad = "Yıldız",
            OgrenciNumarasi = "614"
        };

        // ogretmen nesnesi tanimlama ve deger atama
        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Mia",
            Soyad = "Godsgiven",
            MaasBilgisi = 36200
        };

        // bilgileri konsol ekranina yazdirma
        ogrenci.OgrenciBilgileriYazdir();
        Console.WriteLine(); // bos satir
        ogretmen.OgretmenBilgileriYazdir();
    }
}
