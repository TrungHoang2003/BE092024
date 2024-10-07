using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Giai pt bac 1");
                Console.WriteLine("2. Giai pt bac 2");
                Console.WriteLine("3. Thoat");
                Console.Write("Nhap lua chon: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        giaiPTbac1();
                        break;
                    case 2:
                        giaiPTbac2();
                        break;
                    case 3:
                        Console.WriteLine("Thoat chuong trinh.");
                        return;
                    default:
                        Console.WriteLine("Du lieu nhap khong hop le");
                        break;
                }
                Console.WriteLine();
            }
        }
        static double input(double n)
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out n))
                    break;
                Console.Write("Du lieu khong hop le, nhap lai: ");
            }
            return n;
        }
        static void giaiPTbac1()
        {
            double a = 0, b = 0;
            Console.WriteLine("giai phuong trinh bac 1");

            Console.Write("Nhap a: ");
            a = input(a);
            Console.Write("Nhap b: ");
            b = input(b);

            double x = -b / a;
            Console.WriteLine("nghiem cua phuong trinh la: " + x);
        }
        static void giaiPTbac2()
        {
            double a = 0, b = 0, c = 0;
            Console.WriteLine("giai phuong trinh bac 2");

            Console.Write("Nhap a: ");
            a = input(a);
            Console.Write("Nhap b: ");
            b = input(b);
            Console.Write("Nhap c: ");
            c = input(c);

            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta) / (2 * a));
                double x2 = (-b - Math.Sqrt(delta) / (2 * a));
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet: x1 = " + x1 + ", x2 = " + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep: x = " + x);
            }
            else
                Console.WriteLine("phuong trinh vo nghiem");
        }
    }
}
