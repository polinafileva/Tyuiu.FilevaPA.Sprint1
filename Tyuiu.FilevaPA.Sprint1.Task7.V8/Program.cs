namespace Tyuiu.FilevaPA.Sprint1.Task7.V8.Test;
using Tyuiu.FilevaPA.Sprint1.Task7.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по      *");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до  *");
        Console.WriteLine("* 3 знаков после запятой.                                                *");
        Console.WriteLine("* Формула: z = x * ln(x) + y / (cos(x) - x/3)                            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        Console.Write("Введите значение X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.Calculate(x, y);
        Console.WriteLine($"z = {result}");

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ПРОВЕРКА:                                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"При x = {x}, y = {y}:");
        Console.WriteLine($"x * ln(x) = {x * Math.Log(x):F3}");
        Console.WriteLine($"cos(x) = {Math.Cos(x):F3}");
        Console.WriteLine($"cos(x) - x/3 = {Math.Cos(x) - x / 3:F3}");
        Console.WriteLine($"y / (cos(x) - x/3) = {y / (Math.Cos(x) - x / 3):F3}");
        Console.WriteLine($"Результат: {result}");

        Console.ReadKey();
    }
}