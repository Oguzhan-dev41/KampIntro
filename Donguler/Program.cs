using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı ";
            string kurs2 = "Programlamaya başlangıç için kurs ";
            string kurs3 = " java kursu";
            string kurs4 = "Python";
            string kurs5 = "c++ kursu";

            //array - dizi
            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı " , "Programlamaya başlangıç için kurs ", " java kursu","Python" ,"c++ kursu"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");
        }
    }
}
