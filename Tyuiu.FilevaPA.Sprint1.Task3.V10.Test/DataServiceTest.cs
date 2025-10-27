namespace Tyuiu.FilevaPA.Sprint1.Task3.V10.Test;
using Tyuiu.FilevaPA.Sprint1.Task3.V10.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidConvert30_5WithComma()
    {
        DataService ds = new DataService();

        // Тестируем с числом 30.5 (как будто ввели "30,5")
        double number = 30.5;
        string result = ds.ConvertToMoneyFormat(number);

        // Ожидаемый результат
        string expected = "30.5 руб. - это 30 руб. 50 коп.";

        Assert.AreEqual(expected, result);
    }
}
