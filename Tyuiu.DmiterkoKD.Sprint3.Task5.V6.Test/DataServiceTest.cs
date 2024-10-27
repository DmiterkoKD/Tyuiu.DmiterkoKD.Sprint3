using Tyuiu.DmiterkoKD.Sprint3.Task5.V6.Lib;
namespace Tyuiu.DmiterkoKD.Sprint3.Task5.V6.Test
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
            DataService ds  = new DataService();
            int start1 = 1;
            int end1 = 3;
            int start2 = 1;
            int end2 = 10;
            double wait = 40.917;
            double res = ds.GetSumSumSeries(start1, start2, end1, end2);
            Assert.AreEqual(wait, res);
        }
    }
}