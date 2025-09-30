using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KochetovKO.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            double z = 2 * (1 / Math.Tan(3 * x)) - (Math.Log(x) * Math.Cos(x)) / (Math.Log(1 + Math.Pow(x, 2)));
            double q = Math.Round(z, 3);
            return q;
        }
    }
}
