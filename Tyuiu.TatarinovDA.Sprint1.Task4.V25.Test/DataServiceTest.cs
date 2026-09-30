using Tyuiu.TatarinovDA.Sprint1.Task4.V25.Lib;
namespace Tyuiu.TatarinovDA.Sprint1.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double a = 0.5;
            double expected = Math.Round((1 - Math.Cos(a)) / Math.Pow(Math.Sin(a), 2), 3);
            double actual = ds.Calculate(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
