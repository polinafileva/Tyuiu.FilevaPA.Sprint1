
namespace Tyuiu.FilevaPA.Sprint1.Task1.V2.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;
public class DataService : ISprint1Task1V2
{
    public double Calculate(double x, double y)
    {
        // Вычисляем выражение с использованием параметров x и y
        // Исходное выражение: 4*5/2-18/2/3
        // Заменяем константы на параметры: x*y/2-18/2/3
        double result = x * y / 2.0 - 18 / 2.0 / 3;
        return result;
    }
}

