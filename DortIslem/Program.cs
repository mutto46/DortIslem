using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dortislem dortislem = new Dortislem();
            Console.Write("1. sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İki sayının toplamı: " + dortislem.Topla(sayi1, sayi2));
            Console.WriteLine("İki sayının çıkarması: " + dortislem.Cıkar(sayi1, sayi2));
            Console.WriteLine("İki sayının çarpması: " + dortislem.Carpma(sayi1, sayi2));
            Console.WriteLine("İki sayını bölmesi: " + dortislem.Bolme(sayi1, sayi2));
        }
    }
    public class Dortislem
    {

        public double Topla(double s1, double s2)
        {
            return s1 + s2;
        }
        public double Cıkar(double s1, double s2)
        {
            return s1 - s2;
        }
        public double Carpma(double s1, double s2)
        {
            return s1 * s2;
        }
        public double Bolme(double s1, double s2)
        {
            return s1 / s2;
        }
    }
}
