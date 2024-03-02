using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор очков игры 21!");
            Console.WriteLine("Используются следующие обозначения номинала карты: 6, 7, 8, 9, 10, J, Q, K, T");
            Console.Write("\nПожалуйста, введите количество карт на руках: ");
            
            int quantity = int.Parse(Console.ReadLine());                                       //Количество карт - счётчик цикла.
            int sum = 0;                                                                        //Переменная суммы очков.

            for (int i = 1; i <= quantity;)
            {
                Console.WriteLine($"\nУкажите номинал {i}-й карты.");
                var n = Console.ReadLine();                                                     //Переменная номинала карты.

                bool validPicture = (n == "J") || (n == "Q") || (n == "K") || (n == "T");       //Переменные для проверки
                bool validNumber = int.TryParse(n, out int nValid);                             //корректности номинала.

                int value;                                                                      //Переменная для очков
                                                                                                //соответствующих номиналу текущей карты.

                if (validPicture)                                                               //Проверка корректности
                {                                                                               //введённого номинала
                    value = 10;                                                                 //и запись очков в 
                }                                                                               //в переменную value
                else if (validNumber && (nValid >= 6) && (nValid <= 10))
                {
                    value = int.Parse(n);
                }
                else
                {
                    Console.WriteLine("Указанный номинал не предусмотрен. Попробуйте снова...");
                    continue;
                }

                switch (value)
                {
                    case 6: sum = sum + 6; break;
                    case 7: sum = sum + 7; break;
                    case 8: sum = sum + 8; break;
                    case 9: sum = sum + 9; break;
                    case 10: sum = sum + 10; break;
                }

                i++;

            }

            Console.WriteLine($"\n\nСумма очков всех карт: {sum}.");
            Console.ReadKey();

        }
    }
}
