using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Bai5
    {
        static bool KiemTraSoNguyenTo(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n =0;
            if (Common.ValidateData.checkSo(n) == (int)Error.Not_Number)
            {
                Console.WriteLine("Du lieu nhap khong phai la so");
            }
            for (int i = 2; i < n; i++)
            {
                if (KiemTraSoNguyenTo(i))
                {
                    Console.WriteLine(i + " la so nguyen to");
                }

            }
            Console.ReadKey();
        }
    }
}
