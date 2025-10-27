namespace Tyuiu.FilevaPA.Sprint1.Task4.V12.Test;
using Tyuiu.FilevaPA.Sprint1.Task4.V12.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCalculateTest1()
    {
        DataService ds = new DataService();
        double x = 0.5;
        double y = 4;
        double result = ds.Calculate(x, y);
        Assert.AreEqual(0.4, result, 0.001);
    }
}
