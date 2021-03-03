using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            bool sistemeGirisYapmiMi = true;
            Console.WriteLine(kategoriEtiketi);

            if (sistemeGirisYapmiMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);

            
        }
    }
}
