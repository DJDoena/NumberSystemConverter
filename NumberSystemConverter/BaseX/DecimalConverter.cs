namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Converter for decimal (base-10) number system.
/// </summary>
public sealed class DecimalConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    /// <inheritdoc/>
    protected override char[] ValidCharacters
        => _validCharacters ??=
        [
            DecimalNumeralCharacters.Zero,
            DecimalNumeralCharacters.One,
            DecimalNumeralCharacters.Two,
            DecimalNumeralCharacters.Three,
            DecimalNumeralCharacters.Four,
            DecimalNumeralCharacters.Five,
            DecimalNumeralCharacters.Six,
            DecimalNumeralCharacters.Seven,
            DecimalNumeralCharacters.Eight,
            DecimalNumeralCharacters.Nine
        ];
}