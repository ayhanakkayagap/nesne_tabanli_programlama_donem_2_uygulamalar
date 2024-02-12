using System;
using System.Collections;
using System.Collections.Generic;

namespace Donem2_Hafta2_Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> okulNo = new List<int>();
            okulNo.Add(11200);
            okulNo.Add(234);
            okulNo.Add(340);
            okulNo.Add(24);
            okulNo.Add(23);
            okulNo.Add(1234);
            okulNo.Add(2134);
            okulNo.Sort();
            okulNo.Reverse();
            foreach(var item in okulNo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******************");
            ArrayList liste = new ArrayList();
            liste.Add("Bilişim");
            liste.Add(100);
            liste.Add('m');
            liste.Add(3.14);
            liste.Add(true);
            liste.Add("Bilişim");
         
            for(int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }

            

        }
    }
}
