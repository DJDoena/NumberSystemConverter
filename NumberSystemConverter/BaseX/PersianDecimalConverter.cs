namespace DoenaSoft.NumberSystemConverter.BaseX;

public sealed class PersianDecimalConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    protected override char[] ValidCharacters
        => _validCharacters ??= ['\u06F0', '\u06F1', '\u06F2', '\u06F3', '\u06F4', '\u06F5', '\u06F6', '\u06F7', '\u06F8', '\u06F9'];
}