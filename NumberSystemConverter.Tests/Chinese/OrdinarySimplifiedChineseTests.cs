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
    public void D19()
        => _converter.TestFromTo(19, "十九");

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
    public void D110()
        => _converter.TestFromTo(110, "一百一十");

    [TestMethod]
    public void D111()
        => _converter.TestTo("一百一十一", 111);

    [TestMethod]
    public void D1000()
        => _converter.TestFromTo(1000, "一千");

    [TestMethod]
    public void D1010()
        => _converter.TestFromTo(1010, "一千零一十");

    [TestMethod]
    public void D1234()
        => _converter.TestFromTo(1234, "一千二百三十四");

    [TestMethod]
    public void D2024()
        => _converter.TestFromTo(2024, "二千零二十四");

    [TestMethod]
    public void D1_0000()
        => _converter.TestFromTo(1_0000, "一万");

    [TestMethod]
    public void D11_000()
        => _converter.TestFromTo(11_000, "一万一千");

    [TestMethod]
    public void D1_8000()
        => _converter.TestFromTo(1_8000, "一万八千");

    [TestMethod]
    public void D3_1240()
         => _converter.TestFromTo(3_1240, "三万一千二百四十");

    [TestMethod]
    public void D3_4054()
        => _converter.TestFromTo(3_4054, "三万四千零五十四");

    [TestMethod]
    public void D3_4354()
        => _converter.TestFromTo(3_4354, "三万四千三百五十四");

    [TestMethod]
    public void D4_0005()
      => _converter.TestFromTo(4_0005, "四万零五");

    [TestMethod]
    public void D4_0050()
        => _converter.TestFromTo(4_0050, "四万零五十");

    [TestMethod]
    public void D4_0500()
         => _converter.TestFromTo(4_0500, "四万零五百");

    [TestMethod]
    public void D4_5000()
         => _converter.TestFromTo(4_5000, "四万五千");

    [TestMethod]
    public void D1_0000_0000()
        => _converter.TestFromTo(1_0000_0000, "一亿");

    [TestMethod]
    public void D1_0000_0001()
        => _converter.TestFromTo(1_0000_0001, "一亿零一");

    [TestMethod]
    public void D1_0000_0234()
        => _converter.TestFromTo(1_0000_0234, "一亿零二百三十四");

    [TestMethod]
    public void D1_0000_1234()
        => _converter.TestFromTo(1_0000_1234, "一亿零一千二百三十四");

    [TestMethod]
    public void D567_1890()
        => _converter.TestFromTo(567_1890, "五百六十七万一千八百九十");

    [TestMethod]
    public void D956_4435()
        => _converter.TestFromTo(956_4435, "九百五十六万四千四百三十五");

    [TestMethod]
    public void D3_045_6720()
        => _converter.TestFromTo(3_045_6720, "三千零四十五万六千七百二十");

    [TestMethod]
    public void D2_0008_0000()
        => _converter.TestFromTo(2_0008_0000, "二亿零八万");

    [TestMethod]
    public void D2_0080_0000()
        => _converter.TestFromTo(2_0080_0000, "二亿零八十万");

    [TestMethod]
    public void D2_0018_00000()
        => _converter.TestFromTo(2_0018_00000, "二十亿零一百八十万");

    [TestMethod]
    public void D24_0036_0899()
        => _converter.TestFromTo(24_0036_0899, "二十四亿零三十六万零八百九十九");

    [TestMethod]
    public void D2_0080_0000_alternate()
        => _converter.TestTo("两亿零八十万", 2_0080_0000);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D1_0000_0000_1_0000_0000()
         => _ = _converter.ToULong("一亿一亿");

    [TestMethod]
    public void D1_0000_0000_0000()
        => _converter.TestFromTo(1_0000_0000_0000, "一兆");

    [TestMethod]
    public void D1_0000_0000_0001()
        => _converter.TestFromTo(1_0000_0000_0001, "一兆零一");

    [TestMethod]
    public void D1_0000_0000_0000_0000()
        => _converter.TestFromTo(1_0000_0000_0000_0000, "一京");

    [TestMethod]
    public void D1_0000_0000_0000_0001()
        => _converter.TestFromTo(1_0000_0000_0000_0001, "一京零一");

    [TestMethod]
    public void D1_0001_0001_0001_0001()
        => _converter.TestFromTo(1_0001_0001_0001_0001, "一京零一兆零一亿零一万零一");

    [TestMethod]
    public void D1844_6744_0737_0955_1614()
        => _converter.TestFromTo(1844_6744_0737_0955_1614, "一千八百四十四京六千七百四十四兆零七百三十七亿零九百五十五万一千六百一十四");

    [TestMethod]
    public void D1844_6744_0737_0955_1615()
         => _converter.TestFromTo(1844_6744_0737_0955_1615, "一千八百四十四京六千七百四十四兆零七百三十七亿零九百五十五万一千六百一十五");

    [TestMethod]
    [ExpectedException(typeof(OverflowException))]
    public void D1844_6744_0737_0955_1616()
         => _ = _converter.ToULong("一千八百四十四京六千七百四十四兆零七百三十七亿零九百五十五万一千六百一十六");

    [TestMethod]
    [ExpectedException(typeof(OverflowException))]
    public void D1_0000_0000_0000_0000_0000()
        => _ = _converter.ToULong("一垓");

    [TestMethod]
    public void D40_0000_0000()
        => _converter.TestFromTo(40_0000_0000, "四十亿");

    [TestMethod]
    public void D42_9496_7295()
        => _converter.TestFromTo(uint.MaxValue, "四十二亿九千四百九十六万七千二百九十五");

    [TestMethod]
    public void D42_9496_7296()
        => _converter.TestFromTo(42_9496_7296, "四十二亿九千四百九十六万七千二百九十六");

    [TestMethod]
    public void D50_0000_0000()
        => _converter.TestFromTo(50_0000_0000, "五十亿");

    [TestMethod]
    public void D2222()
        => _converter.TestFromTo(2222, "二千二百二十二");

    [TestMethod]
    public void D2222_alternate()
        => _converter.TestTo("兩千二百二十二", 2222);

    [TestMethod]
    public void D2222_alternate2()
        => _converter.TestTo("兩千兩百二十二", 2222);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D10_invalid()
        => _ = _converter.ToULong("呀");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D110_invalid()
        => _ = _converter.ToULong("一百呀");

    [TestMethod]
    public void D111_alternate()
        => _converter.TestTo("一百呀一", 111);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D40_invalid()
        => _ = _converter.ToULong("卌");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D140_invalid()
        => _ = _converter.ToULong("一百卌");

    [TestMethod]
    public void D141()
        => _converter.TestTo("一百卌一", 141);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D20_20_invalid()
        => _ = _converter.ToULong("念廿");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D20_20_invalid2()
        => _ = _converter.ToULong("念二十");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D20_20_invalid3()
        => _ = _converter.ToULong("二十二十");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D20_20_invalid4()
        => _ = _converter.ToULong("念念");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D100_100_invalid()
        => _ = _converter.ToULong("一百一百");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D10_20_invalid()
        => _ = _converter.ToULong("呀廿");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D1000_10000_invalid()
        => _ = _converter.ToULong("一千一千");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D10_000_10_0000_invalid()
        => _ = _converter.ToULong("一万一万");

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void InputNull()
        => _ = _converter.ToULong(null!);

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void InputEmpty()
        => _ = _converter.ToULong("");

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void InputWhitespace()
        => _ = _converter.ToULong(" ");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void InputInvalid()
        => _ = _converter.ToULong("A");

    [TestMethod]
    public void D200_special()
        => _converter.TestTo("皕", 200);

    [TestMethod]
    public void D222_special()
         => _converter.TestTo("皕念两", 222);

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D0_0_invalid()
        => _ = _converter.ToULong("零零");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D0_0_invalid2()
        => _ = _converter.ToULong("零空");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D0_0_invalid3()
        => _ = _converter.ToULong("一百零零一");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D0_0_invalid4()
        => _ = _converter.ToULong("一百零空一");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D1_1_invalid4()
        => _ = _converter.ToULong("一一");

    [TestMethod]
    [ExpectedException(typeof(InvalidInputException))]
    public void D1_200_invalid()
        => _ = _converter.ToULong("一皕");

    [TestMethod]
    public void OrdinaryToFinancial1234()
    {
        var stringResult = _converter.Convert("一千二百三十四", new FinancialSimplifiedNumeralConverter());

        Assert.AreEqual("壹仟贰佰叁拾肆", stringResult);
    }

    [TestMethod]
    public void OrdinaryToFinancial2024()
    {
        var stringResult = _converter.Convert("二千零二十四", new FinancialSimplifiedNumeralConverter());

        Assert.AreEqual("贰仟零贰拾肆", stringResult);
    }
}