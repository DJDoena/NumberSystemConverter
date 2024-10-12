using DoenaSoft.NumberSystemConverter.Japanese;

namespace DoenaSoft.NumberSystemConverter.Tests.Japanese;

[TestClass]
public sealed class CommonJapaneseTests
{
    private readonly CommonNumeralConverter _converter = new();

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
    public void D19()
         => _converter.TestFromTo(19, "十九");

    [TestMethod]
    public void D17()
        => _converter.TestFromTo(17, "十七");

    [TestMethod]
    public void D20()
        => _converter.TestFromTo(20, "二十");

    [TestMethod]
    public void D100()
        => _converter.TestFromTo(100, "百");

    [TestMethod]
    public void D101()
        => _converter.TestFromTo(101, "百一");

    [TestMethod]
    public void D110()
        => _converter.TestFromTo(110, "百十");

    [TestMethod]
    public void D151()
        => _converter.TestFromTo(151, "百五十一");

    [TestMethod]
    public void D302()
        => _converter.TestFromTo(302, "三百二");

    [TestMethod]
    public void D469()
        => _converter.TestFromTo(469, "四百六十九");

    [TestMethod]
    public void D2024()
        => _converter.TestFromTo(2024, "二千二十四");

    [TestMethod]
    public void D2025()
        => _converter.TestFromTo(2025, "二千二十五");

    [TestMethod]
    public void D1_0000()
        => _converter.TestFromTo(1_0000, "一万");

    [TestMethod]
    public void D983_6703()
        => _converter.TestFromTo(983_6703, "九百八十三万六千七百三");

    [TestMethod]
    public void D1000()
        => _converter.TestFromTo(1000, "千");

    [TestMethod]
    public void D1_0000_0000()
        => _converter.TestFromTo(1_0000_0000, "一億");

    [TestMethod]
    public void D1_0000_0000_0000()
        => _converter.TestFromTo(1_0000_0000_0000, "一兆");

    [TestMethod]
    public void D1_0000_0000_0001()
        => _converter.TestFromTo(1_0000_0000_0001, "一兆一");

    [TestMethod]
    public void D1_0000_0000_0000_0000()
        => _converter.TestFromTo(1_0000_0000_0000_0000, "一京");

    [TestMethod]
    public void D1_0000_0000_0000_0001()
        => _converter.TestFromTo(1_0000_0000_0000_0001, "一京一");

    [TestMethod]
    public void D1_0001_0001_0001_0001()
        => _converter.TestFromTo(1_0001_0001_0001_0001, "一京一兆一億一万一");

    [TestMethod]
    public void D1844_6744_0737_0955_1614()
        => _converter.TestFromTo(1844_6744_0737_0955_1614, "千八百四十四京六千七百四十四兆七百三十七億九百五十五万千六百十四");

    [TestMethod]
    public void D1844_6744_0737_0955_1615()
         => _converter.TestFromTo(1844_6744_0737_0955_1615, "千八百四十四京六千七百四十四兆七百三十七億九百五十五万千六百十五");

    [TestMethod]
    [ExpectedException(typeof(OverflowException))]
    public void D1844_6744_0737_0955_1616()
         => _ = _converter.ToULong("千八百四十四京六千七百四十四兆七百三十七億九百五十五万千六百十六");
}