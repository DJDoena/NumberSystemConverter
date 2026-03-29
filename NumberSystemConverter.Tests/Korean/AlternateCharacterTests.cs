using DoenaSoft.NumberSystemConverter.Korean;

namespace DoenaSoft.NumberSystemConverter.Tests.Korean;

/// <summary>
/// Tests for alternate character support in Korean converters.
/// Multiple characters can represent the same value when converting TO decimal,
/// but only the primary character is used when converting FROM decimal.
/// </summary>
[TestClass]
public sealed class AlternateCharacterTests
{
    [TestMethod]
    public void Hangul_AlternateZero_Gong()
    {
        // Primary: 영
        var converter = new KoreanHangulNumeralConverter();
        
        // FROM decimal always uses primary
        var result = converter.FromULong(0);
        Assert.AreEqual("영", result);

        // TO decimal accepts alternate 공
        var number = converter.ToULong("공");
        Assert.AreEqual(0UL, number);
    }

    [TestMethod]
    public void Hanja_AlternateZero_Circle()
    {
        // Primary: 零
        var converter = new KoreanHanjaNumeralConverter();
        
        // FROM decimal always uses primary
        var result = converter.FromULong(0);
        Assert.AreEqual("零", result);

        // TO decimal accepts alternate 〇
        var number = converter.ToULong("〇");
        Assert.AreEqual(0UL, number);
    }

    [TestMethod]
    public void Financial_AlternateZero_Circle()
    {
        // Primary: 零
        var converter = new KoreanFinancialNumeralConverter();
        
        // FROM decimal always uses primary
        var result = converter.FromULong(0);
        Assert.AreEqual("零", result);

        // TO decimal accepts alternate 〇
        var number = converter.ToULong("〇");
        Assert.AreEqual(0UL, number);
    }

    [TestMethod]
    public void Financial_Alternate1000_Qian()
    {
        // Primary: 仟
        var converter = new KoreanFinancialNumeralConverter();
        
        // FROM decimal always uses primary 仟
        var result = converter.FromULong(1000);
        Assert.AreEqual("仟", result);

        // TO decimal accepts alternate 阡
        var number = converter.ToULong("阡");
        Assert.AreEqual(1000UL, number);

        // Complex number with alternate 1000
        var complex = converter.ToULong("貳阡貳拾陸"); // 2026 with alternate 1000
        Assert.AreEqual(2026UL, complex);
    }

    [TestMethod]
    public void Hanja_Alternate10000_Wan()
    {
        // Primary: 만
        var converter = new KoreanHanjaNumeralConverter();
        
        // FROM decimal always uses 만
        var result = converter.FromULong(10000);
        Assert.AreEqual("一만", result);

        // TO decimal accepts alternate 万 (simplified)
        var number1 = converter.ToULong("一万");
        Assert.AreEqual(10000UL, number1);

        // TO decimal accepts alternate 萬 (traditional)
        var number2 = converter.ToULong("一萬");
        Assert.AreEqual(10000UL, number2);
    }

    [TestMethod]
    public void Financial_Alternate10000_Wan()
    {
        // Primary: 만
        var converter = new KoreanFinancialNumeralConverter();
        
        // FROM decimal always uses 만
        var result = converter.FromULong(10000);
        Assert.AreEqual("壹만", result);

        // TO decimal accepts alternate 万 (simplified)
        var number1 = converter.ToULong("壹万");
        Assert.AreEqual(10000UL, number1);

        // TO decimal accepts alternate 萬 (traditional)
        var number2 = converter.ToULong("壹萬");
        Assert.AreEqual(10000UL, number2);
    }

    [TestMethod]
    public void Hangul_ComplexNumber_WithAlternates()
    {
        var converter = new KoreanHangulNumeralConverter();
        
        // Mix of alternates in a complex number
        var number = converter.ToULong("이천공이십육"); // 2026 with 공 for zero
        Assert.AreEqual(2026UL, number);
    }

    [TestMethod]
    public void Financial_ComplexNumber_WithMultipleAlternates()
    {
        var converter = new KoreanFinancialNumeralConverter();

        // Mix of alternates: 阡 for 1000, 万 for 10000
        var number1 = converter.ToULong("貳万貳阡貳拾陸"); // 22026 with alternates
        Assert.AreEqual(22026UL, number1);

        // Traditional 萬
        var number2 = converter.ToULong("貳萬貳仟貳拾陸"); // 22026 with 萬
        Assert.AreEqual(22026UL, number2);

        // Circle zero
        var number3 = converter.ToULong("〇"); // Just zero
        Assert.AreEqual(0UL, number3);
    }

    [TestMethod]
    public void Hanja_Alternate_Trillion_Zhao()
    {
        // Primary: 조 (Korean pronunciation of 兆)
        var converter = new KoreanHanjaNumeralConverter();

        // FROM decimal always uses 조
        var result = converter.FromULong(1_0000_0000_0000);
        Assert.AreEqual("一조", result);

        // TO decimal accepts alternate 兆 (Chinese character)
        var number = converter.ToULong("一兆");
        Assert.AreEqual(1_0000_0000_0000UL, number);
    }

    [TestMethod]
    public void Financial_Alternate_Kyung_AllVariants()
    {
        // Primary: 경 (Korean pronunciation of 京)
        var converter = new KoreanFinancialNumeralConverter();

        // FROM decimal always uses 경
        var result = converter.FromULong(1_0000_0000_0000_0000);
        Assert.AreEqual("壹경", result);

        // TO decimal accepts 京 (Chinese character)
        var number1 = converter.ToULong("壹京");
        Assert.AreEqual(1_0000_0000_0000_0000UL, number1);
    }

    [TestMethod]
    public void Hanja_Alternate_Kyung_AllVariants()
    {
        // Primary: 경
        var converter = new KoreanHanjaNumeralConverter();

        // FROM decimal uses 경
        var result = converter.FromULong(1_0000_0000_0000_0000);
        Assert.AreEqual("一경", result);

        // TO decimal accepts 京 (Chinese character)
        var number = converter.ToULong("一京");
        Assert.AreEqual(1_0000_0000_0000_0000UL, number);
    }
}
