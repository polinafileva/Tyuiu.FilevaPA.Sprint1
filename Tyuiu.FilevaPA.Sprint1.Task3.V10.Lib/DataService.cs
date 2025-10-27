namespace Tyuiu.FilevaPA.Sprint1.Task3.V10.Lib;
using Tyuiu.FilevaPA.Sprint1.Task3.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;


public class DataService 
{

    public string ConvertToMoneyFormat(double number)
    {
        // Округляем до 3 знаков после запятой
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

        // Форматируем результат согласно ожидаемому формату
        // Используем F1 для number чтобы было "30.5" а не "30.500"
        return $"{number:F1} руб. - это {rubles} руб. {kopecks:D2} коп.";
    }
}
