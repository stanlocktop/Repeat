// Susing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Напиши число, щоб дізнатись парне врер чи ні");
            //Console.ResetColor();

            //int a;
            //a = int.Parse(Console.ReadLine());

            //if (a % 2 == 0)
            //    {
            //    Console.WriteLine("Число парне");
            //}
            //else
            //{
            //    Console.WriteLine("Число не парне!");
            //}
            //Console.ReadKey();


            Console.WriteLine("Введите номер дня недели (1 - понедельник, 7 - воскресенье): ");
            if (int.TryParse(Console.ReadLine(), out int dayNumber))
            {
                switch (dayNumber)
                {
                    case 1:
                        Console.WriteLine("1 - Понедельник");
                        break;
                    case 2:
                        Console.WriteLine("2 - Вторник");
                        break;
                    case 3:
                        Console.WriteLine("3 - Среда");
                        break;
                    case 4:
                        Console.WriteLine("4 - Четверг");
                        break;
                    case 5:
                        Console.WriteLine("5 - Пятница");
                        break;
                    case 6:
                        Console.WriteLine("6 - Суббота");
                        break;
                    case 7:
                        Console.WriteLine("7 - Воскресенье");
                        break;
                    default:
                        Console.WriteLine("Ошибка, введите число от 1 до 7");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное число.");
            }
            Console.ReadKey();
        }
    }
}
