namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Converter for Persian (Farsi) decimal number system.
/// Uses numerals ۰-۹ common in Iran and Afghanistan.
/// </summary>
public sealed class PersianDecimalConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    /// <inheritdoc/>
    protected override char[] ValidCharacters
        => _validCharacters ??=
        [
            PersianNumeralCharacters.Zero,
            PersianNumeralCharacters.One,
            PersianNumeralCharacters.Two,
            PersianNumeralCharacters.Three,
            PersianNumeralCharacters.Four,
            PersianNumeralCharacters.Five,
            PersianNumeralCharacters.Six,
            PersianNumeralCharacters.Seven,
            PersianNumeralCharacters.Eight,
            PersianNumeralCharacters.Nine
        ];
}