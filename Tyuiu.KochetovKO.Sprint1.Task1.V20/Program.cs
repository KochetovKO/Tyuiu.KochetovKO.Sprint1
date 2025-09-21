
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint1.Task1.V20.Lib;
namespace Tyuiu.KochetovKO.Sprint1.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 1 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Спринт №1                                                            ");
            Console.WriteLine("Тема: Базовые навыки работы в C#                                     ");
            Console.WriteLine("**********************************************                       ");
            Console.WriteLine("Задание №1                                                           ");
            Console.WriteLine("Вариант №20                                                          ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                        ");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                             ");
            Console.WriteLine("Написать программу которая запрашивает у пользователя исходные данные");
            Console.WriteLine("вычисляет результат оп формуле (x * y / 2) и печатает его на экране  ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                    ");
            Console.WriteLine("*********************************************************************");

            double x, y;

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* Результат");
            Console.WriteLine("*********************************************************************");

            DataService ds = new DataService();
            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();



        }
    }
}