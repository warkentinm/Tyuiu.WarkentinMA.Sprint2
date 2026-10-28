using Tyuiu.WarkentinMA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.WarkentinMA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2000;
            int m = 12;
            int n = 31;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "01.01.2001";
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            int g = 2000;
            int m = 11;
            int n = 30;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "01.12.2000";
            Assert.AreEqual(wait, res);
        }
    }
}
