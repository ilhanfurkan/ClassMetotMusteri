using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public static void Ekle(List<Musteri> liste , Musteri musteri)
        {
            liste.Add(musteri);
        }
        public static void Sil(List<Musteri> liste , Musteri musteri)
        {
            liste.Remove(musteri);
        }
        public static void Listele(List<Musteri> musteriler)
        {
            foreach (var musterin in musteriler)
            {
                Console.WriteLine(musterin.Id + " " + musterin.Ad + " " + musterin.Soyad + " : " + musterin.KrediTutarı + "TL");
            }
        }

    }
}
