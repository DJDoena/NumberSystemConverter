﻿namespace DoenaSoft.NumberSystemConverter;

public sealed class DecimalConverter : BaseXConverterBase
{
    private static char[]? _validCharacters;

    protected override char[] ValidCharacters
        => _validCharacters ??= ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
}