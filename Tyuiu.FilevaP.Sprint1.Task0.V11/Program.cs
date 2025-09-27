using Tyuiu.FilevaPA.Sprint1.Task0.V11.Lib;
//ЗАДАНИЕ
//Написать программу, которая вычисляет выражение 4*5/2-18/2/3 и печатает результат на экране.

namespace Tyuiu.FilevaPA.Sprint1.Task0.V11;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Филева П.А. | ИСПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение 4*5/2-18/2/3          *");
        Console.WriteLine("* и печатает результат на экране.                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* 4*5/2-18/2/3                                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        //Метод Calculate находится в библиотеке Tyuiu.FilevaPA.Sprint1.Task0.V11.Lib
        //в классе DataService
        

        Console.WriteLine(ds.Calculate());
        Console.ReadLine();
    }
}
