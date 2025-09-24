using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KochetovKO.Sprint1.Task4.V21.Lib
{
    public class DataService : ISprint1Task4V21
    {
        public double Calculate(double x, double y)
        {
            var s = (1 + x);
            var r = Math.Pow(s, 2);
            var w = r - y;
            var q = Math.Abs(w);
            return Math.Round(q / (x + y), 3);
        }
    }
}
