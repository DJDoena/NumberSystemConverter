namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Converter for binary (base-2) number system.
/// </summary>
public sealed class BinaryConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    /// <inheritdoc/>
    protected override char[] ValidCharacters
        => _validCharacters ??= [BinaryNumeralCharacters.Zero, BinaryNumeralCharacters.One];
}