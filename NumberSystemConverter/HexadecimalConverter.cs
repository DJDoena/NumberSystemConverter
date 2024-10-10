namespace DoenaSoft.NumberSystemConverter;

public sealed class HexadecimalConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    protected override char[] ValidCharacters
        => _validCharacters ??= ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'];

    public override uint ToUInt(string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }

        var result = base.ToUInt(input.ToUpper());

        return result;
    }
}