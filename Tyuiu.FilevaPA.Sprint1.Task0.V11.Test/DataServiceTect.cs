using Tyuiu.FilevaPA.Sprint1.Task0.V11.Lib;
namespace Tyuiu.FilevaPA.Sprint1.Task0.V11.Test;

[TestClass]
public sealed class DataServiceTect
{
    [TestMethod]
    public void ValidExpression()

    {
        DataServiceTect ds = new DataService();
        var res = ds.Calculate();
        Assert.AreEqual(7, res);

    }
}
