using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint1.Task5.V5.Lib;
namespace Tyuiu.KochetovKO.Sprint1.Task5.V5
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
            Console.WriteLine("Задание №5                                                               ");
            Console.WriteLine("Вариант №5                                                               ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                            ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                                 ");
            Console.WriteLine("Написать программу которая присваивает переменной первое дробное значение");
            Console.WriteLine("выполняет указанные расчёты и печатает результат на экране.              ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                        ");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Введите значение x : ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* Результат");
            Console.WriteLine("*********************************************************************");

            int res = Convert.ToInt32(ds.Calculate(x));
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}            
