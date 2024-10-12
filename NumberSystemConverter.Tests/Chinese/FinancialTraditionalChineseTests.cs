using DoenaSoft.NumberSystemConverter.Chinese;

namespace DoenaSoft.NumberSystemConverter.Tests.Chinese;

[TestClass]
public sealed class FinancialTraditionalChineseTests
{
    private readonly FinancialTraditionalNumeralConverter _converter = new();

    [TestMethod]
    public void D0()
        => _converter.TestFromTo(0, "零");

    [TestMethod]
    public void D1()
        => _converter.TestFromTo(1, "壹");

    [TestMethod]
    public void D2()
        => _converter.TestFromTo(2, "貳");

    [TestMethod]
    public void D3()
        => _converter.TestFromTo(3, "參");

    [TestMethod]
    public void D4()
        => _converter.TestFromTo(4, "肆");

    [TestMethod]
    public void D5()
        => _converter.TestFromTo(5, "伍");

    [TestMethod]
    public void D6()
        => _converter.TestFromTo(6, "陸");

    [TestMethod]
    public void D7()
        => _converter.TestFromTo(7, "柒");

    [TestMethod]
    public void D8()
        => _converter.TestFromTo(8, "捌");

    [TestMethod]
    public void D9()
        => _converter.TestFromTo(9, "玖");

    [TestMethod]
    public void D10()
        => _converter.TestFromTo(10, "拾");

    [TestMethod]
    public void D100()
        => _converter.TestFromTo(100, "壹佰");

    [TestMethod]
    public void D1000()
        => _converter.TestFromTo(1000, "壹仟");

    [TestMethod]
    public void D2024()
        => _converter.TestFromTo(2024, "貳仟零貳拾肆");

    [TestMethod]
    public void D1_0000()
        => _converter.TestFromTo(1_0000, "壹萬");

    [TestMethod]
    public void D1_0000_0000()
        => _converter.TestFromTo(1_0000_0000, "壹億");
}