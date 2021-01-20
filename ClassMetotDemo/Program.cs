using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri[] musteri = new Musteri[4];

            musteri[0] = new Musteri();

            musteri[0].Id = 1000;
            musteri[0].Ad = "Ayşe";
            musteri[0].Soyad = "Katırcı";
            musteri[0].Cinsiyet = "Kadın";

            musteri[1] = new Musteri();

            musteri[1].Id = 1001;
            musteri[1].Ad = "Kemal";
            musteri[1].Soyad = "İnce";
            musteri[1].Cinsiyet = "Erkek";

            musteri[2] = new Musteri();

            musteri[2].Id = 1002;
            musteri[2].Ad = "Selma";
            musteri[2].Soyad = "Demirci";
            musteri[2].Cinsiyet = "Kadın";

            musteri[3] = new Musteri();

            musteri[3].Id = 1003;
            musteri[3].Ad = "Murat";
            musteri[3].Soyad = "Bozkıran";
            musteri[3].Cinsiyet = "Erkek";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri[1]);

            musteriManager.MusteriSil(musteri[2]);

            musteriManager.MusteriListele(musteri);

        }
    }
}