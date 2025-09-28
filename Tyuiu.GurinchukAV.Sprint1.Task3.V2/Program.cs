using Tyuiu.GurinchukAV.Sprint1.Task3.V2.Lib;
namespace Tyuiu.GurinchukAV.Sprint1.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила : Гуринчук А. В. | ИБКСб-25-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Гуринчук Анастасия Витальевна | ИБКСб-25-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет расчет стоимости покупки из тетрадей и карандашей и печатает  *");
            Console.WriteLine("* результат на экране. Ответ округлить до 3 знаков после запятой.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите данные о тетрадях:");
            Console.Write("Цена за одну тетрадь: ");
            double priceNotebook = Convert.ToDouble(Console.ReadLine());

            Console.Write("Количество тетрадей: ");
            int amountNotebook = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите данные о карандашах:");
            Console.Write("Цена за один карандаш: ");
            double pricePencil = Convert.ToDouble(Console.ReadLine());

            Console.Write("Количество карандашей: ");
            int amountPencil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double totalCost = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);

            Console.WriteLine($"Общая стоимость покупки: {totalCost:F3} руб.");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}