using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            if (musteri.Cinsiyet == "Erkek")
            {
                Console.WriteLine(musteri.Ad + " bey eklendi.");
            }

            else if (musteri.Cinsiyet == "Kadın")
            {
                Console.WriteLine(musteri.Ad + " hanım eklendi.");
            }

            else
            {
                Console.WriteLine(musteri.Ad + " eklendi.");
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            if (musteri.Cinsiyet == "Erkek")
            {
                Console.WriteLine(musteri.Ad + " bey silindi.");
            }

            else if (musteri.Cinsiyet == "Kadın")
            {
                Console.WriteLine(musteri.Ad + " hanım silindi.");
            }

            else
            {
                Console.WriteLine(musteri.Ad + " silindi.");
            }
        }

        public void MusteriListele(Musteri[] musteriler)
        {

            Console.WriteLine();
            Console.WriteLine("Müşteriler: ");

            foreach (Musteri musteri in musteriler)
            {
                if (musteri.Cinsiyet == "Erkek")
                {
                    Console.WriteLine(musteri.Ad + " bey");
                }

                else if (musteri.Cinsiyet == "Kadın")
                {
                    Console.WriteLine(musteri.Ad + " hanım");
                }

                else
                {
                    Console.WriteLine(musteri.Ad);
                }
            }

        }

    }
}