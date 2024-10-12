using DoenaSoft.NumberSystemConverter.BaseX;

namespace DoenaSoft.NumberSystemConverter.Tests.BaseX;

[TestClass]
public sealed class DuodecTests
{
    private readonly DuodecimalConverter _converter = new();

    [TestMethod]
    public void Base()
    {
        Assert.AreEqual(12U, _converter.Base);
    }

    [TestMethod]
    public void D0()
        => _converter.TestFromTo(0, "0");

    [TestMethod]
    public void D10()
        => _converter.TestFromTo(10, "↊");

    [TestMethod]
    public void D11()
        => _converter.TestFromTo(11, "↋");

    [TestMethod]
    public void D12()
        => _converter.TestFromTo(12, "10");

    [TestMethod]
    public void D141()
        => _converter.TestFromTo(141, "↋9");

    [TestMethod]
    public void D142()
        => _converter.TestFromTo(142, "↋↊");

    [TestMethod]
    public void D143()
        => _converter.TestFromTo(143, "↋↋");

    [TestMethod]
    public void D144()
        => _converter.TestFromTo(144, "100");

    [TestMethod]
    public void D255()
        => _converter.TestFromTo(255, "193");
}