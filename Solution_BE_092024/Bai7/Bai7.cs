using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Bai7
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
            int n = 0;
            if (Common.ValidateData.checkSo(n) == (int)Error.Not_Number)
                Console.WriteLine("Du lieu nhap khong phai so");
            else if (n <= 1)
                Console.WriteLine(n + " khong phai la so nguyen to.");
            else
            {
                bool isPrime = KiemTraSoNguyenTo(n);
                if (isPrime)
                {
                    Console.WriteLine(n + " la so nguyen to");
                }
                else
                    Console.WriteLine(n + " khong phai la so nguyen to");
            }

        }
    }
}
