using DoenaSoft.NumberSystemConverter.Chinese;

namespace DoenaSoft.NumberSystemConverter.Tests.Chinese;

[TestClass]
public sealed class OrdinaryTraditionalChineseTests
{
    private readonly OrdinaryTraditionalNumeralConverter _converter = new();

    [TestMethod]
    public void D0()
        => _converter.TestFromTo(0, "零");

    [TestMethod]
    public void D1()
        => _converter.TestFromTo(1, "一");

    [TestMethod]
    public void D2()
        => _converter.TestFromTo(2, "二");

    [TestMethod]
    public void D3()
        => _converter.TestFromTo(3, "三");

    [TestMethod]
    public void D4()
        => _converter.TestFromTo(4, "四");

    [TestMethod]
    public void D5()
        => _converter.TestFromTo(5, "五");

    [TestMethod]
    public void D6()
        => _converter.TestFromTo(6, "六");

    [TestMethod]
    public void D7()
        => _converter.TestFromTo(7, "七");

    [TestMethod]
    public void D8()
        => _converter.TestFromTo(8, "八");

    [TestMethod]
    public void D9()
        => _converter.TestFromTo(9, "九");

    [TestMethod]
    public void D10()
        => _converter.TestFromTo(10, "十");

    [TestMethod]
    public void D100()
        => _converter.TestFromTo(100, "一百");

    [TestMethod]
    public void D1000()
        => _converter.TestFromTo(1000, "一千");

    [TestMethod]
    public void D2024()
        => _converter.TestFromTo(2024, "二千零二十四");

    [TestMethod]
    public void D1_0000()
        => _converter.TestFromTo(1_0000, "一萬");

    [TestMethod]
    public void D1_0000_0000()
        => _converter.TestFromTo(1_0000_0000, "一億");
}