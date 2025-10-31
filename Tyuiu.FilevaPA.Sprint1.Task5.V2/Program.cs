namespace Tyuiu.FilevaPA.Sprint1.Task5.V2.Lib;
using Tyuiu.FilevaPA.Sprint1.Task5.V2.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование температуры из Фаренгейта в Цельсий               *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано значение температуры в градусах Фаренгейта. Определить значение    *");
        Console.WriteLine("* этой же температуры в градусах Цельсия. Ответ привести к целому с      *");
        Console.WriteLine("* помощью класса Convert.                                                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        Console.Write("Введите температуру в градусах Фаренгейта: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.FahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"Температура в градусах Цельсия: {result}°C");

        Console.ReadKey();
    }
}