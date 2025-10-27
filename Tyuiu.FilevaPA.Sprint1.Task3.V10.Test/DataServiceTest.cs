namespace Tyuiu.FilevaPA.Sprint1.Task3.V10.Test;
using Tyuiu.FilevaPA.Sprint1.Task3.V10.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidNumberToMoney30_5();
           
        DataService ds = new DataService();
        double number = 30.5;
        string wait = "30.5 руб. - это 30 руб. 50 коп.";
        string res = ds.NumberToMoney(number);
        Assert.AreEqual(wait, res);
    }


