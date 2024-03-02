using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10_Practical_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определение чётного или нечётного числа.");  //Загловок

            Console.Write("\nВведите целое число: ");                       //Приглашение ввести число
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)                                            //Проверка чётности
            {
                Console.WriteLine("Число чётное.");
            }
            else
            {
                Console.WriteLine("Число нечётное.");
            }
            Console.ReadKey();                                              //Задержка вывода

        }
    }
}
