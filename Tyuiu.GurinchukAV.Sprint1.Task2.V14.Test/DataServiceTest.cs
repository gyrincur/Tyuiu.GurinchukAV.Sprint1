using System.Runtime.CompilerServices;
using Tyuiu.GurinchukAV.Sprint1.Task2.V14.Lib;
namespace Tyuiu.GurinchukAV.Sprint1.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        
        public void ValidConvertKelvinToCelsius()
        {
            DataService ds = new DataService();
            int value = 300;
            int x = 27;
            int result = ds.ConvertKelvinToCelsius(value);
            Assert.Equals(x, result);
        }
    }
}
