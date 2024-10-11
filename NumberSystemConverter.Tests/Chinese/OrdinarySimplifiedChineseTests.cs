using DoenaSoft.NumberSystemConverter.Chinese;

namespace DoenaSoft.NumberSystemConverter.Tests.Chinese;

[TestClass]
public sealed class OrdinarySimplifiedChineseTests
{
    private readonly OrdinarySimplifiedNumeralConverter _converter;

    public OrdinarySimplifiedChineseTests()
    {
        _converter = new();
    }

    [TestMethod]
    public void D0()
        => _converter.TestFromTo(0, "零");

    [TestMethod]
    public void D1()
        => _converter.TestFromTo(1, "一");

    [TestMethod]
    public void D2()
        => _converter.TestFromTo(2, "二");

    [TestMethod]
    public void D3()
        => _converter.TestFromTo(3, "三");

    [TestMethod]
    public void D4()
        => _converter.TestFromTo(4, "四");

    [TestMethod]
    public void D5()
        => _converter.TestFromTo(5, "五");

    [TestMethod]
    public void D6()
        => _converter.TestFromTo(6, "六");

    [TestMethod]
    public void D7()
        => _converter.TestFromTo(7, "七");

    [TestMethod]
    public void D8()
        => _converter.TestFromTo(8, "八");

    [TestMethod]
    public void D9()
        => _converter.TestFromTo(9, "九");

    [TestMethod]
    public void D10()
        => _converter.TestFromTo(10, "十");

    [TestMethod]
    public void D11()
        => _converter.TestFromTo(11, "十一");

    [TestMethod]
    public void D12()
        => _converter.TestFromTo(12, "十二");

    [TestMethod]
    public void D20()
        => _converter.TestFromTo(20, "二十");

    [TestMethod]
    public void D21()
        => _converter.TestFromTo(21, "二十一");

    [TestMethod]
    public void D22()
        => _converter.TestFromTo(22, "二十二");

    [TestMethod]
    public void D100()
        => _converter.TestFromTo(100, "一百");

    [TestMethod]
    public void D101()
        => _converter.TestFromTo(101, "一百零一");

    [TestMethod]
    public void D102()
        => _converter.TestFromTo(102, "一百零二");

    [TestMethod]
    public void D10_000()
        => _converter.TestFromTo(10_000, "一万");

    [TestMethod]
    public void D11_000()
        => _converter.TestFromTo(11_000, "一万一千");

    [TestMethod]
    public void D18_000()
        => _converter.TestFromTo(18_000, "一万八千");

    [TestMethod]
    public void D31_240()
         => _converter.TestFromTo(31_240, "三万一千二百四十"); // 三万一千两百四十 ?

    [TestMethod]
    public void D34_054()
        => _converter.TestFromTo(34_354, "三万四千三百五十四");

    [TestMethod]
    public void D34_354()
        => _converter.TestFromTo(34_354, "三万四千三百五十四");

    [TestMethod]
    public void D40_005()
      => _converter.TestFromTo(40_005, "四万零五");

    [TestMethod]
    public void D40_050()
        => _converter.TestFromTo(40_050, "四万零五十");

    [TestMethod]
    public void D40_500()
         => _converter.TestFromTo(40_500, "四万零五百");

    [TestMethod]
    public void D45_000()
         => _converter.TestFromTo(45_000, "四万五千");

    [TestMethod]
    public void D100_000_000()
        => _converter.TestFromTo(100_000_000, "一亿");

    [TestMethod]
    public void D5_671_890()
        => _converter.TestFromTo(5_671_890, "五百六十七万一千八百九十");

    [TestMethod]
    public void D9_564_435()
        => _converter.TestFromTo(9_564_435, "九百五十六万四千四百三十五");

    [TestMethod]
    public void D30_456_720()
        => _converter.TestFromTo(30_456_720, "三千零四十五万六千七百二十");

    [TestMethod]
    public void D200_080_000()
        => _converter.TestFromTo(200_080_000, "二亿零八万");

    [TestMethod]
    public void D200_800_000()
        => _converter.TestFromTo(200_800_000, "二亿零八十万"); // 两亿零八十万 ?

    [TestMethod]
    public void D201_800_000()
        => _converter.TestFromTo(201_800_000, "二亿一百八十万");

    [TestMethod]
    public void D2_400_360_899()
        => _converter.TestFromTo(2_400_360_899, "二十四亿零三十六万零八百九十九"); // 二十四亿三十六万零八百九十九 ?

    [TestMethod]
    public void D200_800_000_alternate()
        => _converter.TestTo("两亿零八十万", 200_800_000);

    [TestMethod]
    [ExpectedException(typeof(OverflowException))]
    public void D1_000_0000_000_000_000()
         => _ = _converter.ToUInt("一亿一亿");

    [TestMethod]
    [ExpectedException(typeof(OverflowException))]
    public void D1_000_000_000_000()
        => _ = _converter.ToUInt("一万亿");

    [TestMethod]
    [ExpectedException(typeof(OverflowException))]
    public void D5_000_000_000()
        => _ = _converter.ToUInt("五十亿");

    [TestMethod]
    public void D4_000_000_000()
        => _converter.TestFromTo(4_000_000_000U, "四十亿");

    [TestMethod]
    public void D2_222()
        => _converter.TestFromTo(2222, "二千二百二十二");

    [TestMethod]
    public void D2_222_alternate()
        => _converter.TestTo("兩千二百二十二", 2222);

    [TestMethod]
    public void D2_222_alternate2()
        => _converter.TestTo("兩千兩百二十二", 2222);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D10_invalid()
        => _ = _converter.ToUInt("呀");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D110_invalid()
        => _ = _converter.ToUInt("一百呀");

    [TestMethod]
    public void D111()
        => _converter.TestTo("一百呀一", 111);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D40_invalid()
        => _ = _converter.ToUInt("卌");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D140_invalid()
        => _ = _converter.ToUInt("一百卌");

    [TestMethod]
    public void D141()
        => _converter.TestTo("一百卌一", 141);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D20_20_invalid()
        => _ = _converter.ToUInt("念廿");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D20_20_invalid2()
        => _ = _converter.ToUInt("念二十");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D20_20_invalid3()
        => _ = _converter.ToUInt("二十二十");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D20_20_invalid4()
        => _ = _converter.ToUInt("念念");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D100_100_invalid()
        => _ = _converter.ToUInt("一百一百");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D1_000_1_0000_invalid()
        => _ = _converter.ToUInt("一千一千");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D10_000_10_0000_invalid()
        => _ = _converter.ToUInt("一万一万");

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void InputNull()
        => _ = _converter.ToUInt(null!);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void InputEmpty()
        => _ = _converter.ToUInt("");

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void InputWhitespace()
        => _ = _converter.ToUInt(" ");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void InputInvalid()
        => _ = _converter.ToUInt("A");

    [TestMethod]
    public void D200_special()
        => _converter.TestTo("皕", 200);

    [TestMethod]
    public void D222_special()
         => _converter.TestTo("皕念两", 222);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D0_0_invalid()
        => _ = _converter.ToUInt("零零");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D0_0_invalid2()
        => _ = _converter.ToUInt("零空");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D0_0_invalid3()
        => _ = _converter.ToUInt("一百零零一");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D0_0_invalid4()
        => _ = _converter.ToUInt("一百零空一");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D1_1_invalid4()
        => _ = _converter.ToUInt("一一");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D1_200_invalid()
        => _ = _converter.ToUInt("一皕");

    [TestMethod]
    public void OrdinaryToFinancial()
    {
        var stringResult = _converter.Convert("一千二百三十四", new FinancialSimplifiedNumeralConverter());

        Assert.AreEqual("壹仟贰佰叁拾肆", stringResult);
    }
}