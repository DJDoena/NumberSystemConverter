using DoenaSoft.NumberSystemConverter.Korean;

namespace DoenaSoft.NumberSystemConverter.Tests.Korean;

[TestClass]
public sealed class HangulTests
{
    private readonly KoreanHangulNumeralConverter _converter = new();

    [TestMethod]
    public void D0()
        => _converter.TestFromTo(0, "영");

    [TestMethod]
    public void D1()
        => _converter.TestFromTo(1, "일");

    [TestMethod]
    public void D2()
        => _converter.TestFromTo(2, "이");

    [TestMethod]
    public void D3()
        => _converter.TestFromTo(3, "삼");

    [TestMethod]
    public void D4()
        => _converter.TestFromTo(4, "사");

    [TestMethod]
    public void D5()
        => _converter.TestFromTo(5, "오");

    [TestMethod]
    public void D6()
        => _converter.TestFromTo(6, "육");

    [TestMethod]
    public void D7()
        => _converter.TestFromTo(7, "칠");

    [TestMethod]
    public void D8()
        => _converter.TestFromTo(8, "팔");

    [TestMethod]
    public void D9()
        => _converter.TestFromTo(9, "구");

    [TestMethod]
    public void D10()
        => _converter.TestFromTo(10, "십");

    [TestMethod]
    public void D11()
        => _converter.TestFromTo(11, "십일");

    [TestMethod]
    public void D12()
        => _converter.TestFromTo(12, "십이");

    [TestMethod]
    public void D19()
        => _converter.TestFromTo(19, "십구");

    [TestMethod]
    public void D20()
        => _converter.TestFromTo(20, "이십");

    [TestMethod]
    public void D21()
        => _converter.TestFromTo(21, "이십일");

    [TestMethod]
    public void D100()
        => _converter.TestFromTo(100, "백");

    [TestMethod]
    public void D101()
        => _converter.TestFromTo(101, "백일");

    [TestMethod]
    public void D110()
        => _converter.TestFromTo(110, "백십");

    [TestMethod]
    public void D111()
        => _converter.TestFromTo(111, "백십일");

    [TestMethod]
    public void D1000()
        => _converter.TestFromTo(1000, "천");

    [TestMethod]
    public void D1001()
        => _converter.TestFromTo(1001, "천일");

    [TestMethod]
    public void D1010()
        => _converter.TestFromTo(1010, "천십");

    [TestMethod]
    public void D1100()
        => _converter.TestFromTo(1100, "천백");

    [TestMethod]
    public void D2024()
        => _converter.TestFromTo(2024, "이천이십사");

    [TestMethod]
    public void D10000()
        => _converter.TestFromTo(10000, "일만");

    [TestMethod]
    public void D10001()
        => _converter.TestFromTo(10001, "일만일");

    [TestMethod]
    public void D20026()
        => _converter.TestFromTo(20026, "이만이십육");

    [TestMethod]
    public void D100000000()
        => _converter.TestFromTo(100000000, "일억");

    [TestMethod]
    public void D123456789()
        => _converter.TestFromTo(123456789, "일억이천삼백사십오만육천칠백팔십구");

    [TestMethod]
    public void D200026()
        => _converter.TestFromTo(200026, "이십만이십육");

    [TestMethod]
    public void D2000026()
        => _converter.TestFromTo(2000026, "이백만이십육");
}
