using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GurzanVM.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = 1;
            for (i = startValue; i <= stopValue; i++)
            {
                if (i == 1)
                {
                    sumSeries = sumSeries + ((Math.Sin(0.1) + i));
                }
                else
                {
                    sumSeries = sumSeries * ((Math.Sin(0.1) + i));
                }
            
            
            }
            return Math.Round (sumSeries, 3);   
        }   
    }
}
