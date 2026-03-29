using DoenaSoft.NumberSystemConverter.Chinese;
using DoenaSoft.NumberSystemConverter.Japanese;
using DoenaSoft.NumberSystemConverter.Korean;

namespace DoenaSoft.NumberSystemConverter.Tests;

/// <summary>
/// Tests to verify how Korean, Chinese, and Japanese number systems handle zeros.
/// </summary>
[TestClass]
public sealed class ZeroHandlingComparisonTests
{
    /// <summary>
    /// Test number 1010: Has a zero in the hundreds place
    /// Chinese: Uses 零 (ling) to represent the missing hundreds
    /// Japanese: Omits the zero entirely
    /// Korean: All variants follow the Japanese pattern - omit the zero
    /// </summary>
    [TestMethod]
    public void D1010_ZeroInHundreds()
    {
        // Chinese includes zero
        var chineseConverter = new ChineseCommonSimplifiedNumeralConverter();
        var chineseResult = chineseConverter.FromULong(1010);
        Assert.AreEqual("一千零一十", chineseResult); // includes 零

        // Japanese omits zero
        var japaneseConverter = new JapaneseCommonNumeralConverter();
        var japaneseResult = japaneseConverter.FromULong(1010);
        Assert.AreEqual("千十", japaneseResult); // no zero

        // Korean Hangul follows Japanese pattern
        var koreanHangulConverter = new KoreanHangulNumeralConverter();
        var koreanHangulResult = koreanHangulConverter.FromULong(1010);
        Assert.AreEqual("천십", koreanHangulResult); // no zero

        // Korean Hanja follows Japanese pattern
        var koreanHanjaConverter = new KoreanHanjaNumeralConverter();
        var koreanHanjaResult = koreanHanjaConverter.FromULong(1010);
        Assert.AreEqual("千十", koreanHanjaResult); // no zero

        // Korean Financial follows Japanese pattern
        var koreanFinancialConverter = new KoreanFinancialNumeralConverter();
        var koreanFinancialResult = koreanFinancialConverter.FromULong(1010);
        Assert.AreEqual("仟拾", koreanFinancialResult); // no zero
    }

    /// <summary>
    /// Test number 2026: Has a zero in the hundreds place
    /// Chinese: Uses 零 to represent missing hundreds
    /// Japanese: Omits the zero
    /// Korean: All variants follow the Japanese pattern - omit the zero
    /// </summary>
    [TestMethod]
    public void D2026_ZeroInHundreds()
    {
        // Chinese includes zero
        var chineseConverter = new ChineseCommonSimplifiedNumeralConverter();
        var chineseResult = chineseConverter.FromULong(2026);
        Assert.AreEqual("二千零二十六", chineseResult); // includes 零

        // Japanese omits zero
        var japaneseConverter = new JapaneseCommonNumeralConverter();
        var japaneseResult = japaneseConverter.FromULong(2026);
        Assert.AreEqual("二千二十六", japaneseResult); // no zero

        // Korean Hangul follows Japanese pattern
        var koreanHangulConverter = new KoreanHangulNumeralConverter();
        var koreanHangulResult = koreanHangulConverter.FromULong(2026);
        Assert.AreEqual("이천이십육", koreanHangulResult); // no zero

        // Korean Hanja follows Japanese pattern
        var koreanHanjaConverter = new KoreanHanjaNumeralConverter();
        var koreanHanjaResult = koreanHanjaConverter.FromULong(2026);
        Assert.AreEqual("二千二十六", koreanHanjaResult); // no zero

        // Korean Financial follows Japanese pattern
        var koreanFinancialConverter = new KoreanFinancialNumeralConverter();
        var koreanFinancialResult = koreanFinancialConverter.FromULong(2026);
        Assert.AreEqual("貳仟貳拾陸", koreanFinancialResult); // no zero
    }

    /// <summary>
    /// Test number 40005: Multiple zeros
    /// Chinese: Uses 零 once for consecutive missing places
    /// Japanese: Omits all zeros
    /// Korean: All variants follow the Japanese pattern - omit all zeros
    /// </summary>
    [TestMethod]
    public void D40005_MultipleZeros()
    {
        // Chinese includes zero for missing places
        var chineseConverter = new ChineseCommonSimplifiedNumeralConverter();
        var chineseResult = chineseConverter.FromULong(40005);
        Assert.AreEqual("四万零五", chineseResult); // includes 零

        // Japanese omits zeros
        var japaneseConverter = new JapaneseCommonNumeralConverter();
        var japaneseResult = japaneseConverter.FromULong(40005);
        Assert.AreEqual("四万五", japaneseResult); // no zero

        // Korean Hangul follows Japanese pattern
        var koreanHangulConverter = new KoreanHangulNumeralConverter();
        var koreanHangulResult = koreanHangulConverter.FromULong(40005);
        Assert.AreEqual("사만오", koreanHangulResult); // no zero

        // Korean Hanja follows Japanese pattern
        var koreanHanjaConverter = new KoreanHanjaNumeralConverter();
        var koreanHanjaResult = koreanHanjaConverter.FromULong(40005);
        Assert.AreEqual("四만五", koreanHanjaResult); // no zero

        // Korean Financial follows Japanese pattern
        var koreanFinancialConverter = new KoreanFinancialNumeralConverter();
        var koreanFinancialResult = koreanFinancialConverter.FromULong(40005);
        Assert.AreEqual("肆만伍", koreanFinancialResult); // no zero
    }

    /// <summary>
    /// Test number 1001: Zero in tens and hundreds
    /// </summary>
    [TestMethod]
    public void D1001_ZeroInTensAndHundreds()
    {
        // Chinese includes zero
        var chineseConverter = new ChineseCommonSimplifiedNumeralConverter();
        var chineseResult = chineseConverter.FromULong(1001);
        Assert.AreEqual("一千零一", chineseResult); // includes 零

        // Japanese omits zero
        var japaneseConverter = new JapaneseCommonNumeralConverter();
        var japaneseResult = japaneseConverter.FromULong(1001);
        Assert.AreEqual("千一", japaneseResult); // no zero

        // Korean Hangul follows Japanese pattern
        var koreanHangulConverter = new KoreanHangulNumeralConverter();
        var koreanHangulResult = koreanHangulConverter.FromULong(1001);
        Assert.AreEqual("천일", koreanHangulResult); // no zero

        // Korean Hanja follows Japanese pattern
        var koreanHanjaConverter = new KoreanHanjaNumeralConverter();
        var koreanHanjaResult = koreanHanjaConverter.FromULong(1001);
        Assert.AreEqual("千一", koreanHanjaResult); // no zero

        // Korean Financial follows Japanese pattern
        var koreanFinancialConverter = new KoreanFinancialNumeralConverter();
        var koreanFinancialResult = koreanFinancialConverter.FromULong(1001);
        Assert.AreEqual("仟壹", koreanFinancialResult); // no zero
    }

    /// <summary>
    /// Test number 20026: 이만 이십육 (2 만 + 26)
    /// Tests larger numbers with 만 (10,000) unit
    /// </summary>
    [TestMethod]
    public void D20026_TwoManTwentySix()
    {
        // Korean Hangul
        var koreanHangulConverter = new KoreanHangulNumeralConverter();
        var koreanHangulResult = koreanHangulConverter.FromULong(20026);
        Assert.AreEqual("이만이십육", koreanHangulResult);

        // Korean Hanja
        var koreanHanjaConverter = new KoreanHanjaNumeralConverter();
        var koreanHanjaResult = koreanHanjaConverter.FromULong(20026);
        Assert.AreEqual("二만二十六", koreanHanjaResult);

        // Korean Financial
        var koreanFinancialConverter = new KoreanFinancialNumeralConverter();
        var koreanFinancialResult = koreanFinancialConverter.FromULong(20026);
        Assert.AreEqual("貳만貳拾陸", koreanFinancialResult);

        // Round-trip verification
        var roundTripHangul = koreanHangulConverter.ToULong("이만이십육");
        Assert.AreEqual(20026UL, roundTripHangul);

        var roundTripHanja = koreanHanjaConverter.ToULong("二만二十六");
        Assert.AreEqual(20026UL, roundTripHanja);

        var roundTripFinancial = koreanFinancialConverter.ToULong("貳만貳拾陸");
        Assert.AreEqual(20026UL, roundTripFinancial);
    }

    /// <summary>
    /// Test number 200026: 이십만 이십육 (20 만 + 26)
    /// Tests larger numbers with tens of 만
    /// </summary>
    [TestMethod]
    public void D200026_TwentyManTwentySix()
    {
        // Korean Hangul
        var koreanHangulConverter = new KoreanHangulNumeralConverter();
        var koreanHangulResult = koreanHangulConverter.FromULong(200026);
        Assert.AreEqual("이십만이십육", koreanHangulResult);

        // Korean Hanja
        var koreanHanjaConverter = new KoreanHanjaNumeralConverter();
        var koreanHanjaResult = koreanHanjaConverter.FromULong(200026);
        Assert.AreEqual("二十만二十六", koreanHanjaResult);

        // Korean Financial
        var koreanFinancialConverter = new KoreanFinancialNumeralConverter();
        var koreanFinancialResult = koreanFinancialConverter.FromULong(200026);
        Assert.AreEqual("貳拾만貳拾陸", koreanFinancialResult);

        // Round-trip verification
        var roundTripHangul = koreanHangulConverter.ToULong("이십만이십육");
        Assert.AreEqual(200026UL, roundTripHangul);

        var roundTripHanja = koreanHanjaConverter.ToULong("二十만二十六");
        Assert.AreEqual(200026UL, roundTripHanja);

        var roundTripFinancial = koreanFinancialConverter.ToULong("貳拾만貳拾陸");
        Assert.AreEqual(200026UL, roundTripFinancial);
    }

    /// <summary>
    /// Test number 2000026: 이백만 이십육 (200 만 + 26)
    /// Tests larger numbers with hundreds of 만
    /// </summary>
    [TestMethod]
    public void D2000026_TwoHundredManTwentySix()
    {
        // Korean Hangul
        var koreanHangulConverter = new KoreanHangulNumeralConverter();
        var koreanHangulResult = koreanHangulConverter.FromULong(2000026);
        Assert.AreEqual("이백만이십육", koreanHangulResult);

        // Korean Hanja
        var koreanHanjaConverter = new KoreanHanjaNumeralConverter();
        var koreanHanjaResult = koreanHanjaConverter.FromULong(2000026);
        Assert.AreEqual("二百만二十六", koreanHanjaResult);

        // Korean Financial
        var koreanFinancialConverter = new KoreanFinancialNumeralConverter();
        var koreanFinancialResult = koreanFinancialConverter.FromULong(2000026);
        Assert.AreEqual("貳佰만貳拾陸", koreanFinancialResult);

        // Round-trip verification
        var roundTripHangul = koreanHangulConverter.ToULong("이백만이십육");
        Assert.AreEqual(2000026UL, roundTripHangul);

        var roundTripHanja = koreanHanjaConverter.ToULong("二百만二十六");
        Assert.AreEqual(2000026UL, roundTripHanja);

        var roundTripFinancial = koreanFinancialConverter.ToULong("貳佰만貳拾陸");
        Assert.AreEqual(2000026UL, roundTripFinancial);
    }
}
