using Tyuiu.DmiterkoKD.Sprint3.Task4.V28.Lib;
namespace Tyuiu.DmiterkoKD.Sprint3.Task4.V28.Test
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
            int start = -5;
            int end = 5;
            double res = ds.Calculate(start, end);
            double wait  = 1.924;
            Assert.AreEqual(wait, res);
        }
    }
}