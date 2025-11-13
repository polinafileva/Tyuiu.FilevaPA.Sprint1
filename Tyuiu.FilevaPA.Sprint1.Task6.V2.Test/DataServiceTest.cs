namespace Tyuiu.FilevaPA.Sprint1.Task6.V2.Test;
using Tyuiu.FilevaPA.Sprint1.Task6.V2.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {

        DataService ds = new DataService();

        // Тест 1: Строка содержит "Hello"
        string text1 = "Hello world!";
        bool wait1 = true;
        bool result1 = ds.CheckHello(text1);
        Assert.AreEqual(wait1, result1);

        // Тест 2: Строка не содержит "Hello"
        string text2 = "Good morning!";
        bool wait2 = false;
        bool result2 = ds.CheckHello(text2);
        Assert.AreEqual(wait2, result2);

        // Тест 3: Слово "Hello" в середине текста
        string text3 = "I say Hello to everyone";
        bool wait3 = true;
        bool result3 = ds.CheckHello(text3);
        Assert.AreEqual(wait3, result3);

        // Тест 4: Пустая строка
        string text4 = "";
        bool wait4 = false;
        bool result4 = ds.CheckHello(text4);
        Assert.AreEqual(wait4, result4);
    }
}
