using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Guess_the_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру \"Угадай Число\"!");
            Console.Write("\nДавайте зададим диапазон, в котором будет загадано число, от 0 до: ");
            int maxValue = int.Parse(Console.ReadLine());                   //Определение границы диапазона

            Random randomize = new Random();
            int hiddenNumber = randomize.Next(maxValue + 1);                //"Загадывание" числа от 0 до границы диапазона включительно

            Console.WriteLine("\nЧисло загадано. Давайте угадывать! \nЕсли устанете, просто нажмите Enter.");

            while (true) 
            {
                Console.Write("\nВведите ваше предположение: ");
                string guess = Console.ReadLine();
                bool guessOrEmpty = int.TryParse(guess, out int guessNumber);

                #region Блок досрочного выхода и обработки ошибочного ввода
                if (guess == "") 
                { 
                    Console.WriteLine($"Было загадано число {hiddenNumber}. \nВсего хорошего. Возвращайтесь!");
                    Console.ReadKey();
                    break;
                }
                else 
                { 
                    if (!guessOrEmpty) 
                    { 
                        Console.WriteLine("Введено не число. Попробуйте ещё раз.");
                        continue;
                    }
                }
                #endregion

                #region Блок сравнения введённого числа с загаданным
                if (guessNumber < hiddenNumber)
                {
                    Console.WriteLine("Больше...");
                }
                else
                {
                    if (guessNumber > hiddenNumber) 
                    {
                        Console.WriteLine("Меньше...");
                    }
                    else
                    {
                        if (guessNumber == hiddenNumber) 
                        {
                            Console.WriteLine($"В точку! Было загадано число {hiddenNumber}.");
                            Console.ReadKey();
                            break;
                        }
                    }
                }
                #endregion
            }
        }
    }
}
