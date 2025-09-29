using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GurinchukAV.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double n1 = Math.Pow(Math.Cos(x), 2) + Math.Pow(Math.Sin(y), 2);
            double d1 = Math.Sin(y) + 1;

            double n2 = x * y - 12;
            double d2 = 15 + Math.Cos(x);

            double res = Math.Round(((n1 / d1) - (n2 / d2)), 3);
            return res;
        }
    }
}
