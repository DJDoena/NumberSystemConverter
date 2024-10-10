namespace DoenaSoft.NumberSystemConverter.Roman;

public static class NumeralConstants
{
    private static readonly Dictionary<char, ushort>? _numerals;

    public const ushort One = 1;
    public const ushort Five = 5;
    public const ushort Ten = 10;
    public const ushort Fifty = 50;
    public const ushort OneHundred = 100;
    public const ushort FiveHundred = 500;
    public const ushort OneThousand = 1000;

    public const char I = 'I';
    public const char V = 'V';
    public const char X = 'X';
    public const char L = 'L';
    public const char C = 'C';
    public const char D = 'D';
    public const char M = 'M';

    static NumeralConstants()
    {
        _numerals = new(7)
        {
            { I, One },
            { V, Five },
            { X, Ten },
            { L, Fifty },
            { C, OneHundred },
            { D, FiveHundred },
            { M, OneThousand },
        };
    }

    public static ushort GetNumber(char numeral)
    {
        if (!_numerals!.TryGetValue(numeral, out var number))
        {
            throw new InvalidInputException($"'{numeral}' is not a roman numeral");
        }

        return number;
    }
}