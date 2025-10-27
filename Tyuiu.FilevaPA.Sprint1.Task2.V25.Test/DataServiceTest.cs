namespace Tyuiu.FilevaPA.Sprint1.Task2.V25.Test;
using Tyuiu.FilevaPA.Sprint1.Task2.V25.Lib;



[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        int radians = 1;
        double result = ds.ConvertRadsToDegrees(radians);
        Assert.AreEqual(57.296, result, 0.001);
    }
}
}
