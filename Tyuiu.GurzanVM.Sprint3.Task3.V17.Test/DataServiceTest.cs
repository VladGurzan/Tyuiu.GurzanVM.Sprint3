using Tyuiu.GurzanVM.Sprint3.Task3.V17.Lib;

namespace Tyuiu.GurzanVM.Sprint3.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "vn98n! b,.";
            string result = "";
            double wait = 98;
            double res = ds.ConvertStringToInt(value);
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    result += c;
                }
            }
            int number = Int32.Parse(result);
            Assert.AreEqual(wait, res);

        }
    }
}