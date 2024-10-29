using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GurzanVM.Sprint3.Task7.V28.Lib
{
    public class DataService : ISprint3Task7V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            valueArray[0] = 0;
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (startValue == 0)
                {
                    y = 0;
                    valueArray[cnt] = y;
                    cnt++;
                }
                else
                {
                    y = Math.Round(Math.Cos(2 * x) + (Math.Sin(x) / x + 2.5) + 2 * x, 2);
                    valueArray[cnt] = y;
                    cnt++;
                }
                
                
                
            }
            return valueArray;
        
        }
    }
}
