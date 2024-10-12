using DoenaSoft.NumberSystemConverter.BaseX;

namespace DoenaSoft.NumberSystemConverter.Tests.BaseX;

[TestClass]
public sealed class BrailleTests
{
    private readonly BrailleDecimalConverter _converter = new();

    [TestMethod]
    public void Base()
    {
        Assert.AreEqual(10U, _converter.Base);
    }

    [TestMethod]
    public void D0()
        => _converter.TestFromTo(0, "⠚");

    [TestMethod]
    public void D1()
        => _converter.TestFromTo(1, "⠁");

    [TestMethod]
    public void D2()
        => _converter.TestFromTo(2, "⠃");

    [TestMethod]
    public void D3()
        => _converter.TestFromTo(3, "⠉");

    [TestMethod]
    public void D4()
        => _converter.TestFromTo(4, "⠙");

    [TestMethod]
    public void D5()
        => _converter.TestFromTo(5, "⠑");

    [TestMethod]
    public void D6()
        => _converter.TestFromTo(6, "⠋");

    [TestMethod]
    public void D7()
        => _converter.TestFromTo(7, "⠛");

    [TestMethod]
    public void D8()
        => _converter.TestFromTo(8, "⠓");

    [TestMethod]
    public void D9()
        => _converter.TestFromTo(9, "⠊");

    [TestMethod]
    public void D2024()
        => _converter.TestFromTo(2024, "⠃⠚⠃⠙");

    [TestMethod]
    public void BrailleToDec()
    {
        var stringResult = _converter.Convert("⠁⠋", new DecimalConverter());

        Assert.AreEqual("16", stringResult);
    }
}