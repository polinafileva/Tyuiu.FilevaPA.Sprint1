using Tyuiu.FilevaPA.Sprint1.Task2.V25.Lib;

namespace Tyuiu.FilevaPA.Sprint1.Task2.V25;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Филева Полина Алексеевна | ИСПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Class Math                                                        *");
        Console.WriteLine("* Задание #2                                                             *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Аексеевна | ИСПб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Известен угол в радианах. Перевести угол в градусы.                    *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите угол в радианах (целое число): ");
        string input = Console.ReadLine();

        int radians;
        if (!int.TryParse(input, out radians))
        {
            Console.WriteLine("Ошибка: введено некорректное целое число");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double degrees = ds.ConvertRadsToDegrees(radians);
        Console.WriteLine("Угол в градусах: " + degrees.ToString("F3"));

        Console.ReadKey();
    }
}

