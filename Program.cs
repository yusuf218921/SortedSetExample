using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet_HashSetExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sayilar = new List<int>();
            var r = new Random();
            var countList = new List<int>();
            int count = 0;
            var sayiSet = new SortedSet<int>();
            int sayi = 10;
            int toplam = 0;
            int iterasyon = 100;

            for(int i = 0; i< iterasyon; i++)
            {
                count = 0;
                while (true)
                {
                    sayiSet.Clear();
                    sayilar.Clear();
                    for (int k = 0; k < 10; k++)
                    {
                        sayilar.Add(r.Next(0, sayi));
                    }
                    foreach (var item in sayilar)
                    {
                        sayiSet.Add(item);
                    }
                    if (sayiSet.Count == 10)
                    {
                        countList.Add(count);
                        Console.WriteLine(count);
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            foreach (var item in countList)
            {
                Console.Write($"{item,15}");
                toplam += item;
            }
            Console.WriteLine();
            int sonuc = toplam / iterasyon;
            Console.WriteLine($"\n\nSonuc -> {sonuc}");

        }
        
        public static void SortedSetDeneme1()
        {
            var list = new SortedSet<string>();

            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet Eklendi");
            }
            else
            {
                Console.WriteLine("Ekleme Başarısız");
            }
            Console.WriteLine("{0}", list.Add("Ahmet") == true ? "Ahmet Eklendi" : "Ekleme Başarısız");
            Console.WriteLine("{0}", list.Add("Ahmet") == true ? "Ahmet Eklendi" : "Ekleme Başarısız");

            list.Add("Şule");
            list.Add("Ali");
            list.Add("Yusuf");
            list.Add("Fatih");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Remove("Şule");
            list.RemoveWhere(deger => deger.Contains("a"));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}
