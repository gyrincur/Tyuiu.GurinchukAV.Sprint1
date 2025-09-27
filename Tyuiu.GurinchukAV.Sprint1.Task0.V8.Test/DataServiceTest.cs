using Tyuiu.GurinchukAV.Sprint1.Task0.V8.Lib;

namespace Tyuiu.GurinchukAV.Sprint1.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1.875, res);
        }
    }
}
