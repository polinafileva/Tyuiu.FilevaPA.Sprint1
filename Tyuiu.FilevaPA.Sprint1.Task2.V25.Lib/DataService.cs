namespace Tyuiu.FilevaPA.Sprint1.Task2.V25.Lib;
using Tyuiu.FilevaPA.Sprint1.Task2.V25.Lib;

using tyuiu.cources.programming.interfaces.Sprint1;
public class DataService : ISprint1Task2V25

{
    public double ConvertRadsToDegrees(int value)
    {
        return Math.Round(value * (180.0 / Math.PI), 3);
    }
}
