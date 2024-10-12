using DoenaSoft.NumberSystemConverter.BaseX;

namespace DoenaSoft.NumberSystemConverter.Tests.BaseX;

[TestClass]
public sealed class HexTests
{
    private readonly HexadecimalConverter _converter;

    public HexTests()
    {
        _converter = new();
    }

    [TestMethod]
    public void Base()
    {
        Assert.AreEqual(16U, _converter.Base);
    }

    [TestMethod]
    public void D0()
        => _converter.TestFromTo(0, "0");

    [TestMethod]
    public void D10()
        => _converter.TestFromTo(10, "A");

    [TestMethod]
    public void D15()
        => _converter.TestFromTo(15, "F");

    [TestMethod]
    public void D16()
        => _converter.TestFromTo(16, "10");

    [TestMethod]
    public void D255()
        => _converter.TestFromTo(255, "FF");

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void InputNull()
        => _converter.ToULong(null!);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void InputEmpty()
        => _converter.ToULong(string.Empty);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void InputWhitespace()
        => _converter.ToULong(" ");

    [TestMethod]
    public void HexToBin()
    {
        var stringResult = _converter.Convert("F", new BinaryConverter());

        Assert.AreEqual("1111", stringResult);
    }
}