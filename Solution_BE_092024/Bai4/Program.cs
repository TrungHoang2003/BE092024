using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static double giaiThua(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * giaiThua(n - 1);
        }
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                Console.Write("Nhap so nguyen duong n: ");
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
                Console.Write("Du lieu khong hop le, nhap lai: ");
            }
            Console.WriteLine("Giai thua cua " + n + " la: " + giaiThua(n));
            Console.ReadKey();
        }

    }
}
