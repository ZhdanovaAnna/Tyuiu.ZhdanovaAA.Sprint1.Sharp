using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhdanovaAA.Sprint1.Task6.V1.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint1.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Жданова А. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание: 6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Жданова Анна Александровна                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу, которая выводит код введенного           *");
            Console.WriteLine("* пользователем символа.                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = ""; 
            Console.WriteLine("Введите символ и нажмите <Enter>.");
            Console.WriteLine("Для завершения введите точку.");
            Console.WriteLine();
            do
            {
                Console.Write("-> ");
                value = Console.ReadLine();
                Console.WriteLine();


                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
                Console.WriteLine("***************************************************************************");

                if (value == ".")
                {
                    break;
                }
                Console.WriteLine($"Символ: {value} Код: {ds.SymbolCode(value)}");
                Console.WriteLine();
            }
            while (true);

        }
    }
}
