namespace DoenaSoft.NumberSystemConverter.Korean;

/// <summary>
/// Converter for Korean Financial Hanja number system.
/// Uses complex financial characters (壹, 貳, 參, etc.) to prevent alteration in legal/banking documents.
/// </summary>
public sealed class KoreanFinancialNumeralConverter : KoreanNumeralConverterBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KoreanFinancialNumeralConverter"/> class.
    /// </summary>
    public KoreanFinancialNumeralConverter() : base(new KoreanFinancialNumeralCharacters())
    {
    }
}
