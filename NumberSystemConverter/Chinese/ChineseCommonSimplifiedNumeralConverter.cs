namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Converter for Common Simplified Chinese number system.
/// Uses simplified Chinese characters following PRC standards.
/// </summary>
public sealed class ChineseCommonSimplifiedNumeralConverter : ChineseNumeralConverterBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChineseCommonSimplifiedNumeralConverter"/> class.
    /// </summary>
    public ChineseCommonSimplifiedNumeralConverter()
        : base(new ChineseCommonSimplifiedNumeralCharacters())
    {
    }
}