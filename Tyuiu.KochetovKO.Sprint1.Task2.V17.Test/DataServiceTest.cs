using Tyuiu.KochetovKO.Sprint1.Task2.V17.Lib;

namespace Tyuiu.KochetovKO.Sprint1.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Validexression()
        {
           DataService ds = new DataService();

            Console.Write("Введите количество минут");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int res = ds.ConvertMinutesToHours(minutes); 

            Console.WriteLine($"Результат: {res}");

        }   

    }
}
 