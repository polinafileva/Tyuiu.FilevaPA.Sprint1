namespace Tyuiu.FilevaPA.Sprint1.Task5.V2.Test;
using Tyuiu.FilevaPA.Sprint1.Task5.V2.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        var dataService = new DataService();
        // Дробное значение с округлением
        double fahrenheit5 = 77;
        int wait5 = 25; // 25°C (77°F = 25°C точно)
        int result5 = ds.FahrenheitToСelsius(fahrenheit5);
        Assert.AreEqual(wait5, result5);

    }
}
