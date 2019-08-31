using System;
using System.Collections.Generic;
using System.Threading;

namespace Zar
{
    class Program
    {
        public static List<int> numbers = new List<int>();
        public static Random random = new Random();
        public static Thread thread1 = new Thread(Number1);
        public static Thread thread2 = new Thread(Number2);
        static void Main(string[] args)
        {
            thread1.Start();
            thread2.Start();
            Console.ReadLine();
        }
        
        private static void Number1()
        {
            for(int i = 0; i <= 100; i++)
            {
                int number = random.Next(6);
                Console.WriteLine("Zar 1: " + number);
            }
        }
        private static void Number2()
        {
            for (int i = 0; i <= 100; i++)
            {
                int number = random.Next(6);
                Console.WriteLine("Zar 2: " + number);
            }
        }
    }
}
