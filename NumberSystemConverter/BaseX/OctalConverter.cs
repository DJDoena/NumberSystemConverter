namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Converter for octal (base-8) number system.
/// </summary>
public sealed class OctalConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    /// <inheritdoc/>
    protected override char[] ValidCharacters
        => _validCharacters ??=
        [
            OctalNumeralCharacters.Zero,
            OctalNumeralCharacters.One,
            OctalNumeralCharacters.Two,
            OctalNumeralCharacters.Three,
            OctalNumeralCharacters.Four,
            OctalNumeralCharacters.Five,
            OctalNumeralCharacters.Six,
            OctalNumeralCharacters.Seven
        ];
}