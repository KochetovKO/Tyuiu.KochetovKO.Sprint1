using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KochetovKO.Sprint1.Task1.V20.Lib
{
    public class DataService : ISprint1Task1V20
    {
        public DataService() { }

        public double Calculate(double x, double y)
        {
            return (x * y / 2);
        }
    }
}
