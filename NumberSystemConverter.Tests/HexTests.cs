namespace DoenaSoft.NumberSystemConverter.Tests;

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
    public void Zero()
        => _converter.TestConvert(0, "0");

    [TestMethod]
    public void Ten()
        => _converter.TestConvert(10, "A");

    [TestMethod]
    public void Fifteen()
        => _converter.TestConvert(15, "F");

    [TestMethod]
    public void Sixteen()
        => _converter.TestConvert(16, "10");

    [TestMethod]
    public void TwoFiftyFive()
        => _converter.TestConvert(255, "FF");

    [TestMethod]
    public void HexToBin()
    {
        var stringResult = GenericConverter.Convert("F", new HexadecimalConverter(), new BinaryConverter());

        Assert.AreEqual("1111", stringResult);
    }
}