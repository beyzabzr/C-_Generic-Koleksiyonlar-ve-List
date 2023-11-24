using System;
using System.Collections.Generic;

namespace generic_koleksiyonlar_ve_list
{
    class Program
    {
        public static void Main(string[] args)
        {
            //List<T> class
            //using System.Collections.Generic;
            // T -> object türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kirmizi");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");
            renkListesi.Add("Yesil");

            // Count (Listeler icerisinde ki eleman sayisini getirir)
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            Console.WriteLine("**************");

            // ForEach ve List.ForEach ile elemanlara erisim

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi); // sayiListesi icerisindeki elemanlari tek tek yazdirir
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk); // renkListesi icerisindeki elemanlari tek tek yazdirir
            };

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            Console.WriteLine("**************");

            // Remove (Listeden eleman cikarma)

            sayiListesi.Remove(4);
            renkListesi.Remove("Yesil");

            sayiListesi.RemoveAt(0); // 0.indexi cıkar
            renkListesi.RemoveAt(1); // 1.indexi cikar

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            Console.WriteLine("**************");

            // Contains (Liste icerisinde arama) 
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste icerisinde bulundu.");
            }

            Console.WriteLine("**************");

            //BinarySearch (Eleman ile indexe erisme)
            Console.WriteLine(renkListesi.BinarySearch("Sari"));

            Console.WriteLine("**************");

            //Diziyi List'e Cevirme
            string[] hayvanlar = { "Kedi", "Kopek", "Kus" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            hayvanListesi.ForEach(hayvan => Console.WriteLine(hayvan));

            Console.WriteLine("**************");

            //Clear (Listeyi temizleme)
            hayvanListesi.Clear();

            Console.WriteLine("**************");

            //List icerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Ayse";
            kullanici1.Soyisim = "Yilmaz";
            kullanici1.Yas = 26;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Ozcan";
            kullanici2.Soyisim = "Caliskan";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanici Adi: " + kullanici.Isim);
                Console.WriteLine("Kullanici Soyadi: " + kullanici.Soyisim);
                Console.WriteLine("Kullanici Yas: " + kullanici.Yas);
            }

            foreach (var Item in yeniListe)
            {
                Console.WriteLine("Kullanici Adi: " + Item.Isim);
                Console.WriteLine("Kullanici Soyadi: " + Item.Soyisim);
                Console.WriteLine("Kullanici Yas: " + Item.Yas);
            }

            Console.WriteLine("********");

            yeniListe.Clear();
        }
    }

    public class Kullanicilar
    {
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }

    }
}