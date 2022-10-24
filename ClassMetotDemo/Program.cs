namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 101;
            musteri1.Ad = "Furkan";
            musteri1.Soyad = "İLHAN";
            musteri1.KrediTutari = 15000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 102;
            musteri2.Ad = "Cristiano";
            musteri2.Soyad = "RONALDO";
            musteri2.KrediTutari = 100000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 103;
            musteri3.Ad = "Kamil";
            musteri3.Soyad = "ABASIYANIK";
            musteri3.KrediTutari = 2000;

            

            List<Musteri> musteriler = new List<Musteri>();
            //MusteriManager.Ekle(musteriler, musteri1);
            //MusteriManager.Ekle(musteriler, musteri2);
            //MusteriManager.Ekle(musteriler, musteri3);

            musteriler.Add(musteri1);

            //MusteriManager.Sil(musteriler, musteri2);
            //MusteriManager musteriManager = new MusteriManager();
            MusteriManager.Listele(musteriler);
        }
    }
}