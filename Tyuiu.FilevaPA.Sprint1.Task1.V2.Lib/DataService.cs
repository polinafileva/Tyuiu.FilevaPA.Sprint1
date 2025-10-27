
namespace Tyuiu.FilevaPA.Sprint1.Task1.V2.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;
public class DataService : ISprint1Task1V2

{
    public double Calculate(double x, double y)
    {
        return x * y / (5 + x);
    }
}
