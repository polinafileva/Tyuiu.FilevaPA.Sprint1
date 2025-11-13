namespace Tyuiu.FilevaPA.Sprint1.Task7.V8.Test;
using Tyuiu.FilevaPA.Sprint1.Task7.V8.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();

        // Тест 1: x = 1, y = 2
        double x1 = 1;
        double y1 = 2;
        double wait1 = 2.651; // Ожидаемый результат
        double result1 = ds.Calculate(x1, y1);
        Assert.AreEqual(wait1, result1, 0.001);

        // Тест 2: x = 2, y = 3
        double x2 = 2;
        double y2 = 3;
        double wait2 = 5.388; // Ожидаемый результат
        double result2 = ds.Calculate(x2, y2);
        Assert.AreEqual(wait2, result2, 0.001);

        // Тест 3: x = 0.5, y = 1
        double x3 = 0.5;
        double y3 = 1;
        double wait3 = -0.847; // Ожидаемый результат
        double result3 = ds.Calculate(x3, y3);
        Assert.AreEqual(wait3, result3, 0.001);
    }
}
