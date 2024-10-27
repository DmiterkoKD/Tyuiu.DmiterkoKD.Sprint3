using Tyuiu.DmiterkoKD.Sprint3.Task7.V22.Lib;
namespace Tyuiu.DmiterkoKD.Sprint3.Task7.V22.Test
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

            int len = end - start + 1;

            double[] value;
            value = new double[len];

            value[0] = 8.04;
            value[1] = 6.68;
            value[2] = 4.84;
            value[3] = 1.76;
            value[4] = 0.45;
            value[5] = 0.5;
            value[6] = -0.87;
            value[7] = -2.42;
            value[8] = -3.88;
            value[9] = -6.83;
            value[10] = -8.88;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(res, value);
        }
    }
}