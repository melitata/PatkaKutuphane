using System;
public class Kütüphane
{   //proprty tanımlamaları
    public string Adı;
    public string YazarAdı;
    public string YazarSoyadı;
    public int SayfaSayısı;
    public string Yayınevi;
    public DateTime KayıtTarihi;
    public Kütüphane()
    // de3fault constructor tanımlaması
    {
        Adı = string.Empty;
        YazarAdı = string.Empty;
        YazarSoyadı = string.Empty;
        SayfaSayısı = 0;
        Yayınevi = string.Empty;
        KayıtTarihi = DateTime.Now;

    }
    public Kütüphane(string adı, string yazarAdı, string yazarSoyadı, int sayfaSayısı, string yayınevi, DateTime kayıtTarihi)
    //parametreli constructor tanımlaması
    {
        Adı = adı;
        YazarAdı = yazarAdı;
        YazarSoyadı = yazarSoyadı;
        SayfaSayısı = sayfaSayısı;
        Yayınevi = yayınevi;
        KayıtTarihi = DateTime.Now;

    }
    //metod tanımlaması
    public Kütüphane KitapEkle(string adı, string yazarAdı, string yazarSoyadı, int sayfaSayısı, string yayınevi, DateTime kayıtTarihi)
    {
        return new Kütüphane(adı, yazarAdı, yazarSoyadı, sayfaSayısı, yayınevi, kayıtTarihi);
    }
    //"ToString" metodu override edildi.
    public override string ToString()
    {
        return string.Format("Adı:{0}\nYazar Adı:{1}\nYazar Soyadı:{2}\nSayfa Sayısı:{3}\nYayınevi:{4}\nKayıt Tarihi:{5}", Adı, YazarAdı, YazarSoyadı, SayfaSayısı, Yayınevi, KayıtTarihi);
    }

    class Program
    {
        static void Main()
        {
            //Kütüphane sınıfından kitap adında bir nesne oluşturduk.
            Kütüphane kitap = new Kütüphane();
            kitap = kitap.KitapEkle("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi", DateTime.Now);
            Console.WriteLine(kitap);
            //default constructor ile oluşturulan nesne
            Kütüphane kitap1 = new Kütüphane();
            Console.WriteLine(kitap1);



        }
    }
}