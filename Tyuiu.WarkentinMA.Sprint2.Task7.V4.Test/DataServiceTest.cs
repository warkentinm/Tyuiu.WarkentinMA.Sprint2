using Tyuiu.WarkentinMA.Sprint2.Task7.V4.Lib;

namespace Tyuiu.WarkentinMA.Sprint2.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.4;
            bool res = ds.CheckDotInShadedArea(x, y);
            var wait = true;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = -0.5;
            double y = 0.4;
            bool res = ds.CheckDotInShadedArea(x, y);
            var wait = true;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = 0.2;
            double y = 0.1;
            bool res = ds.CheckDotInShadedArea(x, y);
            var wait = false;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            bool res = ds.CheckDotInShadedArea(x, y);
            var wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
