using DoenaSoft.NumberSystemConverter.Chinese;

namespace DoenaSoft.NumberSystemConverter.Tests.Chinese;

[TestClass]
public sealed class FinancialSimplifiedChineseTests
{
    private readonly FinancialSimplifiedNumeralConverter _converter = new();

    [TestMethod]
    public void D0()
        => _converter.TestFromTo(0, "零");

    [TestMethod]
    public void D1()
        => _converter.TestFromTo(1, "壹");

    [TestMethod]
    public void D2()
        => _converter.TestFromTo(2, "贰");

    [TestMethod]
    public void D3()
        => _converter.TestFromTo(3, "叁");

    [TestMethod]
    public void D4()
        => _converter.TestFromTo(4, "肆");

    [TestMethod]
    public void D5()
        => _converter.TestFromTo(5, "伍");

    [TestMethod]
    public void D6()
        => _converter.TestFromTo(6, "陆");

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
        => _converter.TestFromTo(2024, "贰仟零贰拾肆");

    [TestMethod]
    public void D1_0000()
        => _converter.TestFromTo(1_0000, "壹万");

    [TestMethod]
    public void D1_0000_0000()
        => _converter.TestFromTo(1_0000_0000, "壹亿");
}