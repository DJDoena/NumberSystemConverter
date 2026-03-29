namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Converter for duodecimal (base-12) number system using ↊ (ten) and ↋ (eleven).
/// </summary>
public sealed class DuodecimalConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    /// <inheritdoc/>
    protected override char[] ValidCharacters
        => _validCharacters ??=
        [
            DuodecimalNumeralCharacters.Zero,
            DuodecimalNumeralCharacters.One,
            DuodecimalNumeralCharacters.Two,
            DuodecimalNumeralCharacters.Three,
            DuodecimalNumeralCharacters.Four,
            DuodecimalNumeralCharacters.Five,
            DuodecimalNumeralCharacters.Six,
            DuodecimalNumeralCharacters.Seven,
            DuodecimalNumeralCharacters.Eight,
            DuodecimalNumeralCharacters.Nine,
            DuodecimalNumeralCharacters.Ten,
            DuodecimalNumeralCharacters.Eleven
        ];
}