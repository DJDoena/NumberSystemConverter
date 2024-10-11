namespace DoenaSoft.NumberSystemConverter.Tests;

[TestClass]
public sealed class DuodecTests
{
    private readonly DuodecimalConverter _converter;

    public DuodecTests()
    {
        _converter = new();
    }

    [TestMethod]
    public void Base()
    {
        Assert.AreEqual(12U, _converter.Base);
    }

    [TestMethod]
    public void D0()
        => _converter.TestConvert(0, "0");

    [TestMethod]
    public void D10()
        => _converter.TestConvert(10, "↊");

    [TestMethod]
    public void D11()
        => _converter.TestConvert(11, "↋");

    [TestMethod]
    public void D12()
        => _converter.TestConvert(12, "10");

    [TestMethod]
    public void D141()
        => _converter.TestConvert(141, "↋9");

    [TestMethod]
    public void D142()
        => _converter.TestConvert(142, "↋↊");

    [TestMethod]
    public void D143()
        => _converter.TestConvert(143, "↋↋");

    [TestMethod]
    public void D144()
        => _converter.TestConvert(144, "100");

    [TestMethod]
    public void D255()
        => _converter.TestConvert(255, "193");
}