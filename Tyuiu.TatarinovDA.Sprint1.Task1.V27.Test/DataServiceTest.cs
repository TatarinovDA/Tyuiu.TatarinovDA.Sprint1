using Tyuiu.TatarinovDA.Sprint1.Task1.V27.Lib;
namespace Tyuiu.TatarinovDA.Sprint1.Task1.V27.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
