namespace Tyuiu.FilevaPA.Sprint1.Task0.V11.Test;
using Tyuiu.FilevaPA.Sprint1.Task0.V11.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        double wait = 7.0; // 4*5/2 - 18/2/3 = 10 - 3 = 7
        double res = ds.Calculate();
        Assert.AreEqual(wait, res);
    }
}
