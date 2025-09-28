using Tyuiu.GurinchukAV.Sprint1.Task4.V23.Lib;
namespace Tyuiu.GurinchukAV.Sprint1.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 0.707;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        }
    }
