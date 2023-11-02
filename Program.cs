using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONMBALE_MOSLASI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" number1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("number2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            for (double i = num1; i <= num2; i++)
            {
                double Donbale1 = (i*(i+1));
                double Donbale2 = Donbale1/2;
                
                




                Console.WriteLine("Donbale: {0}", Donbale2);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
