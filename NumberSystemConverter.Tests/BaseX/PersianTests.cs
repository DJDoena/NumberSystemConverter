using DoenaSoft.NumberSystemConverter.BaseX;

namespace DoenaSoft.NumberSystemConverter.Tests.BaseX;

[TestClass]
public sealed class PersianTests
{
    private readonly PersianDecimalConverter _converter = new();

    [TestMethod]
    public void Base()
    {
        Assert.AreEqual(10U, _converter.Base);
    }

    [TestMethod]
    public void D0()
        => _converter.TestFromTo(0, "۰");

    [TestMethod]
    public void D1()
        => _converter.TestFromTo(1, "۱");

    [TestMethod]
    public void D2()
        => _converter.TestFromTo(2, "۲");

    [TestMethod]
    public void D3()
        => _converter.TestFromTo(3, "۳");

    [TestMethod]
    public void D4()
        => _converter.TestFromTo(4, "۴");

    [TestMethod]
    public void D5()
        => _converter.TestFromTo(5, "۵");

    [TestMethod]
    public void D6()
        => _converter.TestFromTo(6, "۶");

    [TestMethod]
    public void D7()
        => _converter.TestFromTo(7, "۷");

    [TestMethod]
    public void D8()
        => _converter.TestFromTo(8, "۸");

    [TestMethod]
    public void D9()
        => _converter.TestFromTo(9, "۹");

    [TestMethod]
    public void D2024()
        => _converter.TestFromTo(2024, "۲۰۲۴");
}