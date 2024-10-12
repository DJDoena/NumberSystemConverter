namespace DoenaSoft.NumberSystemConverter.BaseX;

public sealed class EasternArabicDecimalConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    protected override char[] ValidCharacters
        => _validCharacters ??= ['\u0660', '\u0661', '\u0662', '\u0663', '\u0664', '\u0665', '\u0666', '\u0667', '\u0668', '\u0669'];
}