using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KochetovKO.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
           string y = value;
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i] != y[y.Length - 1 - i])
                {
                    return false;

                }
            }
            return true;
        }
    }       
}
