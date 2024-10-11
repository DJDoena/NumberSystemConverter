namespace DoenaSoft.NumberSystemConverter.BaseX;

public sealed class BinaryConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    protected override char[] ValidCharacters
        => _validCharacters ??= ['0', '1'];
}