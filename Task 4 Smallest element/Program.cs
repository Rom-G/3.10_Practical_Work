using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Smallest_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Давайте найдём наименьшее число из введёных вами.");
            Console.Write("\nУкажите, сколько чисел будем сравнивать: ");
            int quantity = int.Parse(Console.ReadLine());

            int minValue = int.MaxValue;

            for (int i = 1; i < (quantity + 1); i++)
            {
                Console.WriteLine($"\nВведите {i}-е число: ");
                int number = int.Parse(Console.ReadLine());
                if (number < minValue)
                {
                    minValue = number;
                }
            }
            Console.WriteLine($"\nНаименьшее из введённых чисел: \n\t\t\t>>> {minValue} <<<");
            Console.ReadKey();
        }
    }
}
