using DoenaSoft.NumberSystemConverter.Chinese;

namespace DoenaSoft.NumberSystemConverter.Tests.Chinese;

/// <summary>
/// Tests for large unit alternate characters in Chinese converters.
/// According to Wikipedia, 经 and 經 are valid historical/regional alternates for 京 (10^16).
/// </summary>
[TestClass]
public sealed class LargeUnitAlternateTests
{
    [TestMethod]
    public void CommonSimplified_Kyung_Alternates()
    {
        // Primary: 京 (traditional)
        var converter = new ChineseCommonSimplifiedNumeralConverter();
        
        // FROM decimal uses primary 京
        var result = converter.FromULong(1_0000_0000_0000_0000);
        Assert.AreEqual("一京", result);

        // TO decimal accepts 京 (primary)
        var number0 = converter.ToULong("一京");
        Assert.AreEqual(1_0000_0000_0000_0000UL, number0);

        // TO decimal accepts 经 (simplified alternate)
        var number1 = converter.ToULong("一经");
        Assert.AreEqual(1_0000_0000_0000_0000UL, number1);

        // TO decimal accepts 經 (traditional variant)
        var number2 = converter.ToULong("一經");
        Assert.AreEqual(1_0000_0000_0000_0000UL, number2);
    }

    [TestMethod]
    public void FinancialSimplified_Kyung_AllVariants()
    {
        var converter = new ChineseFinancialSimplifiedNumeralConverter();
        
        // Primary output uses 京
        var result = converter.FromULong(1_0000_0000_0000_0000);
        Assert.AreEqual("壹京", result);

        // Accepts all three variants
        Assert.AreEqual(1_0000_0000_0000_0000UL, converter.ToULong("壹京"));
        Assert.AreEqual(1_0000_0000_0000_0000UL, converter.ToULong("壹经"));
        Assert.AreEqual(1_0000_0000_0000_0000UL, converter.ToULong("壹經"));
    }

    [TestMethod]
    public void CommonTraditional_Kyung_AllVariants()
    {
        var converter = new ChineseCommonTraditionalNumeralConverter();
        
        // Primary output uses 京
        var result = converter.FromULong(1_0000_0000_0000_0000);
        Assert.AreEqual("一京", result);

        // Accepts all variants
        Assert.AreEqual(1_0000_0000_0000_0000UL, converter.ToULong("一京"));
        Assert.AreEqual(1_0000_0000_0000_0000UL, converter.ToULong("一经"));
        Assert.AreEqual(1_0000_0000_0000_0000UL, converter.ToULong("一經"));
    }

    [TestMethod]
    public void FinancialTraditional_Kyung_AllVariants()
    {
        var converter = new ChineseFinancialTraditionalNumeralConverter();
        
        // Primary output uses 京
        var result = converter.FromULong(1_0000_0000_0000_0000);
        Assert.AreEqual("壹京", result);

        // Accepts all variants
        Assert.AreEqual(1_0000_0000_0000_0000UL, converter.ToULong("壹京"));
        Assert.AreEqual(1_0000_0000_0000_0000UL, converter.ToULong("壹经"));
        Assert.AreEqual(1_0000_0000_0000_0000UL, converter.ToULong("壹經"));
    }

    [TestMethod]
    public void ComplexNumber_WithKyungAlternates()
    {
        var converter = new ChineseCommonSimplifiedNumeralConverter();
        
        // Mix different 京 variants in complex number
        var number1 = converter.ToULong("二京五千");
        var number2 = converter.ToULong("二经五千");
        var number3 = converter.ToULong("二經五千");
        
        // All should parse to same value
        Assert.AreEqual(number1, number2);
        Assert.AreEqual(number2, number3);
        Assert.AreEqual(2_0000_0000_0000_5000UL, number1);
    }

    [TestMethod]
    public void RoundTrip_WithKyungAlternates()
    {
        var converter = new ChineseFinancialSimplifiedNumeralConverter();
        
        // Parse with alternates, verify conversion back uses primary
        var value1 = converter.ToULong("壹经");  // Using 经
        var value2 = converter.ToULong("壹經");  // Using 經
        
        Assert.AreEqual(1_0000_0000_0000_0000UL, value1);
        Assert.AreEqual(1_0000_0000_0000_0000UL, value2);
        
        // But FromULong always returns 京
        var back = converter.FromULong(value1);
        Assert.AreEqual("壹京", back); // Not 经 or 經
    }
}
