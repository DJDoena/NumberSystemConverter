using DoenaSoft.NumberSystemConverter.Roman;

namespace DoenaSoft.NumberSystemConverter.Tests;

[TestClass]
public sealed class RomanNumeralInputValidatorTests
{
    private readonly NumeralInputValidator _validator;

    public RomanNumeralInputValidatorTests()
    {
        _validator = new();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void EmptyToUInt()
        => _ = _validator.Validate("");

    [TestMethod]
    public void One()
        => this.Verify(_validator.Validate("I"), 1);

    [TestMethod]
    public void Two()
        => this.Verify(_validator.Validate("II"), 1, 1);

    [TestMethod]
    public void Three()
        => this.Verify(_validator.Validate("III"), 1, 1, 1);

    [TestMethod]
    public void Four()
        => this.Verify(_validator.Validate("IV"), 4);

    [TestMethod]
    public void Five()
        => this.Verify(_validator.Validate("V"), 5);

    [TestMethod]
    public void Six()
        => this.Verify(_validator.Validate("VI"), 5, 1);

    [TestMethod]
    public void Seven()
        => this.Verify(_validator.Validate("VII"), 5, 1, 1);

    [TestMethod]
    public void Eight()
        => this.Verify(_validator.Validate("VIII"), 5, 1, 1, 1);

    [TestMethod]
    public void Nine()
        => this.Verify(_validator.Validate("IX"), 9);

    [TestMethod]
    public void Ten()
        => this.Verify(_validator.Validate("X"), 10);

    [TestMethod]
    public void Eleven()
        => this.Verify(_validator.Validate("XI"), 10, 1);

    [TestMethod]
    public void Fourteen()
        => this.Verify(_validator.Validate("XIV"), 10, 4);

    [TestMethod]
    public void Fifteen()
        => this.Verify(_validator.Validate("XV"), 10, 5);

    [TestMethod]
    public void Nineteen()
        => this.Verify(_validator.Validate("XIX"), 10, 9);

    [TestMethod]
    public void Twenty()
        => this.Verify(_validator.Validate("XX"), 10, 10);

    [TestMethod]
    public void TwentyFour()
        => this.Verify(_validator.Validate("XXIV"), 10, 10, 4);

    [TestMethod]
    public void Thirty()
        => this.Verify(_validator.Validate("XXX"), 10, 10, 10);

    [TestMethod]
    public void Fourty()
        => this.Verify(_validator.Validate("XL"), 40);

    [TestMethod]
    public void FourtyNine()
        => this.Verify(_validator.Validate("XLIX"), 40, 9);

    [TestMethod]
    public void Fifty()
        => this.Verify(_validator.Validate("L"), 50);

    [TestMethod]
    public void Eighty()
        => this.Verify(_validator.Validate("LXXX"), 50, 10, 10, 10);

    [TestMethod]
    public void Ninety()
        => this.Verify(_validator.Validate("XC"), 90);

    [TestMethod]
    public void NinetyFour()
        => this.Verify(_validator.Validate("XCIV"), 90, 4);

    [TestMethod]
    public void NinetyNine()
        => this.Verify(_validator.Validate("XCIX"), 90, 9);

    [TestMethod]
    public void OneHundred()
        => this.Verify(_validator.Validate("C"), 100);

    [TestMethod]
    public void ThreeHundredFortyFive()
        => this.Verify(_validator.Validate("CCCXLV"), 100, 100, 100, 40, 5);

    [TestMethod]
    public void FourHundred()
        => this.Verify(_validator.Validate("CD"), 400);

    [TestMethod]
    public void TwoHundredFiftyFive()
        => this.Verify(_validator.Validate("CCLV"), 100, 100, 50, 5);

    [TestMethod]
    public void FourHundredFifty()
        => this.Verify(_validator.Validate("CDL"), 400, 50);

    [TestMethod]
    public void FourHundredNinety()
        => this.Verify(_validator.Validate("CDXC"), 400, 90);

    [TestMethod]
    public void FourHundredNinetyFour()
        => this.Verify(_validator.Validate("CDXCIV"), 400, 90, 4);

    [TestMethod]
    public void FourHundredNinetyNine()
        => this.Verify(_validator.Validate("CDXCIX"), 400, 90, 9);

    [TestMethod]
    public void FiveHundred()
        => this.Verify(_validator.Validate("D"), 500);

    [TestMethod]
    public void FiveHundredFiftyFive()
        => this.Verify(_validator.Validate("DLV"), 500, 50, 5);

    [TestMethod]
    public void EightHundred()
        => this.Verify(_validator.Validate("DCCC"), 500, 100, 100, 100);

    [TestMethod]
    public void EightHundredEightyEight()
        => this.Verify(_validator.Validate("DCCCLXXXVIII"), 500, 100, 100, 100, 50, 10, 10, 10, 5, 1, 1, 1);

    [TestMethod]
    public void NineHundred()
        => this.Verify(_validator.Validate("CM"), 900);

    [TestMethod]
    public void NineHundredNinetyFour()
        => this.Verify(_validator.Validate("CMXCIV"), 900, 90, 4);

    [TestMethod]
    public void NineHundredNinetyNine()
        => this.Verify(_validator.Validate("CMXCIX"), 900, 90, 9);

    [TestMethod]
    public void OneThousand()
        => this.Verify(_validator.Validate("M"), 1000);

    [TestMethod]
    public void OneThousandOne()
        => this.Verify(_validator.Validate("MI"), 1000, 1);

    [TestMethod]
    public void OneThousandNineHundredSeventySeven()
        => this.Verify(_validator.Validate("MCMLXXVII"), 1000, 900, 50, 10, 10, 5, 1, 1);

    [TestMethod]
    public void TwoThrousandTwentyFour()
        => this.Verify(_validator.Validate("MMXXIV"), 1000, 1000, 10, 10, 4);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void IC()
        => _ = _validator.Validate("IC");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void IM()
        => _ = _validator.Validate("IM");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void IXIX()
        => _ = _validator.Validate("IXIX");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void IXX()
        => _ = _validator.Validate("IXX");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void XXXX()
        => _ = _validator.Validate("XXXX");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void VX()
        => _ = _validator.Validate("VX");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void XLX()
        => _ = _validator.Validate("XLX");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void IVI()
        => _ = _validator.Validate("IVI");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void DM()
        => _ = _validator.Validate("DM");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void DD()
        => _ = _validator.Validate("DD");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void XIXV()
        => _validator.Validate("XIXV");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void K()
        => _validator.Validate("K");

    private void Verify(List<ushort> actual, params ushort[] expected)
    {
        Assert.IsNotNull(actual);

        Assert.IsTrue(actual.Count > 0);

        Assert.AreEqual(expected.Length, actual.Count);

        Assert.AreEqual(expected[0], actual[0]);

        for (var i = 1; i < expected.Length; i++)
        {
            Assert.AreEqual(expected[i], actual[i]);

            Assert.IsTrue(actual[i] <= actual[i - 1]);
        }
    }
}