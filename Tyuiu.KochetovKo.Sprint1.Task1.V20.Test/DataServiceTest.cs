using Tyuiu.KochetovKO.Sprint1.Task1.V20.Lib;
using System;

namespace Tyuiu.KochetovKO.Sprint1.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            var res = ds.Calculate(x, y);

            Console.WriteLine($"Результат: {res}");
        }
    }
}