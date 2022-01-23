using System;

namespace Task._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2 dene 5 reqemli eded daxil et.
             * 1 ededin reqemleri ceminin ustune
             * 2 ededin reqemleri hasilini gel.
             * Neticenin axirina 1 ededin en axrinci reqemini artir
             */

            int a = 12345;
            int b = 23456;

            int cem = 0;
            int hasil = 1;
            int qaliq;
            int s = (a % 10);
            int netice;

            while (a > 0)
            {
                qaliq = a % 10; // 5
                a = (a - qaliq) / 10; // 1234
                cem = cem + qaliq; // 5+4+3+2+1=15
            }
            Console.WriteLine(cem);

            while (b > 0)
            {
                qaliq = b % 10; // 6
                b = (b - qaliq) / 10; //2345
                hasil = hasil * qaliq; //6*5*4*3*2=720
            }
            Console.WriteLine(hasil);

                
                int c = cem + hasil; // 720+15=735
            {
                Console.WriteLine(c);
            }
                
                int d = (c * 10) + s; // 7355
               
              
            {
                Console.WriteLine(d);
            }
            

            
            
            

            

            

        }
    }
}
