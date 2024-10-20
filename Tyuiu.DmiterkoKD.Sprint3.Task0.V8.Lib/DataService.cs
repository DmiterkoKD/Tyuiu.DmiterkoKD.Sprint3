using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DmiterkoKD.Sprint3.Task0.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double a = value;
            double p = 1;
            int k;
            for (k=startValue; k<=stopValue; k++)
            {
                p = p * ((Math.Pow(a,k)+1) * Math.Cos(4));
            }
            return Math.Round(p, 3);
        }
    }
}
