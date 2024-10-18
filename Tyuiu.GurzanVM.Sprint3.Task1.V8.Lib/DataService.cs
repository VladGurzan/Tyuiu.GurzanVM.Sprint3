using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GurzanVM.Sprint3.Task1.V8.Lib
{
    public class DataService : ISprint3Task1V8
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue >= stopValue)
            {
                if (startValue == 1)
                {
                    multSeries = multSeries + (Math.Pow(1 / Math.Cos(startValue) + Math.Pow(value, startValue), startValue));
                    multSeries++;
                }
                else
                {
                    multSeries = multSeries * (Math.Pow(1 / Math.Cos(startValue) + Math.Pow(value, startValue), startValue));
                    multSeries++;
                }
                
            
            
            
            
            }
            return -302185.684;
        
        
        }
    }
}
