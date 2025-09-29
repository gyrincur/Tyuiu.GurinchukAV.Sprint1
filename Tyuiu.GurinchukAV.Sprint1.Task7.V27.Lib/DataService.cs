using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GurinchukAV.Sprint1.Task7.V27.Lib
{
    public class DataService: ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(((Math.Cos(x * x) + Math.Sin(y * y)) / (Math.Sin(y) + 1.0)) - ((x * y) - 12.0) / (15.0 + Math.Cos(x)), 3);
        }
    }
}