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
        double number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

       
        Console.WriteLine("{number} руб. — это {rubels} руб. {kopecksRounded:D2} коп.");
        Console.ReadKey();
    }
}