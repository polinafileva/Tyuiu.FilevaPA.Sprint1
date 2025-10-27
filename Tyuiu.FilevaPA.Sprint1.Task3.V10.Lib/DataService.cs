namespace Tyuiu.FilevaPA.Sprint1.Task3.V10.Lib;

using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.FilevaPA.Sprint1.Task3.V10.Lib;


public class DataService : ISprint1Task3V10
{

    public string NumberToMoney(double number)
    {
        // Округляем до 3 знаков после запятой для расчетов
        double roundedNumber = Math.Round(number, 3);

        // Получаем рубли (целая часть)
        int rubles = (int)roundedNumber;

        // Получаем копейки (дробная часть * 100)
        double fractionalPart = roundedNumber - rubles;
        int kopecks = (int)Math.Round(fractionalPart * 100);

        // Обрабатываем случай, когда копейки >= 100
        if (kopecks >= 100)
        {
            rubles += 1;
            kopecks = 0;
        }

        // Форматируем результат ТОЧНО как в ожидании
        string formattedNumber = number.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture);
        string result = formattedNumber + " руб. - это " + rubles + " руб. " + kopecks.ToString("00") + " коп.";

        return result;
    }
}
