using Tyuiu.DmiterkoKD.Sprint3.Task3.V17.Lib;
namespace Tyuiu.DmiterkoKD.Sprint3.Task3.V17.Test
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
            string s = "*vn98n! b,";
            int wait = 98;           
            double res = ds.ConvertStringToInt(s);
            Assert.AreEqual(res, wait);
        }
    }
}