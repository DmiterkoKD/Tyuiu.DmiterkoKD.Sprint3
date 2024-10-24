using Tyuiu.DmiterkoKD.Sprint3.Task2.V29.Lib;
namespace Tyuiu.DmiterkoKD.Sprint3.Task2.V29.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            int start = 1;
            int end = 18;
            double res = ds.GetSumSeries(x, start, end);
            double wait = -0.186;
            Assert.AreEqual(res, wait);
        }
    }
}