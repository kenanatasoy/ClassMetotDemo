using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri[] musteriler = new Musteri[4];

            musteriler[0] = new Musteri();

            musteriler[0].Id = 1000;
            musteriler[0].Ad = "Ayşe";
            musteriler[0].Soyad = "Katırcı";
            musteriler[0].Cinsiyet = "Kadın";

            musteriler[1] = new Musteri();

            musteriler[1].Id = 1001;
            musteriler[1].Ad = "Kemal";
            musteriler[1].Soyad = "İnce";
            musteriler[1].Cinsiyet = "Erkek";

            musteriler[2] = new Musteri();

            musteriler[2].Id = 1002;
            musteriler[2].Ad = "Selma";
            musteriler[2].Soyad = "Demirci";
            musteriler[2].Cinsiyet = "Kadın";

            musteriler[3] = new Musteri();

            musteriler[3].Id = 1003;
            musteriler[3].Ad = "Murat";
            musteriler[3].Soyad = "Bozkıran";
            musteriler[3].Cinsiyet = "Erkek";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteriler[1]);

            musteriManager.MusteriSil(musteriler[2]);

            musteriManager.MusteriListele(musteriler);

        }
    }
}