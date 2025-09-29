using Tyuiu.GurinchukAV.Sprint1.Task5.V7.Lib;
namespace Tyuiu.GurinchukAV.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double f = 90;
            int result = ds.AngleToHoursMinutes(f);
            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}