
using Tyuiu.GurinchukAV.Sprint1.Task6.V7.Lib;
namespace Tyuiu.GurinchukAV.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteLastLetter()
        {
            DataService ds = new DataService();
            string value = "Привет мир программирование";
            string result = ds.DeleteLastLetter(value);
            string wait = "Приве ми программировани";
            Assert.AreEqual(wait, result);
        }
    }
}
