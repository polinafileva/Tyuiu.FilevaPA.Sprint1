namespace Tyuiu.FilevaPA.Sprint1.Task2.V25.Lib;
using Tyuiu.FilevaPA.Sprint1.Task2.V25.Lib;

using tyuiu.cources.programming.interfaces.Sprint1;
public class DataService : ISprint1Task2V25

{
    public double ConvertRadsToDegrees(int value)
    {
        // Формула перевода радиан в градусы: градусы = радианы * (180 / π)
        double degrees = value * (180.0 / Math.PI);

        // Округляем до 3 знаков после запятой
        return Math.Round(degrees, 3);
    }
}
