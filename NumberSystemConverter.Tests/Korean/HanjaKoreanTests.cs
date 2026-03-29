using DoenaSoft.NumberSystemConverter.Korean;

namespace DoenaSoft.NumberSystemConverter.Tests.Korean;

[TestClass]
public sealed class HanjaKoreanTests
{
    private readonly KoreanHanjaNumeralConverter _converter = new();

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
    public void D11()
        => _converter.TestFromTo(11, "十一");

    [TestMethod]
    public void D12()
        => _converter.TestFromTo(12, "十二");

    [TestMethod]
    public void D20()
        => _converter.TestFromTo(20, "二十");

    [TestMethod]
    public void D21()
        => _converter.TestFromTo(21, "二十一");

    [TestMethod]
    public void D100()
        => _converter.TestFromTo(100, "百");

    [TestMethod]
    public void D101()
        => _converter.TestFromTo(101, "百一");

    [TestMethod]
    public void D1000()
        => _converter.TestFromTo(1000, "千");

    [TestMethod]
    public void D2024()
        => _converter.TestFromTo(2024, "二千二十四");

    [TestMethod]
    public void D10000()
        => _converter.TestFromTo(10000, "一만");

    [TestMethod]
    public void D20026()
        => _converter.TestFromTo(20026, "二만二十六");

    [TestMethod]
    public void D200026()
        => _converter.TestFromTo(200026, "二十만二十六");

    [TestMethod]
    public void D2000026()
        => _converter.TestFromTo(2000026, "二百만二十六");
}
