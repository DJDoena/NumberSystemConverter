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
    public void ToUIntEmpty()
        => _ = _validator.Validate("");

    [TestMethod]
    public void D1()
        => this.Verify(_validator.Validate("I"), 1);

    [TestMethod]
    public void D2()
        => this.Verify(_validator.Validate("II"), 1, 1);

    [TestMethod]
    public void D3()
        => this.Verify(_validator.Validate("III"), 1, 1, 1);

    [TestMethod]
    public void D4()
        => this.Verify(_validator.Validate("IV"), 4);

    [TestMethod]
    public void D5()
        => this.Verify(_validator.Validate("V"), 5);

    [TestMethod]
    public void D6()
        => this.Verify(_validator.Validate("VI"), 5, 1);

    [TestMethod]
    public void D7()
        => this.Verify(_validator.Validate("VII"), 5, 1, 1);

    [TestMethod]
    public void D8()
        => this.Verify(_validator.Validate("VIII"), 5, 1, 1, 1);

    [TestMethod]
    public void D9()
        => this.Verify(_validator.Validate("IX"), 9);

    [TestMethod]
    public void D10()
        => this.Verify(_validator.Validate("X"), 10);

    [TestMethod]
    public void D11()
        => this.Verify(_validator.Validate("XI"), 10, 1);

    [TestMethod]
    public void D14()
        => this.Verify(_validator.Validate("XIV"), 10, 4);

    [TestMethod]
    public void D15()
        => this.Verify(_validator.Validate("XV"), 10, 5);

    [TestMethod]
    public void D19()
        => this.Verify(_validator.Validate("XIX"), 10, 9);

    [TestMethod]
    public void D20()
        => this.Verify(_validator.Validate("XX"), 10, 10);

    [TestMethod]
    public void D24()
        => this.Verify(_validator.Validate("XXIV"), 10, 10, 4);

    [TestMethod]
    public void D30()
        => this.Verify(_validator.Validate("XXX"), 10, 10, 10);

    [TestMethod]
    public void D40()
        => this.Verify(_validator.Validate("XL"), 40);

    [TestMethod]
    public void D49()
        => this.Verify(_validator.Validate("XLIX"), 40, 9);

    [TestMethod]
    public void D50()
        => this.Verify(_validator.Validate("L"), 50);

    [TestMethod]
    public void D80()
        => this.Verify(_validator.Validate("LXXX"), 50, 10, 10, 10);

    [TestMethod]
    public void D90()
        => this.Verify(_validator.Validate("XC"), 90);

    [TestMethod]
    public void D94()
        => this.Verify(_validator.Validate("XCIV"), 90, 4);

    [TestMethod]
    public void D99()
        => this.Verify(_validator.Validate("XCIX"), 90, 9);

    [TestMethod]
    public void D100()
        => this.Verify(_validator.Validate("C"), 100);

    [TestMethod]
    public void D255()
        => this.Verify(_validator.Validate("CCLV"), 100, 100, 50, 5);

    [TestMethod]
    public void D345()
        => this.Verify(_validator.Validate("CCCXLV"), 100, 100, 100, 40, 5);

    [TestMethod]
    public void D400()
        => this.Verify(_validator.Validate("CD"), 400);

    [TestMethod]
    public void D450()
        => this.Verify(_validator.Validate("CDL"), 400, 50);

    [TestMethod]
    public void D490()
        => this.Verify(_validator.Validate("CDXC"), 400, 90);

    [TestMethod]
    public void D494()
        => this.Verify(_validator.Validate("CDXCIV"), 400, 90, 4);

    [TestMethod]
    public void D499()
        => this.Verify(_validator.Validate("CDXCIX"), 400, 90, 9);

    [TestMethod]
    public void D500()
        => this.Verify(_validator.Validate("D"), 500);

    [TestMethod]
    public void D555()
        => this.Verify(_validator.Validate("DLV"), 500, 50, 5);

    [TestMethod]
    public void D800()
        => this.Verify(_validator.Validate("DCCC"), 500, 100, 100, 100);

    [TestMethod]
    public void D888()
        => this.Verify(_validator.Validate("DCCCLXXXVIII"), 500, 100, 100, 100, 50, 10, 10, 10, 5, 1, 1, 1);

    [TestMethod]
    public void D900()
        => this.Verify(_validator.Validate("CM"), 900);

    [TestMethod]
    public void D994()
        => this.Verify(_validator.Validate("CMXCIV"), 900, 90, 4);

    [TestMethod]
    public void D999()
        => this.Verify(_validator.Validate("CMXCIX"), 900, 90, 9);

    [TestMethod]
    public void D1000()
        => this.Verify(_validator.Validate("M"), 1000);

    [TestMethod]
    public void D1001()
        => this.Verify(_validator.Validate("MI"), 1000, 1);

    [TestMethod]
    public void D1977()
        => this.Verify(_validator.Validate("MCMLXXVII"), 1000, 900, 50, 10, 10, 5, 1, 1);

    [TestMethod]
    public void D2024()
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