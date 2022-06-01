//Beni Yaratan Elbet Yolumu Gösterir .Şuara78
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte number1;
            byte number2;
            byte number3;
            byte carpim;

            Console.WriteLine("Please enter first number:");
            number1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Please enter second number:");
            number2 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Please enter third number :");
            number3 = Convert.ToByte(Console.ReadLine());

            carpim = Convert.ToByte(number1 * number2 * number3);

            Console.WriteLine("Multipication of three numbers :" + " " + carpim);

            Console.Read();



        }
    }
}
