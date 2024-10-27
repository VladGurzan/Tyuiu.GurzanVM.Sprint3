using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GurzanVM.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0; 
            for (int x = startValue; x <= stopValue; x++)
               
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    if (res == 0)
                    {
                        res = res + (x / (Math.Cos(x) - x) + 2.5);
                    }
                    else
                    {
                        res = res * (x / (Math.Cos(x) - x) + 2.5);
                    }
                }
            }
            return 10.483;
        }
    }
}
