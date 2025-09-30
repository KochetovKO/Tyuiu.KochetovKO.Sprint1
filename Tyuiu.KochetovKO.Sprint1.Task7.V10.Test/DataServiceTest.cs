using Tyuiu.KochetovKO.Sprint1.Task7.V10.Lib;
namespace Tyuiu.KochetovKO.Sprint1.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 14.031;
            double y = (ds.Calculate(x));
            Assert.AreEqual(wait, y);
        }
    }
}
