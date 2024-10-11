namespace DoenaSoft.NumberSystemConverter.Tests;

[TestClass]
public sealed class BinTests
{
    private readonly BinaryConverter _converter;

    public BinTests()
    {
        _converter = new();
    }

    [TestMethod]
    public void Base()
    {
        Assert.AreEqual(2U, _converter.Base);
    }

    [TestMethod]
    public void D0()
        => _converter.TestConvert(0, "0");

    [TestMethod]
    public void D4()
        => _converter.TestConvert(4, "100");

    [TestMethod]
    public void D255()
        => _converter.TestConvert(255, "11111111");

    [TestMethod]
    public void BinToHex()
    {
        var stringResult = (new BinaryConverter()).Convert("1111", new HexadecimalConverter());

        Assert.AreEqual("F", stringResult);
    }

    [TestMethod]
    public void BinToRoman()
    {
        var stringResult = (new BinaryConverter()).Convert("11111111", new Roman.NumeralConverter());

        Assert.AreEqual("CCLV", stringResult);
    }
}