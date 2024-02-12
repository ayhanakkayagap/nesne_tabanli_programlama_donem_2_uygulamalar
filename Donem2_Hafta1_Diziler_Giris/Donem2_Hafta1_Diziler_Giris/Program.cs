using System;

namespace Donem2_Hafta1_Diziler_Giris
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[6] { 3,4,6,123,234,1};
            Console.WriteLine(sayilar[0]);

            string[] isimler = new string[3] { "ayhan", "ahmet", "ayşe" };
            Console.WriteLine(isimler[1]);

            int[] sayilar2 = { 10, 20, 30, 40 };

            for(int i = 0; i < sayilar2.Length; i++)
            {
                Console.WriteLine(sayilar2[i]);
            }

            Console.WriteLine("***************");

            foreach(int sayi in sayilar2)
            {
                Console.WriteLine(sayi);
            }
            
        }
    }
}
