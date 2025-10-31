namespace Tyuiu.FilevaPA.Sprint1.Task5.V2.Test;
using Tyuiu.FilevaPA.Sprint1.Task5.V2.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        var dataService = new DataService();
        // Дробное значение
        double fahrenheit5 = 77;
        int wait5 = 25;
        int result5 = ds.FahrenheitToCelsius(fahrenheit5);
        Assert.AreEqual(wait5, result5);
    
}
}
