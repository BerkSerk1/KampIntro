using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurs = new string[] {"Java","Python","C#"};

            for (int i = 0; i < kurs.Length; i++)
            {
                Console.WriteLine(kurs[i]);
            }
            Console.WriteLine("------------------------------");
            
            foreach (string kurslar in kurs)
            {
                Console.WriteLine(kurslar);
            }
        }
    }
}
