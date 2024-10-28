using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GurzanVM.Sprint3.Task5.V20.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int j, k;
            for (j = startValue1; j <= stopValue1; j++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries = sumSeries + Math.Pow((x / Math.Sin(x)) ,k);                                                      
                }
            }
            return Math.Round(sumSeries, 3);    
        }
    }
}
