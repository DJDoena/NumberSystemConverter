using DoenaSoft.NumberSystemConverter.BaseX;

namespace DoenaSoft.NumberSystemConverter.Tests.BaseX;

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
        => _converter.TestFromTo(0, "0");

    [TestMethod]
    public void D4()
        => _converter.TestFromTo(4, "100");

    [TestMethod]
    public void D255()
        => _converter.TestFromTo(255, "11111111");

    [TestMethod]
    public void BinToHex()
    {
        var stringResult = _converter.Convert("1111", new HexadecimalConverter());

        Assert.AreEqual("F", stringResult);
    }

    [TestMethod]
    public void BinToRoman()
    {
        var stringResult = _converter.Convert("11111111", new NumberSystemConverter.Roman.NumeralConverter());

        Assert.AreEqual("CCLV", stringResult);
    }
}