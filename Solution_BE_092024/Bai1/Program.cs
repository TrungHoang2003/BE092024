using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            while (true)
            {
                Console.Write("Nhap so thu nhat: ");
                if (int.TryParse(Console.ReadLine(), out number1) == true)
                    break;
                else { Console.WriteLine("Du lieu khong hop le."); }
            }
            while (true)
            {
                Console.Write("Nhap so thu hai: ");
                if (int.TryParse(Console.ReadLine(), out number2) == true)
                    break;
                else { Console.WriteLine("Du lieu khong hop le."); }
            }
            int sum = number1 + number2;
            int difference = number1 - number2;
            double product = number1 * number2;

            Console.WriteLine("Tong 2 so la: " + sum);
            Console.WriteLine("Hieu 2 so la: " + difference);
            Console.WriteLine("Tich 2 so la: " + product);
        }
    }
}
