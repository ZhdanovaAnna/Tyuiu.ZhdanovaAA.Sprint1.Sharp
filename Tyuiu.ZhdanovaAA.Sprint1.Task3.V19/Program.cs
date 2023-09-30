using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhdanovaAA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint1.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Жданова А. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание: 3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Жданова Анна Александровна                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу, которая печатает true или false в        *");
            Console.WriteLine("* зависимости от того, может ли шахматная фигура «Слон» с одного заданного*");
            Console.WriteLine("* поля шахматной доски перейти за один ход на другое.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1, x2, y1, y2;

            Console.WriteLine("Введите значение X1 (от 1 до 8): ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение X2 (от 1 до 8): ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y1 (от 1 до 8): ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y2 (от 1 до 8): ");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Слон может перейти на другое поле шахматной доски: {ds.ElephCanMove(x1, x2, y1, y2)}");
            Console.ReadKey();
        }
    }
}
