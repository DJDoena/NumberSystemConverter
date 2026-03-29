using DoenaSoft.NumberSystemConverter.Roman;

namespace DoenaSoft.NumberSystemConverter.Tests.Roman;

[TestClass]
public sealed class RomanTests
{
    private readonly RomanNumeralConverter _converter;

    public RomanTests()
    {
        _converter = new();
    }

    [TestMethod]
    public void FromUIntZero()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.FromULong(0));

    [TestMethod]
    public void ToUIntEmpty()
        => Assert.ThrowsExactly<ArgumentNullException>(() => _ = _converter.ToULong(""));

    [TestMethod]
    public void D1()
        => _converter.TestFromTo(1, "I");

    [TestMethod]
    public void D2()
        => _converter.TestFromTo(2, "II");

    [TestMethod]
    public void D3()
        => _converter.TestFromTo(3, "III");

    [TestMethod]
    public void D4()
        => _converter.TestFromTo(4, "IV");

    [TestMethod]
    public void D5()
        => _converter.TestFromTo(5, "V");

    [TestMethod]
    public void D6()
        => _converter.TestFromTo(6, "VI");

    [TestMethod]
    public void D7()
        => _converter.TestFromTo(7, "VII");

    [TestMethod]
    public void D8()
        => _converter.TestFromTo(8, "VIII");

    [TestMethod]
    public void D9()
        => _converter.TestFromTo(9, "IX");

    [TestMethod]
    public void D10()
        => _converter.TestFromTo(10, "X");

    [TestMethod]
    public void D11()
        => _converter.TestFromTo(11, "XI");

    [TestMethod]
    public void D14()
        => _converter.TestFromTo(14, "XIV");

    [TestMethod]
    public void D15()
        => _converter.TestFromTo(15, "XV");

    [TestMethod]
    public void D19()
        => _converter.TestFromTo(19, "XIX");

    [TestMethod]
    public void D20()
        => _converter.TestFromTo(20, "XX");

    [TestMethod]
    public void D24()
        => _converter.TestFromTo(24, "XXIV");

    [TestMethod]
    public void D30()
        => _converter.TestFromTo(30, "XXX");

    [TestMethod]
    public void D40()
        => _converter.TestFromTo(40, "XL");

    [TestMethod]
    public void D49()
      => _converter.TestFromTo(49, "XLIX");

    [TestMethod]
    public void D50()
        => _converter.TestFromTo(50, "L");

    [TestMethod]
    public void D80()
        => _converter.TestFromTo(80, "LXXX");

    [TestMethod]
    public void D90()
        => _converter.TestFromTo(90, "XC");

    [TestMethod]
    public void D94()
        => _converter.TestFromTo(94, "XCIV");

    [TestMethod]
    public void D99()
        => _converter.TestFromTo(99, "XCIX");

    [TestMethod]
    public void D100()
        => _converter.TestFromTo(100, "C");

    [TestMethod]
    public void D255()
        => _converter.TestFromTo(255, "CCLV");

    [TestMethod]
    public void D345()
        => _converter.TestFromTo(345, "CCCXLV");

    [TestMethod]
    public void D400()
        => _converter.TestFromTo(400, "CD");

    [TestMethod]
    public void D450()
        => _converter.TestFromTo(450, "CDL");

    [TestMethod]
    public void D490()
        => _converter.TestFromTo(490, "CDXC");

    [TestMethod]
    public void D494()
        => _converter.TestFromTo(494, "CDXCIV");

    [TestMethod]
    public void D499()
        => _converter.TestFromTo(499, "CDXCIX");

    [TestMethod]
    public void D500()
        => _converter.TestFromTo(500, "D");

    [TestMethod]
    public void D555()
        => _converter.TestFromTo(555, "DLV");

    [TestMethod]
    public void D800()
        => _converter.TestFromTo(800, "DCCC");

    [TestMethod]
    public void D888()
      => _converter.TestFromTo(888, "DCCCLXXXVIII");

    [TestMethod]
    public void D900()
        => _converter.TestFromTo(900, "CM");

    [TestMethod]
    public void D994()
        => _converter.TestFromTo(994, "CMXCIV");

    [TestMethod]
    public void D999()
        => _converter.TestFromTo(999, "CMXCIX");

    [TestMethod]
    public void D1000()
        => _converter.TestFromTo(1000, "M");

    [TestMethod]
    public void D1001()
        => _converter.TestFromTo(1001, "MI");

    [TestMethod]
    public void D1977()
        => _converter.TestFromTo(1977, "MCMLXXVII");

    [TestMethod]
    public void D2024()
        => _converter.TestFromTo(2024, "MMXXIV");

    [TestMethod]
    public void IC()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.ToULong("IC"));

    [TestMethod]
    public void IM()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.ToULong("IM"));

    [TestMethod]
    public void IXIX()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.ToULong("IXIX"));

    [TestMethod]
    public void IXX()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.ToULong("IXX"));

    [TestMethod]
    public void XXXX()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.ToULong("XXXX"));

    [TestMethod]
    public void VX()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.ToULong("VX"));

    [TestMethod]
    public void XLX()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.ToULong("XLX"));

    [TestMethod]
    public void IVI()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.ToULong("IVI"));

    [TestMethod]
    public void DM()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.ToULong("DM"));

    [TestMethod]
    public void DD()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.ToULong("DD"));

    [TestMethod]
    public void XIXV()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.ToULong("XIXV"));

    [TestMethod]
    public void K()
        => Assert.ThrowsExactly<InvalidInputException>(() => _ = _converter.ToULong("K"));

    [TestMethod]
    public void RomanToBin()
    {
        var stringResult = _converter.Convert("CCLV", new NumberSystemConverter.BaseX.BinaryConverter());

        Assert.AreEqual("11111111", stringResult);
    }
}