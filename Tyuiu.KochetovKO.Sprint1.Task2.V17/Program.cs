
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint1.Task2.V17.Lib;
namespace Tyuiu.KochetovKO.Sprint1.Task2.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 1 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Спринт №1                                                            ");
            Console.WriteLine("Тема: Арифметические операторы в C#                                  ");
            Console.WriteLine("**********************************************                       ");
            Console.WriteLine("Задание №2                                                           ");
            Console.WriteLine("Вариант №17                                                          ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                        ");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                             ");
            Console.WriteLine("Написать программу которая запрашивает у пользователя исходные данные");
            Console.WriteLine("выполняет указанные расчёты и печатает результат на экране.          ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                    ");
            Console.WriteLine("*********************************************************************");

            int x;

            Console.WriteLine("Введите количество минут : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* Результат");
            Console.WriteLine("*********************************************************************");

            DataService ds = new DataService();
            Console.WriteLine(ds.ConvertMinutesToHours(x));

            Console.ReadLine();



        }
    }
}