using DoenaSoft.NumberSystemConverter.Chinese;

namespace DoenaSoft.NumberSystemConverter.Tests;

[TestClass]
public sealed class OrdinarySimplifiedNumeralConverterTests
{
    private readonly OrdinarySimplifiedNumeralConverter _converter;

    public OrdinarySimplifiedNumeralConverterTests()
    {
        _converter = new();
    }

    [TestMethod]
    public void D1()
        => _converter.TestConvert2(1, "一");

    [TestMethod]
    public void D2()
        => _converter.TestConvert2(2, "二");

    [TestMethod]
    public void D3()
        => _converter.TestConvert2(3, "三");

    [TestMethod]
    public void D4()
        => _converter.TestConvert2(4, "四");

    [TestMethod]
    public void D5()
        => _converter.TestConvert2(5, "五");

    [TestMethod]
    public void D6()
        => _converter.TestConvert2(6, "六");

    [TestMethod]
    public void D7()
        => _converter.TestConvert2(7, "七");

    [TestMethod]
    public void D8()
        => _converter.TestConvert2(8, "八");

    [TestMethod]
    public void D9()
        => _converter.TestConvert2(9, "九");

    [TestMethod]
    public void D10()
        => _converter.TestConvert2(10, "十");

    [TestMethod]
    public void D11()
        => _converter.TestConvert2(11, "十一");

    [TestMethod]
    public void D12()
        => _converter.TestConvert2(12, "十二");

    [TestMethod]
    public void D20()
        => _converter.TestConvert2(20, "二十");

    [TestMethod]
    public void D21()
        => _converter.TestConvert2(21, "二十一");

    [TestMethod]
    public void D22()
        => _converter.TestConvert2(22, "二十二");

    [TestMethod]
    public void D100()
        => _converter.TestConvert2(100, "一百");

    [TestMethod]
    public void D101()
        => _converter.TestConvert2(101, "一百零一");

    [TestMethod]
    public void D102()
        => _converter.TestConvert2(102, "一百零二");

    [TestMethod]
    public void D10_000()
        => _converter.TestConvert2(10_000, "一万");

    [TestMethod]
    public void D11_000()
        => _converter.TestConvert2(11_000, "一万一千");

    [TestMethod]
    public void D18_000()
        => _converter.TestConvert2(18_000, "一万八千");

    [TestMethod]
    public void D31_240()
         => _converter.TestConvert2(31_240, "三万一千二百四十"); // 三万一千两百四十 ?

    [TestMethod]
    public void D34_054()
        => _converter.TestConvert2(34_354, "三万四千三百五十四");

    [TestMethod]
    public void D34_354()
        => _converter.TestConvert2(34_354, "三万四千三百五十四");

    [TestMethod]
    public void D40_005()
      => _converter.TestConvert2(40_005, "四万零五");

    [TestMethod]
    public void D40_050()
        => _converter.TestConvert2(40_050, "四万零五十");

    [TestMethod]
    public void D40_500()
         => _converter.TestConvert2(40_500, "四万零五百");

    [TestMethod]
    public void D45_000()
         => _converter.TestConvert2(45_000, "四万五千");

    [TestMethod]
    public void D100_000_000()
        => _converter.TestConvert2(100_000_000, "一亿");

    [TestMethod]
    public void D5_671_890()
        => _converter.TestConvert2(5_671_890, "五百六十七万一千八百九十");

    [TestMethod]
    public void D9_564_435()
        => _converter.TestConvert2(9_564_435, "九百五十六万四千四百三十五");

    [TestMethod]
    public void D30_456_720()
        => _converter.TestConvert2(30_456_720, "三千零四十五万六千七百二十");

    [TestMethod]
    public void D200_080_000()
        => _converter.TestConvert2(200_080_000, "二亿零八万"); // 两亿零八十万 ?

    [TestMethod]
    public void D200_800_000()
      => _converter.TestConvert2(200_800_000, "二亿零八十万");

    [TestMethod]
    public void D201_800_000()
    => _converter.TestConvert2(201_800_000, "二亿一百八十万");

    [TestMethod]
    public void D2_400_360_899()
        => _converter.TestConvert2(2_400_360_899, "二十四亿零三十六万零八百九十九"); // 二十四亿三十六万零八百九十九 ?
}