using Tyuiu.TatarinovDA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.TatarinovDA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateDayOfWeek()
        {
            DataService ds = new DataService();
            int k1 = 1;
            int expected1 = 1;
            int actual1 = ds.Calculate(k1);
            Assert.AreEqual(expected1, actual1);

            int k2 = 7;
            int expected2 = 7;
            int actual2 = ds.Calculate(k2);
            Assert.AreEqual(expected2, actual2);

            int k3 = 8;
            int expected3 = 1;
            int actual3 = ds.Calculate(k3);
            Assert.AreEqual(expected3, actual3);

            int k4 = 365;
            int expected4 = 1;
            int actual4 = ds.Calculate(k4);
            Assert.AreEqual(expected4, actual4);


        }
    }
}
