using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Bai6
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot so nguyen bat ki: ");
            int n = 0;
            if (Common.ValidateData.checkSo(n) == (int)Error.Not_Number)
                Console.WriteLine("Du lieu nhap khong phai so");
            if (n % 2 == 0)
                Console.WriteLine(n + " la so chan.");
            else
                Console.WriteLine(n + " la so le.");
        }
    }
}
