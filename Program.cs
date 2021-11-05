using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {

            // Güncel zamanı alalım
            double time = DateTime.Now.Hour;
            //double time = 17.1;
            //Mesai saatleri içerisinde mi kontrol edip ekrana yazdıralım
            if (time<08 || time >17){
                Console.WriteLine("Mesai saatleri dışındasınız!");
            //Öğle arası olup olmadığını kontrol edelim.
            }else if (time>=12 & time <13){
                Console.WriteLine("Öğle arasındayız!");
            //Mesai saatleri içerisindeysek yapılacak eylem
            }else {
                Console.WriteLine("Mesai saatleri içerisindesiniz!");
            }

        }
    }
}
