using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c;
            Console.Write("Nhap C: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out c))
                    break;
                Console.Write("Du lieu khong hop le, nhap lai: ");
            }
            double k = c + 273;
            Console.WriteLine("K: " + k);
            double f = (c * 18 / 10) + 32;
            Console.WriteLine("F: " + f);
        }
    }
}
