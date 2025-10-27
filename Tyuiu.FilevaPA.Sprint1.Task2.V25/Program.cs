using Tyuiu.FilevaPA.Sprint1.Task2.V25.Lib;

namespace Tyuiu.FilevaPA.Sprint1.Task2.V25;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

                                              
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int angleRadians;

        Console.WriteLine("Введите угол в радианах (целое число):");
        angleRadians = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Угол в градусах = " + ds.ConvertRadsToDegrees(angleRadians));
        Console.ReadKey();

    }
}
