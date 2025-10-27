namespace Tyuiu.FilevaPA.Sprint1.Task4.V12.Test;
using Tyuiu.FilevaPA.Sprint1.Task4.V12.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        double x = 0;
        double y = 16;
        double result = ds.Calculate(x, y);
        Assert.AreEqual(3.0, result, 0.001);
    }
}
