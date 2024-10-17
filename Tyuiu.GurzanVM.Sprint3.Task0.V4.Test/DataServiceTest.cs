using Tyuiu.GurzanVM.Sprint3.Task0.V4.Lib;

namespace Tyuiu.GurzanVM.Sprint3.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(startValue, startValue);

            double wait = 1.2096335443730357;

            Assert.AreEqual(wait, res);
        }
    }
}