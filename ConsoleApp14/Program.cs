using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir dizi oluştur dizinin sınırını kullanıcı belirlicek dizinin tüm elemanlarına random bir değer bunu ekrana yazdıran program
            int a = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[] dizi = new int[a];
            for (int i = 0; i < dizi.Length ; i++)
            {
                dizi[i] = r.Next(a);
                Console.WriteLine(dizi[i]);
            }
        }
    }
}
