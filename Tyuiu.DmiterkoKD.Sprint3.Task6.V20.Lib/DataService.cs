﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DmiterkoKD.Sprint3.Task6.V20.Lib
{
    public class DataService : ISprint3Task6V20
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int i = 1; i <= x; i++)
                {
                    if (x%i ==0 & i <12)
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }
    }
}
