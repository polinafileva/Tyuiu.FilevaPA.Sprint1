using System.Data;
using Tyuiu.FilevaPA.Sprint1.Task3.V10.Lib;

namespace Tyuiu.FilevaPA.Sprint1.Task3.V10
    ;

internal class Program
{
    private static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите дробное число:");
        string input = Console.ReadLine();

        // Заменяем запятую на точку для корректного преобразования
        input = input.Replace(',', '.');
        double number = Convert.ToDouble(input);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        // Получаем результат из DataService
        string result = ds.ConvertToMoneyFormat(number);
        Console.WriteLine(result);

        Console.ReadKey();
    }
}
