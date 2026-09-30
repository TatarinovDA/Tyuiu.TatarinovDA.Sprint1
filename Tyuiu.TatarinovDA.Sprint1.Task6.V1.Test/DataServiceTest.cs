using Tyuiu.TatarinovDA.Sprint1.Task6.V1.Lib;
namespace Tyuiu.TatarinovDA.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSymbolCode()
        {
            DataService ds = new DataService();
            string res1 = ds.SymbolCode("1");
            Assert.AreEqual("49", res1);

            string res2 = ds.SymbolCode("A");
            Assert.AreEqual("65", res2);
        }
    }
}
