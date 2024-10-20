using Tyuiu.DmiterkoKD.Sprint3.Task0.V8.Lib;
namespace Tyuiu.DmiterkoKD.Sprint3.Task0.V8.Test
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
            double a = 0.25;
            int start = 1;
            int end = 10;
            double res = ds.GetMultiplySeries(a, start, end);
            double wait = 0.019;
            Assert.AreEqual(res, wait);
        }
    }
}