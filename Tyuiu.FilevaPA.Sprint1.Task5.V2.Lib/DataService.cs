namespace Tyuiu.FilevaPA.Sprint1.Task5.V2.Lib;
using Tyuiu.FilevaPA.Sprint1.Task5.V2.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task5V2
{
    public int FahrenheitToCelsius(double temp)
    {
        double celsius = (temp - 32) * 5 / 9;
        return Convert.ToInt32(celsius);
    }

    public int FahrenheitToСelsius(double temp)
    {
        double celsius = (temp - 32) * 5 / 9;
        return Convert.ToInt32(celsius);
    }
}

