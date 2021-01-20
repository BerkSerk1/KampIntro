using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 1;
            for (var i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
                sayi += 1;
            }
        }
    }
}
