using DoenaSoft.NumberSystemConverter.BaseX;

namespace DoenaSoft.NumberSystemConverter.Tests.BaseX;

[TestClass]
public sealed class EasternArabicTests
{
    private readonly EasternArabicDecimalConverter _converter = new();

    [TestMethod]
    public void Base()
    {
        Assert.AreEqual(10U, _converter.Base);
    }

    [TestMethod]
    public void D0()
        => _converter.TestFromTo(0, "٠");

    [TestMethod]
    public void D1()
        => _converter.TestFromTo(1, "١");

    [TestMethod]
    public void D2()
        => _converter.TestFromTo(2, "٢");

    [TestMethod]
    public void D3()
        => _converter.TestFromTo(3, "٣");

    [TestMethod]
    public void D4()
        => _converter.TestFromTo(4, "٤");

    [TestMethod]
    public void D5()
        => _converter.TestFromTo(5, "٥");

    [TestMethod]
    public void D6()
        => _converter.TestFromTo(6, "٦");

    [TestMethod]
    public void D7()
        => _converter.TestFromTo(7, "٧");

    [TestMethod]
    public void D8()
        => _converter.TestFromTo(8, "٨");

    [TestMethod]
    public void D9()
        => _converter.TestFromTo(9, "٩");

    [TestMethod]
    public void D2024()
        => _converter.TestFromTo(2024, "٢٠٢٤");
}