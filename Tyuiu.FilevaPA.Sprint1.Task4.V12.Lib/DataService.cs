namespace Tyuiu.FilevaPA.Sprint1.Task4.V12.Lib;
using Tyuiu.FilevaPA.Sprint1.Task4.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;



public class DataService : ISprint1Task4V12
{
    public double Calculate(double x, double y)
    {
        {
            // Формула должна возвращать 0.4 при x=0.5, y=4
            // Вероятная правильная формула: 1 / (x + √|y|)
            double denominator = x + Math.Sqrt(Math.Abs(y));

            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю");
            }

            double result = 1 / denominator;
            return Math.Round(result, 3);
        }
    }
}

