using System;

namespace isletme
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] musteri_no = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] musteriler = { "emir", "berke", "can", "yasin", "enes" };

            musteri_no[0] = 15;
            musteriler[1] = "memet";
            Console.WriteLine("Müşteri No             Müşteri Ad");
            musteri_no[0]*=10;
            
            Console.WriteLine(musteri_no[0]+ "                     "+ musteriler[0]);
            Console.WriteLine(musteri_no[1] + "                      " + musteriler[1]);
            Console.WriteLine(musteri_no[2] + "                      " + musteriler[2]);
            Console.WriteLine(musteri_no[3] + "                      " + musteriler[3]);
            Console.WriteLine(musteri_no[4] + "                      " + musteriler[4]);



        }
    }
}
