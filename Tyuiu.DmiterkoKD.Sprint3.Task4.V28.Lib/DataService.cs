using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DmiterkoKD.Sprint3.Task4.V28.Lib
{
    public class DataService : ISprint3Task4V28
    {
        public double Calculate(int startValue, int stopValue)
        {
            int x;
            double res = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                if (x ==0)
                {
                    continue;
                }
                res = res + ((Math.Cos(x) + Math.Sin(x)) / x);
            }
            return Math.Round(res, 3);
        }        
    }
}
