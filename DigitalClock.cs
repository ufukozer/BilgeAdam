using System;

namespace DigitalClock
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true) {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
