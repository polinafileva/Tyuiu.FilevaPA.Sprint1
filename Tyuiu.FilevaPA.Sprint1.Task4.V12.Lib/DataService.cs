namespace Tyuiu.FilevaPA.Sprint1.Task4.V12.Lib;
using Tyuiu.FilevaPA.Sprint1.Task4.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;



public class DataService : ISprint1Task4V12
{
    public double Calculate(double x, double y)
    {
        // Формула: (5 + √|y|) / (e^x + 2)
        double numerator = 5 + Math.Sqrt(Math.Abs(y));
        double denominator = Math.Exp(x) + 2;

        if (denominator == 0)
        {
            throw new ArgumentException("Знаменатель не может быть равен нулю");
        }

        double result = numerator / denominator;
        return Math.Round(result, 3);
    }
}

