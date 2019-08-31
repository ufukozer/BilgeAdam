using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyFirstString = "deneme";
            string MySecondString = "enemed";
            string RandomString = "Denedim ve deniyorum.";
            int[] FirstInt = { 1, 2, 3, 4 };
            int[] SecondInt = { 5, 6, 7, 8 };
            int[] RandomInt = { 0, 2, 5, 0, 4 };
            int[] Bubble = { 1, 2, 4, 5, 8 };
            int IntFirst = 213;
            int IntSecond = 569;
            RepeatString(MyFirstString);
            Anagram(MyFirstString, MySecondString);
            ReverseString(MyFirstString);
            WordCount(RandomString);
            RepeatChr(MyFirstString);
            RepeatChrVerify(MyFirstString);
            ChangeChar(RandomString);  
            AdditionAndSubstraction(FirstInt, SecondInt);
            SortArray(FirstInt);
            TransportZeroEnd(RandomInt);
            ChangeInt(IntFirst, IntSecond);
            BubbleSorting(Bubble);
            Console.ReadLine();
        }
        static void RepeatString(string RepeatStr)
        {
            List<char> ChrList = new List<char>(RepeatStr.ToCharArray());
            var Query = ChrList.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();
            Console.WriteLine(string.Join(" ", Query));
        }
        static void Anagram(string FirstStr, string SecondStr)
        {
            string FirstConcat = String.Concat(FirstStr.OrderBy(c => c));
            string SecondConcat = String.Concat(SecondStr.OrderBy(c => c));
            if (FirstConcat == SecondConcat)
            {
                Console.WriteLine("Evet Anagram.");
            }
            else
            {
                Console.WriteLine("Hayır Anagram Değil.");
            }
        }
        static void ReverseString(string Str)
        {
            List<char> ChrList = new List<char>(Str.ToCharArray());
            List<char> ReverseList = new List<char>();
            for (int i = ChrList.Count; i > 0; i--)
            {
                ReverseList.Add(ChrList[i - 1]);
            }
            Console.WriteLine(string.Join("", ReverseList));
        }
        static void WordCount(string RandomStr)
        {
            List<string> CountList = new List<string>(RandomStr.Split(" ").ToList());
            Console.WriteLine(CountList.Count);
        }
        static void RepeatChr(string RandomStr)
        {
            List<char> ChrList = new List<char>(RandomStr.ToCharArray());
            var Query = ChrList.GroupBy(x => x).Where(g => g.Count() == 1).Select(y => y.Key).ToList();
            Console.WriteLine(string.Join("", Query));
        }
        static void RepeatChrVerify(string RandomStr)
        {
            List<char> ChrList = new List<char>(RandomStr.ToCharArray());
            var Query = ChrList.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();
            if (Query.Count == 0)
            {
                Console.WriteLine("Doğrulandı Benzersiz.");
            }
            else
            {
                Console.WriteLine("Doğrulandı Benzersiz Değil.");
            }

        }
        static void ChangeChar(string ChangeChr)
        {
            List<char> ChrList = new List<char>(ChangeChr.ToCharArray());
            //var Query = ChrList.Where(g => g.ToString() == " ").Select(y => y.ToString() == "-").ToList();
            //var Query = ChrList[ChrList.FindIndex(ind => ind.Equals(" "))] = Convert.ToChar("-");
            for (int i = 0; i < ChrList.Count; i++)
            {
                if (Convert.ToString(ChrList[i]) == " ")
                {
                    ChrList[i] = Convert.ToChar("-");
                }
            }
            Console.WriteLine(string.Join("", ChrList));
        }
        static void AdditionAndSubstraction(int[] FInt, int[] SInt)
        {
            int SumFInts = 0;
            int SumSInts = 0;
            for (int i = 0; i < FInt.Length; i++)
            {
                SumFInts += FInt[i];
            }
            for (int i = 0; i < SInt.Length; i++)
            {
                SumSInts += SInt[i];
            }
            Console.WriteLine("Toplam: " + (SumFInts + SumSInts));
            if (SumFInts > SumSInts)
            {
                Console.WriteLine("Çıkartma: " + (SumFInts - SumSInts));
            }
            else
            {
                Console.WriteLine("Çıkartma: " + (SumSInts - SumFInts));
            }
        }
        static void SortArray(int[] SArr)
        {
            Console.WriteLine(String.Join(",", SArr.OrderByDescending(o => o)));
        }
        static void TransportZeroEnd(int[] RandomInt)
        {
            List<int> ListInt = new List<int>(RandomInt);
            List<int> ZeroList = new List<int>();
            int ListCount = ListInt.Count;
            for (int i = 0; i < ListCount; i++)
            {
                if (ListInt[i] == 0)
                {
                    ZeroList.Add(ListInt[i]);
                }
            }
            for (int i = 0; i < ListCount; i++)
            {
                if (ListInt[i] == 0)
                {
                    ListInt.RemoveAt(i);
                    i = -1;
                    ListCount -= 1;
                }
            }
            Console.WriteLine(String.Join(",", ListInt.Concat(ZeroList)));
        }
        static void ChangeInt(int FirstInt, int SecondInt)
        {
            int FirstIntLength = FirstInt.ToString().Length;
            int SecondIntLength = SecondInt.ToString().Length;
            SecondInt = Convert.ToInt32(Convert.ToString(FirstInt) + Convert.ToString(SecondInt));
            FirstInt = Convert.ToInt32(SecondInt.ToString().Substring(0, FirstIntLength));
            SecondInt = Convert.ToInt32(SecondInt.ToString().Substring(FirstIntLength, SecondIntLength));
            Console.WriteLine("1. Sayı: " + FirstInt.ToString());
            Console.WriteLine("2. Sayı: " + SecondInt.ToString());
        }
        static void BubbleSorting(int[] BubbleArray)
        {
            int ArrValue = 0;
            for (int i = 0; i < BubbleArray.Length; i++)
            {
                for (int sort = 0; sort < BubbleArray.Length - 1; sort++)
                {
                    if (BubbleArray[sort] > BubbleArray[sort + 1])
                    {
                        ArrValue = BubbleArray[sort + 1];
                        BubbleArray[sort + 1] = BubbleArray[sort];
                        BubbleArray[sort] = ArrValue;
                    }
                }
            }
            for (int i = 0; i < BubbleArray.Length; i++)
            {
                Console.Write(BubbleArray[i]);
            }
        }
    }
}

//Sorular:
//1.	Bir string’de yinelenen karakterleri yazdırın.
//2.	İki string’in birbirinin anagramı olup olmadığı kontrol ediniz.
//3.	String, reverse metodu kullanılmadan nasıl ters çevirilir?
//4.	String’deki kelime sayısını yazdırın.
//5.	String’deki tekrar eden karakterleri çıkarın.
//6.	String’deki karakterlerin birbirlerinden benzersiz olduğunu doğrulayın.
//7.	String’deki bütün boşluk karakterlerini tire ile değiştirin.
//8.	2 Integer Array’deki sayıları ayrı ayrı toplatın, array toplamlarını birbirinden çıkartın.
//9.	Array’i büyükten küçüğe sıralayın.
//10.	Integer Array’deki sıfırları, array’in sonuna taşıyın.
//11.	Geçici değişken kullanmadan 2 numerik değeri birbirleri ile yer değiştirin.