using DoenaSoft.NumberSystemConverter.Korean;

namespace DoenaSoft.NumberSystemConverter.Tests.Korean;

[TestClass]
public sealed class FinancialKoreanTests
{
    private readonly FinancialKoreanNumeralConverter _converter = new();

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
    public void D11()
        => _converter.TestFromTo(11, "拾壹");

    [TestMethod]
    public void D12()
        => _converter.TestFromTo(12, "拾貳");

    [TestMethod]
    public void D20()
        => _converter.TestFromTo(20, "貳拾");

    [TestMethod]
    public void D21()
        => _converter.TestFromTo(21, "貳拾壹");

    [TestMethod]
    public void D100()
        => _converter.TestFromTo(100, "佰");

    [TestMethod]
    public void D101()
        => _converter.TestFromTo(101, "佰壹");

    [TestMethod]
    public void D1000()
        => _converter.TestFromTo(1000, "仟");

    [TestMethod]
    public void D2024()
        => _converter.TestFromTo(2024, "貳仟貳拾肆");

    [TestMethod]
    public void D10000()
        => _converter.TestFromTo(10000, "壹만");

    [TestMethod]
    public void D20026()
        => _converter.TestFromTo(20026, "貳만貳拾陸");

    [TestMethod]
    public void D200026()
        => _converter.TestFromTo(200026, "貳拾만貳拾陸");

    [TestMethod]
    public void D2000026()
        => _converter.TestFromTo(2000026, "貳佰만貳拾陸");
}
