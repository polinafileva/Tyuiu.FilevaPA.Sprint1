namespace Tyuiu.FilevaPA.Sprint1.Task6.V2.Test;
using Tyuiu.FilevaPA.Sprint1.Task6.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Проверка наличия слова в строке                                  *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #2                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая проверяет, есть ли в строке слово Hello.   *");
        Console.WriteLine("* Программа должна возвращать true, если слово найдено, и false - если   *");
        Console.WriteLine("* слово не найдено.                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        Console.Write("Введите текст: ");
        string inputText = Console.ReadLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool result = ds.CheckHello(inputText);
        Console.WriteLine($"Содержится ли в тексте слово 'Hello': {result}");

        Console.ReadKey();
    }
}