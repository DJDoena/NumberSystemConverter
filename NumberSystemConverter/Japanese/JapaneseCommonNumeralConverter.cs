namespace DoenaSoft.NumberSystemConverter.Japanese;

/// <summary>
/// Converter for Common Japanese number system.
/// Uses regular characters: 零, 一, 二, 三, 四, 五, 六, 七, 八, 九.
/// </summary>
public sealed class JapaneseCommonNumeralConverter
    : JapaneseNumeralConverterBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JapaneseCommonNumeralConverter"/> class.
    /// </summary>
    public JapaneseCommonNumeralConverter() : base(new JapaneseCommonNumeralCharacters())
    {
    }
}