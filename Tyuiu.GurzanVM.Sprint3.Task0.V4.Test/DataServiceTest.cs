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
            int stopValue = 10;

            double res = ds.GetMultiplySeries(startValue, startValue);

            double wait = 1.0998334166468282;

            Assert.AreEqual(wait, res);
        }
    }
}