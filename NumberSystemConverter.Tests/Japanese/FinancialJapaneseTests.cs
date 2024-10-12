using DoenaSoft.NumberSystemConverter.Japanese;

namespace DoenaSoft.NumberSystemConverter.Tests.Japanese;

[TestClass]
public sealed class FinancialJapaneseTests
{
    private readonly FinancialNumeralConverter _converter = new();

    [TestMethod]
    public void D0()
        => _converter.TestFromTo(0, "零");

    [TestMethod]
    public void D1()
        => _converter.TestFromTo(1, "壱");

    [TestMethod]
    public void D2()
        => _converter.TestFromTo(2, "弐");

    [TestMethod]
    public void D3()
        => _converter.TestFromTo(3, "参");

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
        => _converter.TestFromTo(10, "拾");

    [TestMethod]
    public void D11()
        => _converter.TestFromTo(11, "拾壱");

    [TestMethod]
    public void D12()
        => _converter.TestFromTo(12, "拾弐");

    [TestMethod]
    public void D19()
         => _converter.TestFromTo(19, "拾九");

    [TestMethod]
    public void D17()
        => _converter.TestFromTo(17, "拾七");

    [TestMethod]
    public void D20()
        => _converter.TestFromTo(20, "弐拾");

    [TestMethod]
    public void D100()
        => _converter.TestFromTo(100, "百");

    [TestMethod]
    public void D101()
        => _converter.TestFromTo(101, "百壱");

    [TestMethod]
    public void D110()
        => _converter.TestFromTo(110, "百拾");

    [TestMethod]
    public void D151()
        => _converter.TestFromTo(151, "百五拾壱");

    [TestMethod]
    public void D302()
        => _converter.TestFromTo(302, "参百弐");

    [TestMethod]
    public void D469()
        => _converter.TestFromTo(469, "四百六拾九");

    [TestMethod]
    public void D2024()
        => _converter.TestFromTo(2024, "弐千弐拾四");

    [TestMethod]
    public void D2025()
        => _converter.TestFromTo(2025, "弐千弐拾五");

    [TestMethod]
    public void D1_0000()
        => _converter.TestFromTo(1_0000, "壱万");

    [TestMethod]
    public void D1_0000_alternate()
         => _converter.TestTo("壱萬", 1_0000);

    [TestMethod]
    public void D9_0000()
         => _converter.TestFromTo(9_0000, "九万");

    [TestMethod]
    public void D9_0000_alternate()
         => _converter.TestTo("九萬", 9_0000);

    [TestMethod]
    public void D10_0000()
         => _converter.TestFromTo(10_0000, "拾万");

    [TestMethod]
    public void D10_0000_alternate()
         => _converter.TestTo("拾萬", 10_0000);

    [TestMethod]
    public void D983_6703()
        => _converter.TestFromTo(983_6703, "九百八拾参万六千七百参");

    [TestMethod]
    public void D1000()
        => _converter.TestFromTo(1000, "千");

    [TestMethod]
    public void D1_0000_0000()
        => _converter.TestFromTo(1_0000_0000, "壱億");

    [TestMethod]
    public void D1_0000_0000_0000()
        => _converter.TestFromTo(1_0000_0000_0000, "壱兆");

    [TestMethod]
    public void D1_0000_0000_0001()
        => _converter.TestFromTo(1_0000_0000_0001, "壱兆壱");

    [TestMethod]
    public void D1_0000_0000_0000_0000()
        => _converter.TestFromTo(1_0000_0000_0000_0000, "壱京");

    [TestMethod]
    public void D1_0000_0000_0000_0001()
        => _converter.TestFromTo(1_0000_0000_0000_0001, "壱京壱");

    [TestMethod]
    public void D1_0001_0001_0001_0001()
        => _converter.TestFromTo(1_0001_0001_0001_0001, "壱京壱兆壱億壱万壱");

    [TestMethod]
    public void D1844_6744_0737_0955_1614()
        => _converter.TestFromTo(1844_6744_0737_0955_1614, "千八百四拾四京六千七百四拾四兆七百参拾七億九百五拾五万千六百拾四");

    [TestMethod]
    public void D1844_6744_0737_0955_1615()
         => _converter.TestFromTo(1844_6744_0737_0955_1615, "千八百四拾四京六千七百四拾四兆七百参拾七億九百五拾五万千六百拾五");

    [TestMethod]
    [ExpectedException(typeof(OverflowException))]
    public void D1844_6744_0737_0955_1616()
         => _ = _converter.ToULong("千八百四拾四京六千七百四拾四兆七百参拾七億九百五拾五万千六百拾六");
}