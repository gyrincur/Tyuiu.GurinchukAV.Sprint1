using Tyuiu.GurinchukAV.Sprint1.Task7.V27.Lib;

namespace Tyuiu.GurinchukAV.Sprint1.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Гуринчук А.В. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКСб-25-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до   *");
            Console.WriteLine("* 3 знаков после запятой.                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("    CosX^2 + SinY^2       XY - 12");
            Console.WriteLine("Z = ---------------  -  -----------");
            Console.WriteLine("        SinY + 1         15 + CosX");


            double x, y;
            Console.WriteLine("Введите X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("    CosX^2 + SinY^2       XY - 12");
            Console.WriteLine($"Z = ---------------  -  -----------  = {ds.Calculate(x, y)}");
            Console.WriteLine("        SinY + 1         15 + CosX");
            Console.ReadKey();
        }
    }
}
