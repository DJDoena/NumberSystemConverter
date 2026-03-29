namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Converter for Financial Traditional Chinese number system.
/// Uses traditional financial characters: 零, 壹, 貳, 參, 肆, 伍, 陸, 柒, 捌, 玖.
/// </summary>
public sealed class ChineseFinancialTraditionalNumeralConverter : ChineseNumeralConverterBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChineseFinancialTraditionalNumeralConverter"/> class.
    /// </summary>
    public ChineseFinancialTraditionalNumeralConverter()
        : base(new ChineseFinancialTraditionalNumeralCharacters())
    {
    }
}