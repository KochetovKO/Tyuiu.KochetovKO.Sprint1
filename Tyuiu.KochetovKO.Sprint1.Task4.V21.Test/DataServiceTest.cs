using Tyuiu.KochetovKO.Sprint1.Task4.V21.Lib;
namespace Tyuiu.KochetovKO.Sprint1.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            var res = ds.Calculate(x, y);

            Console.WriteLine($"Результат: {res}");
        }
    }
}
