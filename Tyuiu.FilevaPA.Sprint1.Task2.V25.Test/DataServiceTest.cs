namespace Tyuiu.FilevaPA.Sprint1.Task2.V25.Test;
using Tyuiu.FilevaPA.Sprint1.Task2.V25.Lib;



[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        int radians = 2; // приблизительно π/2 радиан
        double wait = 114.592;
        double res = ds.ConvertRadsToDegrees(radians);
        Assert.AreEqual(wait, res);
    }
}
