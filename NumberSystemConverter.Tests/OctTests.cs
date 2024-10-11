namespace DoenaSoft.NumberSystemConverter.Tests;

[TestClass]
public sealed class OctTests
{
    private readonly OctalConverter _converter;

    public OctTests()
    {
        _converter = new();
    }

    [TestMethod]
    public void Base()
    {
        Assert.AreEqual(8U, _converter.Base);
    }

    [TestMethod]
    public void D0()
        => _converter.TestFromTo(0, "0");

    [TestMethod]
    public void D8()
        => _converter.TestFromTo(8, "10");

    [TestMethod]
    public void D255()
        => _converter.TestFromTo(255, "377");
}