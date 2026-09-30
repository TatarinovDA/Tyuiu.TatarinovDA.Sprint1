using Tyuiu.TatarinovDA.Sprint1.Task7.V3.Lib;
namespace Tyuiu.TatarinovDA.Sprint1.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;

            double expected = 4.0;

            double actual = ds.Calculate(x, y);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
