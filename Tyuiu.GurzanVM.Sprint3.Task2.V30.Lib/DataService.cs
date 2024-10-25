using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GurzanVM.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 0;
            do
            {
                if (startValue == 1)
                {
                    result = result + ((Math.Pow(value, 2) * startValue) + 2);
                    startValue++;
                }
                else
                {
                    result = result * ((Math.Pow(value, 2) * startValue) + 2);
                    startValue++;
                }
            } while (startValue <= stopValue);
            return Math.Round(result, 3);
        }
    }
}
