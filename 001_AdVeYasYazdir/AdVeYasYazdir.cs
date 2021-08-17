using System;

class MainClass {
  public static void Main (string[] args) {

    //Girilen isim ve doğum yılı bilgilerini alarak, isim ve yaş olarak ekrana görüntüleyen algoritmayı yazınız.

    //değişkeninVeriTipi değişkeninAdı = değişkeninDeğeri
    string kullaniciAdi;
    int kullaniciDogumYili;
    
    Console.WriteLine("Lütfen Adınızı Girin : ");
    kullaniciAdi = Console.ReadLine();

    Console.WriteLine("Lütfen Doğum Yılınızı Girin : ");
    kullaniciDogumYili = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Girilen Kullanıcı Bilgileri:");
    Console.WriteLine("Kullanıcının Adı : " + kullaniciAdi);
    Console.WriteLine("Kullanıcının Yaşı : " + (2021 - kullaniciDogumYili));

  }
}