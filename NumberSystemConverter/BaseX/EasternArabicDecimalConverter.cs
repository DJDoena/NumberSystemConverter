namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Converter for Eastern Arabic (Arabic-Indic) decimal number system.
/// Uses numerals ٠-٩ common in Arabic-speaking countries.
/// </summary>
public sealed class EasternArabicDecimalConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    /// <inheritdoc/>
    protected override char[] ValidCharacters
        => _validCharacters ??=
        [
            EasternArabicNumeralCharacters.Zero,
            EasternArabicNumeralCharacters.One,
            EasternArabicNumeralCharacters.Two,
            EasternArabicNumeralCharacters.Three,
            EasternArabicNumeralCharacters.Four,
            EasternArabicNumeralCharacters.Five,
            EasternArabicNumeralCharacters.Six,
            EasternArabicNumeralCharacters.Seven,
            EasternArabicNumeralCharacters.Eight,
            EasternArabicNumeralCharacters.Nine
        ];
}