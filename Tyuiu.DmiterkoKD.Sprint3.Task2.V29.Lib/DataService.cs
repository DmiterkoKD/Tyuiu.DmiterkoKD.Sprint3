using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DmiterkoKD.Sprint3.Task2.V29.Lib
{
    public class DataService : ISprint3Task2V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            double a = value;
            int k = startValue;
            do
            {
                sum = sum + ((Math.Pow(a, k) + 0.25) * Math.Cos(k));
                k++;
            } while (k <= stopValue);
            return Math.Round(sum, 3);
        }
    }
}
