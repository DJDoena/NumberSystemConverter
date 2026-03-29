using DoenaSoft.NumberSystemConverter.BaseX;
using DoenaSoft.NumberSystemConverter.Chinese;
using DoenaSoft.NumberSystemConverter.Japanese;
using DoenaSoft.NumberSystemConverter.Korean;
using DoenaSoft.NumberSystemConverter.Roman;
using System.IO;

namespace DoenaSoft.NumberSystemConverter.Tests;

[TestClass]
public sealed class Year2026Tests
{
    private const ulong Year = 2026;
    private static readonly string OutputFile = Path.Combine(Path.GetTempPath(), "Year2026Results.txt");

    [ClassInitialize]
    public static void ClassInit(TestContext context)
    {
        if (File.Exists(OutputFile))
        {
            File.Delete(OutputFile);
        }
    }

    private static void LogResult(string name, string value)
    {
        var line = $"{name}: {value}";
        Console.WriteLine(line);
        File.AppendAllText(OutputFile, line + Environment.NewLine);
    }

    [TestMethod]
    public void Binary()
    {
        var converter = new BinaryConverter();
        var result = converter.FromULong(Year);
        LogResult("Binary FromULong", result);
        Assert.AreEqual("11111101010", result);
    }

    [TestMethod]
    public void BinaryRoundTrip()
    {
        var converter = new BinaryConverter();
        var numberResult = converter.ToULong("11111101010");
        LogResult("Binary ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void Octal()
    {
        var converter = new OctalConverter();
        var result = converter.FromULong(Year);
        LogResult("Octal FromULong", result);
        Assert.AreEqual("3752", result);
    }

    [TestMethod]
    public void OctalRoundTrip()
    {
        var converter = new OctalConverter();
        var numberResult = converter.ToULong("3752");
        LogResult("Octal ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void Decimal()
    {
        var converter = new DecimalConverter();
        var result = converter.FromULong(Year);
        LogResult("Decimal FromULong", result);
        Assert.AreEqual("2026", result);
    }

    [TestMethod]
    public void DecimalRoundTrip()
    {
        var converter = new DecimalConverter();
        var numberResult = converter.ToULong("2026");
        LogResult("Decimal ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void Duodecimal()
    {
        var converter = new DuodecimalConverter();
        var result = converter.FromULong(Year);
        LogResult("Duodecimal FromULong", result);
        Assert.AreEqual("120↊", result);
    }

    [TestMethod]
    public void DuodecimalRoundTrip()
    {
        var converter = new DuodecimalConverter();
        var numberResult = converter.ToULong("120↊");
        LogResult("Duodecimal ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void Hexadecimal()
    {
        var converter = new HexadecimalConverter();
        var result = converter.FromULong(Year);
        LogResult("Hexadecimal FromULong", result);
        Assert.AreEqual("7EA", result);
    }

    [TestMethod]
    public void HexadecimalRoundTrip()
    {
        var converter = new HexadecimalConverter();
        var numberResult = converter.ToULong("7EA");
        LogResult("Hexadecimal ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void ChineseSimplifiedCommon()
    {
        var converter = new CommonSimplifiedNumeralConverter();
        var result = converter.FromULong(Year);
        LogResult("Chinese Simplified Common FromULong", result);
        Assert.AreEqual("二千零二十六", result);
    }

    [TestMethod]
    public void ChineseSimplifiedCommonRoundTrip()
    {
        var converter = new CommonSimplifiedNumeralConverter();
        var numberResult = converter.ToULong("二千零二十六");
        LogResult("Chinese Simplified Common ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void ChineseSimplifiedFinancial()
    {
        var converter = new FinancialSimplifiedNumeralConverter();
        var result = converter.FromULong(Year);
        LogResult("Chinese Simplified Financial FromULong", result);
        Assert.AreEqual("贰仟零贰拾陆", result);
    }

    [TestMethod]
    public void ChineseSimplifiedFinancialRoundTrip()
    {
        var converter = new FinancialSimplifiedNumeralConverter();
        var numberResult = converter.ToULong("贰仟零贰拾陆");
        LogResult("Chinese Simplified Financial ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void ChineseTraditionalCommon()
    {
        var converter = new CommonTraditionalNumeralConverter();
        var result = converter.FromULong(Year);
        LogResult("Chinese Traditional Common FromULong", result);
        Assert.AreEqual("二千零二十六", result);
    }

    [TestMethod]
    public void ChineseTraditionalCommonRoundTrip()
    {
        var converter = new CommonTraditionalNumeralConverter();
        var numberResult = converter.ToULong("二千零二十六");
        LogResult("Chinese Traditional Common ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void ChineseTraditionalFinancial()
    {
        var converter = new FinancialTraditionalNumeralConverter();
        var result = converter.FromULong(Year);
        LogResult("Chinese Traditional Financial FromULong", result);
        Assert.AreEqual("貳仟零貳拾陸", result);
    }

    [TestMethod]
    public void ChineseTraditionalFinancialRoundTrip()
    {
        var converter = new FinancialTraditionalNumeralConverter();
        var numberResult = converter.ToULong("貳仟零貳拾陸");
        LogResult("Chinese Traditional Financial ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void JapaneseCommon()
    {
        var converter = new CommonNumeralConverter();
        var result = converter.FromULong(Year);
        LogResult("Japanese Common FromULong", result);
        Assert.AreEqual("二千二十六", result);
    }

    [TestMethod]
    public void JapaneseCommonRoundTrip()
    {
        var converter = new CommonNumeralConverter();
        var numberResult = converter.ToULong("二千二十六");
        LogResult("Japanese Common ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void JapaneseFinancial()
    {
        var converter = new FinancialNumeralConverter();
        var result = converter.FromULong(Year);
        LogResult("Japanese Financial FromULong", result);
        Assert.AreEqual("弐千弐拾六", result);
    }

    [TestMethod]
    public void JapaneseFinancialRoundTrip()
    {
        var converter = new FinancialNumeralConverter();
        var numberResult = converter.ToULong("弐千弐拾六");
        LogResult("Japanese Financial ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void KoreanHangul()
    {
        var converter = new HangulNumeralConverter();
        var result = converter.FromULong(Year);
        LogResult("Korean Hangul FromULong", result);
        Assert.AreEqual("이천이십육", result);
    }

    [TestMethod]
    public void KoreanHangulRoundTrip()
    {
        var converter = new HangulNumeralConverter();
        var numberResult = converter.ToULong("이천이십육");
        LogResult("Korean Hangul ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void KoreanHanja()
    {
        var converter = new HanjaKoreanNumeralConverter();
        var result = converter.FromULong(Year);
        LogResult("Korean Hanja FromULong", result);
        Assert.AreEqual("二千二十六", result);
    }

    [TestMethod]
    public void KoreanHanjaRoundTrip()
    {
        var converter = new HanjaKoreanNumeralConverter();
        var numberResult = converter.ToULong("二千二十六");
        LogResult("Korean Hanja ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void KoreanFinancial()
    {
        var converter = new FinancialKoreanNumeralConverter();
        var result = converter.FromULong(Year);
        LogResult("Korean Financial FromULong", result);
        Assert.AreEqual("貳仟貳拾陸", result);
    }

    [TestMethod]
    public void KoreanFinancialRoundTrip()
    {
        var converter = new FinancialKoreanNumeralConverter();
        var numberResult = converter.ToULong("貳仟貳拾陸");
        LogResult("Korean Financial ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void EasternArabic()
    {
        var converter = new EasternArabicDecimalConverter();
        var result = converter.FromULong(Year);
        LogResult("Eastern Arabic FromULong", result);
        Assert.AreEqual("٢٠٢٦", result);
    }

    [TestMethod]
    public void EasternArabicRoundTrip()
    {
        var converter = new EasternArabicDecimalConverter();
        var numberResult = converter.ToULong("٢٠٢٦");
        LogResult("Eastern Arabic ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void Persian()
    {
        var converter = new PersianDecimalConverter();
        var result = converter.FromULong(Year);
        LogResult("Persian FromULong", result);
        Assert.AreEqual("۲۰۲۶", result);
    }

    [TestMethod]
    public void PersianRoundTrip()
    {
        var converter = new PersianDecimalConverter();
        var numberResult = converter.ToULong("۲۰۲۶");
        LogResult("Persian ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void Braille()
    {
        var converter = new BrailleDecimalConverter();
        var result = converter.FromULong(Year);
        LogResult("Braille FromULong", result);
        Assert.AreEqual("⠃⠚⠃⠋", result);
    }

    [TestMethod]
    public void BrailleRoundTrip()
    {
        var converter = new BrailleDecimalConverter();
        var numberResult = converter.ToULong("⠃⠚⠃⠋");
        LogResult("Braille ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [TestMethod]
    public void Roman()
    {
        var converter = new NumeralConverter();
        var result = converter.FromULong(Year);
        LogResult("Roman FromULong", result);
        Assert.AreEqual("MMXXVI", result);
    }

    [TestMethod]
    public void RomanRoundTrip()
    {
        var converter = new NumeralConverter();
        var numberResult = converter.ToULong("MMXXVI");
        LogResult("Roman ToULong", numberResult.ToString());
        Assert.AreEqual(Year, numberResult);
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        Console.WriteLine($"Results saved to: {OutputFile}");
    }
}
