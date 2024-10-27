using Tyuiu.DmiterkoKD.Sprint3.Task6.V20.Lib;
namespace Tyuiu.DmiterkoKD.Sprint3.Task6.V20.Test
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
            int start = 20;
            int end = 32;
            int wait = 152;
            int res = ds.GetSumTheDivisors(start, end);

            Assert.AreEqual(wait, res);
        }
    }
}