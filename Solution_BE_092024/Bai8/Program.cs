using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Nhap so phan tu cua mang: ");
            if (Common.ValidateData.checkSo(n) == (int)Error.Not_Number)
                Console.WriteLine("Du lieu nhap khong phai so");
            else
            {
                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Cac phan tu le cua mang: ");
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % 2 != 0)
                        Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                Console.Write("Cac phan tu chan cua mang: ");
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % 2 == 0)
                        Console.Write(arr[i] + " ");
                }

            }

        }
    }
}
