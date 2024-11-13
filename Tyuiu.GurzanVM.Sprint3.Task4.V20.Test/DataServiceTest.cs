using Tyuiu.GurzanVM.Sprint3.Task4.V20.Lib;

namespace Tyuiu.GurzanVM.Sprint3.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int endValue = 5;

            double res = ds.Calculate(startValue, endValue);

            double wait = 0;

            Assert.AreEqual(res, wait);

        }
    }
}