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
    public void Zero()
        => _converter.TestConvert(0, "0");

    [TestMethod]
    public void Ten()
        => _converter.TestConvert(10, "↊");

    [TestMethod]
    public void Eleven()
        => _converter.TestConvert(11, "↋");

    [TestMethod]
    public void Twelve()
        => _converter.TestConvert(12, "10");

    [TestMethod]
    public void OneFortyOne()
        => _converter.TestConvert(141, "↋9");

    [TestMethod]
    public void OneFortyTwo()
        => _converter.TestConvert(142, "↋↊");

    [TestMethod]
    public void OneFortyThree()
        => _converter.TestConvert(143, "↋↋");

    [TestMethod]
    public void OneFortyFour()
        => _converter.TestConvert(144, "100");

    [TestMethod]
    public void TwoFiftyFive()
        => _converter.TestConvert(255, "193");
}