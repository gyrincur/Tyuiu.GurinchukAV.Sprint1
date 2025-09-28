using Tyuiu.GurinchukAV.Sprint1.Task3.V2.Lib;
namespace Tyuiu.GurinchukAV.Sprint1.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidPurchaseAmount()
        {
            DataService ds = new DataService();
            double priceNotebook = 25.5;
            int amountNotebook = 3;
            double pricePencil = 15.75;
            int amountPencil = 5;

            double result = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            double wait = 155.25;

            Assert.AreEqual(wait, result);
        }
        }
    }
