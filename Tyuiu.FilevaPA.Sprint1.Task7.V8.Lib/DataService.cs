namespace Tyuiu.FilevaPA.Sprint1.Task7.V8.Lib;
using Tyuiu.FilevaPA.Sprint1.Task7.V8.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task7V8
{
    public double Calculate(double x, double y)
    {
        // z = x * ln(x) + y / (cos(x) - x/3)
        double lnX = Math.Log(x);
        double cosX = Math.Cos(x);
        double denominator = cosX - (x / 3);

        double result = x * lnX + y / denominator;
        return Math.Round(result, 3);
    }
}
