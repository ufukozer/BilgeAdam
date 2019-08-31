using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace CSharpAlgoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            RepeatStringNTimes("Ufuk Özer", 4);
            int[] MyArray = { 123, 451, 144343, 657576575, -14343 }; 
            OrderArray(MyArray);
            ReverseString("deneme");
            StartAndFinish(MyArray);
            MinAndMaxArray(MyArray);
            Days();
            Console.ReadLine();
        }
        static void RepeatStringNTimes(string namesurname, int n)
        {
            string ConsoleOutput = string.Empty;
            for (int i = 0; i < n; i++)
            {
                ConsoleOutput += namesurname + " ";
            }
            Console.WriteLine(ConsoleOutput.Trim());
        }
        static void OrderArray(int [] MinToMaxArray)
        {
            List<int> MinToMaxList = new List<int>(MinToMaxArray);
            MinToMaxList.Sort();
            Console.WriteLine(string.Join(",", MinToMaxList.ToArray()));
        }
        static void ReverseString(string reverse)
        {
            List<string> ReversingString = new List<string>(reverse.Select(a => a.ToString()));
            //char[] ReversingChar = reverse.ToCharArray(0, reverse.Length);
            ReversingString.Reverse();
            Console.WriteLine(string.Join("", ReversingString.ToArray()));
        }
        static void StartAndFinish(int[] LookArr)
        {
            int[] LastArr = new int[4];
            LastArr[0] = LookArr[0];
            LastArr[1] = LookArr[1];
            LastArr[2] = LookArr[LookArr.Length - 2];
            LastArr[3] = LookArr[LookArr.Length - 1];
            List<int> PrintList = new List<int>(LastArr);
            Console.WriteLine(string.Join(",", PrintList.ToArray()));
        }
        static void MinAndMaxArray(int[] MAndMArr)
        {
            List<int> MinAndMaxList = new List<int>(MAndMArr);
            MinAndMaxList.Sort();
            Console.WriteLine(MinAndMaxList[0] + "," + MinAndMaxList[MinAndMaxList.Count - 1]);
        }
        static void Days()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            if (currentCulture.ToString() == "tr-TR")
            {
                List<string> WeekDays = new List<string> { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
                string now = DateTime.Now.ToString("dddd");
                for (int i = 0; i < WeekDays.Count; i++)
                {
                    if (WeekDays[i] == now)
                    {
                        WeekDays[i] = now + "(Bugün)";
                    }
                }
                Console.WriteLine(string.Join(",", WeekDays.ToArray()));
            }
            else 
            {
                Console.WriteLine("Kültürün Bozuk, Git Kültürlen Gel :D");
            }
        }
    }
}
