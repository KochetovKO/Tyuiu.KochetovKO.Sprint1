using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KochetovKO.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V0
    {
        public double Calculate(double x)
        {
            double q = x - 32;
            double e = q * 10;
            return e - 0.97;
        }
    }
}
