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
    public void D0()
        => _converter.TestFromTo(0, "0");

    [TestMethod]
    public void D1999()
        => _converter.TestFromTo(1999, "1999");

    [TestMethod]
    public void D255()
        => _converter.TestFromTo(255, "255");
}