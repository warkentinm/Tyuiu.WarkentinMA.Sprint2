using Tyuiu.WarkentinMA.Sprint2.Task4.V18.Lib;

namespace Tyuiu.WarkentinMA.Sprint2.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 18;
            double res = ds.Calculate(x, y);
            double wait = 7780.445;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 154.8;
            Assert.AreEqual(wait, res);
        }
    }
}
