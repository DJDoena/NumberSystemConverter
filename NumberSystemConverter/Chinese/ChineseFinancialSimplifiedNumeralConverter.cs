namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Converter for Financial Simplified Chinese number system.
/// Uses simplified financial characters: 零, 壹, 贰, 叁, 肆, 伍, 陆, 柒, 捌, 玖.
/// </summary>
public sealed class ChineseFinancialSimplifiedNumeralConverter : ChineseNumeralConverterBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChineseFinancialSimplifiedNumeralConverter"/> class.
    /// </summary>
    public ChineseFinancialSimplifiedNumeralConverter()
        : base(new ChineseFinancialSimplifiedNumeralCharacters())
    {
    }
}