using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.EventHandlers;
using Tyuiu.TatarinovDA.Sprint1.Task3.V17.Lib;
namespace Tyuiu.TatarinovDA.Sprint1.Task3.V17.Test
{
    [TestClass]
   
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressionsHasZero()
        {
            DataService ds = new DataService();
            double number = 123.0456;
            bool actual = ds.ZeroCheck(number);
            bool expected = true;
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void ValidExpressionsHasNoZero()
        {
            DataService ds = new DataService();
            double number = 12.345;
            bool actual = ds.ZeroCheck(number);
            bool expected = false;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ValidExpressionsHasZeroShort()
        {
            DataService ds = new DataService();
            double number = 0.5;
            bool actual = ds.ZeroCheck(number);
            bool expected = true;
            Assert.AreEqual(expected, actual);

        }
    }
}
