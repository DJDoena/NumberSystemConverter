using DoenaSoft.NumberSystemConverter.Roman;

namespace DoenaSoft.NumberSystemConverter.Tests;

[TestClass]
public sealed class RomanNumeralTests
{
    private readonly NumeralConverter _converter;

    public RomanNumeralTests()
    {
        _converter = new();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ZeroFromUInt()
        => _ = _converter.FromUInt(0);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void ZeroToUInt()
        => _ = _converter.ToUInt("");

    [TestMethod]
    public void One()
        => _converter.TestConvert(1, "I");

    [TestMethod]
    public void Two()
        => _converter.TestConvert(2, "II");

    [TestMethod]
    public void Three()
        => _converter.TestConvert(3, "III");

    [TestMethod]
    public void Four()
        => _converter.TestConvert(4, "IV");

    [TestMethod]
    public void Five()
        => _converter.TestConvert(5, "V");

    [TestMethod]
    public void Six()
        => _converter.TestConvert(6, "VI");

    [TestMethod]
    public void Seven()
        => _converter.TestConvert(7, "VII");

    [TestMethod]
    public void Eight()
        => _converter.TestConvert(8, "VIII");

    [TestMethod]
    public void Nine()
        => _converter.TestConvert(9, "IX");

    [TestMethod]
    public void Ten()
        => _converter.TestConvert(10, "X");

    [TestMethod]
    public void Eleven()
        => _converter.TestConvert(11, "XI");

    [TestMethod]
    public void Fourteen()
        => _converter.TestConvert(14, "XIV");

    [TestMethod]
    public void Fifteen()
        => _converter.TestConvert(15, "XV");

    [TestMethod]
    public void Nineteen()
        => _converter.TestConvert(19, "XIX");

    [TestMethod]
    public void Twenty()
        => _converter.TestConvert(20, "XX");

    [TestMethod]
    public void TwentyFour()
        => _converter.TestConvert(24, "XXIV");

    [TestMethod]
    public void Thirty()
        => _converter.TestConvert(30, "XXX");

    [TestMethod]
    public void Fourty()
        => _converter.TestConvert(40, "XL");

    [TestMethod]
    public void FourtyNine()
      => _converter.TestConvert(49, "XLIX");

    [TestMethod]
    public void Fifty()
        => _converter.TestConvert(50, "L");

    [TestMethod]
    public void Eighty()
        => _converter.TestConvert(80, "LXXX");

    [TestMethod]
    public void Ninety()
        => _converter.TestConvert(90, "XC");

    [TestMethod]
    public void NinetyFour()
        => _converter.TestConvert(94, "XCIV");

    [TestMethod]
    public void NinetyNine()
        => _converter.TestConvert(99, "XCIX");

    [TestMethod]
    public void OneHundred()
        => _converter.TestConvert(100, "C");

    [TestMethod]
    public void ThreeHundredFortyFive()
        => _converter.TestConvert(345, "CCCXLV");

    [TestMethod]
    public void FourHundred()
        => _converter.TestConvert(400, "CD");

    [TestMethod]
    public void TwoHundredFiftyFive()
        => _converter.TestConvert(255, "CCLV");

    [TestMethod]
    public void FourHundredFifty()
        => _converter.TestConvert(450, "CDL");

    [TestMethod]
    public void FourHundredNinety()
        => _converter.TestConvert(490, "CDXC");

    [TestMethod]
    public void FourHundredNinetyFour()
        => _converter.TestConvert(494, "CDXCIV");

    [TestMethod]
    public void FourHundredNinetyNine()
        => _converter.TestConvert(499, "CDXCIX");

    [TestMethod]
    public void FiveHundred()
        => _converter.TestConvert(500, "D");

    [TestMethod]
    public void FiveHundredFiftyFive()
        => _converter.TestConvert(555, "DLV");

    [TestMethod]
    public void EightHundred()
        => _converter.TestConvert(800, "DCCC");

    [TestMethod]
    public void EightHundredEightyEight()
      => _converter.TestConvert(888, "DCCCLXXXVIII");

    [TestMethod]
    public void NineHundred()
        => _converter.TestConvert(900, "CM");

    [TestMethod]
    public void NineHundredNinetyFour()
        => _converter.TestConvert(994, "CMXCIV");

    [TestMethod]
    public void NineHundredNinetyNine()
        => _converter.TestConvert(999, "CMXCIX");

    [TestMethod]
    public void OneThousand()
        => _converter.TestConvert(1000, "M");

    [TestMethod]
    public void OneThousandOne()
        => _converter.TestConvert(1001, "MI");

    [TestMethod]
    public void OneThousandNineHundredSeventySeven()
        => _converter.TestConvert(1977, "MCMLXXVII");

    [TestMethod]
    public void TwoThrousandTwentyFour()
        => _converter.TestConvert(2024, "MMXXIV");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void IC()
        => _ = _converter.ToUInt("IC");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void IM()
        => _ = _converter.ToUInt("IM");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void IXIX()
        => _ = _converter.ToUInt("IXIX");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void IXX()
        => _ = _converter.ToUInt("IXX");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void XXXX()
        => _ = _converter.ToUInt("XXXX");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void VX()
        => _ = _converter.ToUInt("VX");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void XLX()
        => _ = _converter.ToUInt("XLX");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void IVI()
        => _ = _converter.ToUInt("IVI");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void DM()
        => _ = _converter.ToUInt("DM");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void DD()
        => _ = _converter.ToUInt("DD");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void XIXV()
        => _converter.TestConvert(15, "XIXV");

    [TestMethod]
    public void RomanToBin()
    {
        var stringResult = GenericConverter.Convert("CCLV", new NumeralConverter(), new BinaryConverter());

        Assert.AreEqual("11111111", stringResult);
    }
}