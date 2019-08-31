using System;

namespace AdapterDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            string name = "";
            string description = "";
            Console.WriteLine("Yapılacak İşlem Nedir? 1. Ekleme, 2. Silme, 3. Güncelleme. Sayı Giriniz.");
            string deger = Console.ReadLine();
            if (deger == "0")
            {
                Console.WriteLine("");
            }
            else if (deger == "1")
            {
                Console.WriteLine("Ad Gir: ");
                name = Console.ReadLine();
                Console.WriteLine("Açıklama Gir: ");
                description = Console.ReadLine();
                Operation.SaveMain(name, description);
                Console.WriteLine("Yapılacak İşlem Nedir? 1. Ekleme, 2. Silme, 3. Güncelleme. Sayı Giriniz.");
                Console.ReadLine();
            }
            else if (deger == "2")
            {
                Console.WriteLine("Id Gir: ");
                id = Convert.ToInt32(Console.ReadLine());
                Operation.RemoveMain(id);
                Console.WriteLine("Yapılacak İşlem Nedir? 1. Ekleme, 2. Silme, 3. Güncelleme. Sayı Giriniz.");
                Console.ReadLine();
            }
            else if (deger == "3")
            {
                Console.WriteLine("Id Gir: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni Ad Gir: ");
                name = Console.ReadLine();
                Console.WriteLine("Yeni Açıklama Gir: ");
                description = Console.ReadLine();
                Operation.UpdateMain(id, name, description);
                Console.WriteLine("Yapılacak İşlem Nedir? 1. Ekleme, 2. Silme, 3. Güncelleme. Sayı Giriniz. Çıkış İçin 0.");
                Console.ReadLine();
            }
        }
    }
}
