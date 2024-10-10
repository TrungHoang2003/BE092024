using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    internal class Program
    {
        string[] so = { "0", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };

        //static void donVi(int number)
        //{

        //    Console.WriteLine(so[number]);
        //}
        static string PrintNumber(int number)
        {
            string[] numberUnit = { "khong", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };
            string[] donvi = { "", "nghin", "tram", "chuc" };
            string numberConvert = "";
            int numberThousand = number / 1000;
            if (numberThousand > 0)
            {
                numberConvert += numberUnit[numberThousand];
                numberConvert += donvi[numberThousand];
            }
            number %= 1000;
            int numberHundred = number / 100;
            if (numberHundred > 0)
            {
                numberConvert += numberUnit[numberHundred];
                numberConvert += donvi[numberHundred];
            }
            number %= 100;
            int numberSundred = number / 10;
            Console.WriteLine(numberSundred);
            if (numberSundred > 0)
            {
                numberConvert += numberUnit[numberSundred];
                numberConvert += donvi[numberSundred];
            }
            return (numberConvert);
        }
        static void Main(string[] args)
        {



            string[] so = { "0", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };


            int n;
            Console.Write("Nhap 1 so bat ki: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
                Console.WriteLine("Vui long nhap lai: ");
            }



            Console.WriteLine(PrintNumber(n));

            //23        
            //if(Convert.ToString(n).Length ==1 )
            //{
            //    Console.WriteLine(so[n]);
            //}
            //else if(Convert.ToString(n).Length ==2 )
            //{
            //    Console.WriteLine(so[n/10] + " " +so[n%10]);

            //}
            //else if (Convert.ToString(n).Length ==3 )
            //{


            //    Console.WriteLine(so[n%10]);
            //}

        }
    }
}
