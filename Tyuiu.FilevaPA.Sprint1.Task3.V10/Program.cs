using System.Data;
using System.Globalization;
using Tyuiu.FilevaPA.Sprint1.Task3.V10.Lib;

namespace Tyuiu.FilevaPA.Sprint1.Task3.V10
    ;

internal class Program
{
    private static void Main(string[] args)

    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнила: Филева Полина Алексеевна. | ИСПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Class Math                                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна. | ИСПб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая преобразует введенное с клавиатуры         *");
        Console.WriteLine("* дробное число в денежный формат. Ответ округлите до 3 знаков           *");
        Console.WriteLine("* после запятой.                                                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.Write("Введите дробное число: ");
        string input = Console.ReadLine();

        // Обрабатываем ввод с запятой
        input = input.Replace(',', '.');
        double number;

        if (!double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out number))
        {
            Console.WriteLine("Ошибка: введено некорректное число");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string result = ds.NumberToMoney(number);
        Console.WriteLine(result);

        Console.ReadKey();
    }
}

