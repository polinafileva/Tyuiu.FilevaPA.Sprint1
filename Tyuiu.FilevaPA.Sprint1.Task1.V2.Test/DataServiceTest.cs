using Tyuiu.FilevaPA.Sprint1.Task1.V2.Lib;
namespace Tyuiu.FilevaPA.Sprint1.Task1.V2.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        double x = 1.;
        double y = 2.0;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(1.0 / 3.0, res);

    }
}
