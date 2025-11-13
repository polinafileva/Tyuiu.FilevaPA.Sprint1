namespace Tyuiu.FilevaPA.Sprint1.Task6.V2.Lib;
using Tyuiu.FilevaPA.Sprint1.Task6.V2.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task6V2
{
    public bool CheckHello(string value)
    {
        // Проверяем, содержит ли строка слово "Hello"
        return value.Contains("Hello");
    }
}
