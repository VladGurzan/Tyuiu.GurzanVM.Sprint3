using Tyuiu.GurzanVM.Sprint3.Task2.V30.Lib;

namespace Tyuiu.GurzanVM.Sprint3.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 11;

            double res = ds.GetMultiplySeries(value, startValue, startValue);

            double wait = 27;

            Assert.AreEqual(wait, res);
        }
    }
}