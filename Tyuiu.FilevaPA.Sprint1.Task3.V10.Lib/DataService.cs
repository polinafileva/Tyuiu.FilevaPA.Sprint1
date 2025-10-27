namespace Tyuiu.FilevaPA.Sprint1.Task3.V10.Lib;
using Tyuiu.FilevaPA.Sprint1.Task3.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;


public class DataService : ISprint1Task3V10
{

    public string NumberToMoney(double number)
    {
        // Округляем до 3 знаков
        double rounded = Math.Round(number, 3);

        // Получаем рубли и копейки
        int rubles = (int)rounded;
        int kopecks = (int)Math.Round((rounded - rubles) * 100);

        return "{rubles} руб. {kopecks:D2} коп.";
    }
}
