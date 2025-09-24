using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint1.Task4.V21.Lib;
namespace Tyuiu.KochetovKO.Sprint1.Task3.V11
{
    class Program
    { 
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 1 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Спринт №1                                                            ");
            Console.WriteLine("Тема: Операторы составного присваивания                              ");
            Console.WriteLine("**********************************************                       ");
            Console.WriteLine("Задание №4                                                           ");
            Console.WriteLine("Вариант №21                                                          ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                        ");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                             ");
            Console.WriteLine("Написать программу которая запрашивает у пользователя исходные данные");
            Console.WriteLine("выполняет указанные расчёты и печатает результат на экране.          ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                    ");
            Console.WriteLine("*********************************************************************");


            Console.WriteLine("Введите значение x : ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y : ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* Результат");
            Console.WriteLine("*********************************************************************");

            Console.WriteLine(Math.Round(ds.Calculate(x, y), 3)); 
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}    
   