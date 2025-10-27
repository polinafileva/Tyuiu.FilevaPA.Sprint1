namespace Tyuiu.FilevaPA.Sprint1.Task3.V10.Test;
using Tyuiu.FilevaPA.Sprint1.Task3.V10.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidNumberToMoney()
    {
        DataService ds = new DataService();
        double number = 23.6;
        string res = ds.NumberToMoney(number);
        Assert.AreEqual("23 руб. 60 коп.", res);
    }
}
