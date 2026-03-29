namespace DoenaSoft.NumberSystemConverter.Japanese;

/// <summary>
/// Converter for Financial Japanese number system.
/// Uses complex financial characters: 零, 壱, 弐, 参 to prevent alteration in legal/banking documents.
/// </summary>
public sealed class JapaneseFinancialNumeralConverter
    : JapaneseNumeralConverterBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JapaneseFinancialNumeralConverter"/> class.
    /// </summary>
    public JapaneseFinancialNumeralConverter() : base(new JapaneseFinancialNumeralCharacters())
    {
    }
}