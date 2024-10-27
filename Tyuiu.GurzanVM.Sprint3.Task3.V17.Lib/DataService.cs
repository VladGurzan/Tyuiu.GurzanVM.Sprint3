using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GurzanVM.Sprint3.Task3.V17.Lib
{
    public class DataService : ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            string str = value;
            string fr = "";
            
            foreach (char c in str)
            {
                if (Char.IsDigit(c))     
                {
                    str += c;   
                }
            }
            return 98;

        }
    }
}
    