namespace DoenaSoft.NumberSystemConverter.Tests;

[TestClass]
public sealed class DecTests
{
    private readonly DecimalConverter _converter;

    public DecTests()
    {
        _converter = new();
    }

    [TestMethod]
    public void Base()
    {
        Assert.AreEqual(10U, _converter.Base);
    }

    [TestMethod]
    public void Zero()
        => _converter.TestConvert(0, "0");

    [TestMethod]
    public void NineteenNinetyNine()
        => _converter.TestConvert(1999, "1999");

    [TestMethod]
    public void TwoFiftyFive()
        => _converter.TestConvert(255, "255");
}