using Tyuiu.GurinchukAV.Sprint1.Task5.V7.Lib;
namespace Tyuiu.GurinchukAV.Sprint1.Task5.V7
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
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Гуринчук Анастасия Витальевна | ИБКСб-25-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить h – полное количество часов, прошедших от начала суток       *");
            Console.WriteLine("* до момента (в первой половине дня), когда часовая стрелка               *");
            Console.WriteLine("* повернулась на f градусов (0 < f < 360, f – вещественное число).        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите угол f в градусах: ");
            double f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int hours = ds.AngleToHoursMinutes(f);
            Console.WriteLine($"Полное количество часов: {hours}");

            Console.ReadKey();
        }
    }
}