using Tyuiu.FilevaPA.Sprint1.Task1.V2.Lib;

namespace Tyuiu.FilevaPA.Sprint1.Task1.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Филева Полина Алексеевна | ИСПБ-25-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Организация ввода вывода в консольных приложениях                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("*Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 4*5/2-18/2/3           *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 4;
            double y = 5;

            Console.WriteLine("Первое число (x) = " + x);
            Console.WriteLine("Второе число (y) = " + y);
            Console.WriteLine("Выражение: x * y / 2 - 18 / 2 / 3");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, y);
            Console.WriteLine("Результат: " + result);

            Console.ReadKey();
        }
    }
}