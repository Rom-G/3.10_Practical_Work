using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Checking_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Давайте проверим, является ли число простым.");

            #region Обработка входного значения и запись числа в переменную N

            int N;
            bool validN;

            do
            {
                Console.Write("\nВведите любое целое положительное число больше единицы: ");
                validN = int.TryParse(Console.ReadLine(), out N);
                if (!validN || N <= 1)
                {
                    Console.WriteLine("Введено некорректное значение.");
                }
            }
            while (!validN || N <= 1);

            #endregion


            #region Проверка, простое число или нет

            int i = 2;
            bool notPrimeNumber = false;

            while (i < N)
            {
                if (N % i == 0)
                {
                    notPrimeNumber = true;
                    break;
                }
                else
                {
                    i++;
                }
            }

            #endregion


            #region Вывод результата

            if (notPrimeNumber)
            {
                Console.WriteLine($"\nЧисло {N} не является простым.");
            }
            else
            {
                Console.WriteLine($"\nЧисло {N} является простым.");
            }

            Console.ReadKey();

            #endregion

        }
    }
}
