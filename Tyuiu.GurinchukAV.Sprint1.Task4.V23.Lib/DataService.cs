using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GurinchukAV.Sprint1.Task4.V23.Lib
{
    public class DataService : ISprint1Task4V23
    {
        public double Calculate(double x, double y)
        {
            if (Math.Abs(3 - x) < double.Epsilon)
                throw new ArgumentException("Деление на ноль невозможно - x не может быть равен 3");

            double numerator = Math.Sqrt(Math.Abs(x + y));
            double denominator = Math.Abs(3 - x);

            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}
