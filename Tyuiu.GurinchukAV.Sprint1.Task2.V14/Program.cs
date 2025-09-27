using Tyuiu.GurinchukAV.Sprint1.Task2.V14.Lib;

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
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Гуринчук Анастасия Витальевна | ИБКСб-25-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя температуру в    *");
            Console.WriteLine("* градусах Кельвина и переводит ее в градусы цедьсия.                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Введите температуру в градусах Кельвина:                                 *");
            int kelvin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int celsius = ds.ConvertKelvinToCelsius(kelvin);

            Console.WriteLine($"Температура {kelvin}K = {celsius}°C");


            Console.ReadLine();
        }
    }
}