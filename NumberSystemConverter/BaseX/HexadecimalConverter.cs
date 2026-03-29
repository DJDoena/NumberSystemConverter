namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Converter for hexadecimal (base-16) number system.
/// Accepts both uppercase and lowercase letters (A-F, a-f) for input, outputs uppercase.
/// </summary>
public sealed class HexadecimalConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    /// <inheritdoc/>
    protected override char[] ValidCharacters
        => _validCharacters ??=
        [
            HexadecimalNumeralCharacters.Zero,
            HexadecimalNumeralCharacters.One,
            HexadecimalNumeralCharacters.Two,
            HexadecimalNumeralCharacters.Three,
            HexadecimalNumeralCharacters.Four,
            HexadecimalNumeralCharacters.Five,
            HexadecimalNumeralCharacters.Six,
            HexadecimalNumeralCharacters.Seven,
            HexadecimalNumeralCharacters.Eight,
            HexadecimalNumeralCharacters.Nine,
            HexadecimalNumeralCharacters.Ten,
            HexadecimalNumeralCharacters.Eleven,
            HexadecimalNumeralCharacters.Twelve,
            HexadecimalNumeralCharacters.Thirteen,
            HexadecimalNumeralCharacters.Fourteen,
            HexadecimalNumeralCharacters.Fifteen
        ];

    /// <inheritdoc/>
    public override ulong ToULong(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentNullException(nameof(input));
        }

        var result = base.ToULong(input.ToUpper());

        return result;
    }
}