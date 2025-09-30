using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint1.Task7.V10.Lib;
namespace Tyuiu.KochetovKO.Sprint1.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 1 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Спринт №1                                                                ");
            Console.WriteLine("Тема: Операторы составного присваивания                                  ");
            Console.WriteLine("**********************************************                           ");
            Console.WriteLine("Задание №7                                                               ");
            Console.WriteLine("Вариант №10                                                              ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                            ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                                 ");
            Console.WriteLine("Написать программу, которая вычисляет математическое выражение           ");
            Console.WriteLine("по исходным значениям данных, вводимых пользователем                     ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                        ");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("введите значение x : ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* Результат");
            Console.WriteLine("*********************************************************************");

            double res = Convert.ToDouble(ds.Calculate(x));
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}