namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Converter for Braille decimal number system.
/// Uses Braille patterns ⠚⠁⠃⠉⠙⠑⠋⠛⠓⠊ for digits 0-9.
/// </summary>
public sealed class BrailleDecimalConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    /// <inheritdoc/>
    protected override char[] ValidCharacters
        => _validCharacters ??=
        [
            BrailleNumeralCharacters.Zero,
            BrailleNumeralCharacters.One,
            BrailleNumeralCharacters.Two,
            BrailleNumeralCharacters.Three,
            BrailleNumeralCharacters.Four,
            BrailleNumeralCharacters.Five,
            BrailleNumeralCharacters.Six,
            BrailleNumeralCharacters.Seven,
            BrailleNumeralCharacters.Eight,
            BrailleNumeralCharacters.Nine
        ];
}