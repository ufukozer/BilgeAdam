using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Durakta Otobüs Bekliyorsun!");
            string driver, passenger, bus, bus_route, bus_stop, bus_door;
            int bus_card;

            while (true)
            {
                Console.WriteLine("Otobüs Geldi mi? E/H");
                bus = Console.ReadLine();
                if (bus == "E")
                {
                    Console.WriteLine("Otobüs Geliyor!");
                    Console.WriteLine("Otobüs Nereye Gidiyor! KIZILAY ya da Başka Bir Yer?");
                    bus_route = Console.ReadLine();
                    if (bus_route == "KIZILAY")
                    {
                        Console.WriteLine("Otobüse Bin!");
                        Console.WriteLine("Otobüs Kartında Kaç TL Var?");
                        bus_card = Convert.ToInt32(Console.ReadLine());
                        if (bus_card != 0)
                        {
                            Console.WriteLine("Otobüse Binildi!");
                        Seyahat1:
                            Console.WriteLine("Kızılay'a Seyahat Ediyorsun!");
                            Console.WriteLine("Kızılay'a Geldin Mi? E/H");
                            bus_stop = Console.ReadLine();
                            if (bus_stop == "E")
                            {
                                Kapı1:
                                Console.WriteLine("Kızılay'a Geldin! Otobüsün Kapıları Açıldı Mı? E/H");
                                bus_door = Console.ReadLine();
                                if (bus_door == "E")
                                {
                                    Console.WriteLine("Kızılay'da İndin Hayırlı Olsun!");
                                    Console.Read();
                                    break;
                                }
                                else
                                {
                                    goto Kapı1;
                                }
                            }
                            else
                            {
                                goto Seyahat1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Paran Yok Alternatifleri Dene. Otobüste Yolcu Var Mı? E/H");
                            passenger = Console.ReadLine();
                            Console.WriteLine("Otobüs Şoföründen Rica Et? Şoför İyi Niyetli Mi? E/H");
                            driver = Console.ReadLine();
                            if (passenger == "E" || driver == "E")
                            {
                                if (passenger == "E")
                                {
                                    Console.WriteLine("Yolculardan Para Dilendin ve Sana Para Verdiler! Otobüse Bindin!");
                                }
                                else if (driver == "E")
                                {
                                    Console.WriteLine("Şoförün İyi Niyetini Suistimal Ederek Otobüse Bindin!");
                                }
                                Seyahat2:
                                Console.WriteLine("Kızılay'a Seyahat Ediyorsun!");
                                Console.WriteLine("Kızılay'a Geldin Mi? E/H");
                                bus_stop = Console.ReadLine();
                                if (bus_stop == "E")
                                {
                                    Kapı2:
                                    Console.WriteLine("Kızılay'a Geldin! Otobüsün Kapıları Açıldı Mı? E/H");
                                    bus_door = Console.ReadLine();
                                    if (bus_door == "E")
                                    {
                                        Console.WriteLine("Kızılay'da İndin Hayırlı Olsun!");
                                        Console.Read();
                                        break;
                                    }
                                    else
                                    {
                                        goto Kapı2;
                                    }
                                }
                                else
                                {
                                    goto Seyahat2;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Otobüsten İn Ve Para Yüklemeye Git!");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kızılay Otobüsünü Bekle!");
                    }

                }
                else
                {
                    Console.WriteLine("Otobüs Gelmiyor Bekle!");
                }
            }
        }
    }
}
