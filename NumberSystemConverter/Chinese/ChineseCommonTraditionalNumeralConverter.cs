namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Converter for Common Traditional Chinese number system.
/// Uses traditional Chinese characters following Taiwan/Hong Kong standards.
/// </summary>
public sealed class ChineseCommonTraditionalNumeralConverter : ChineseNumeralConverterBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChineseCommonTraditionalNumeralConverter"/> class.
    /// </summary>
    public ChineseCommonTraditionalNumeralConverter()
        : base(new ChineseCommonTraditionalNumeralCharacters())
    {
    }
}