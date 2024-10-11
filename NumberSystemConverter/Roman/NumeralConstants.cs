namespace DoenaSoft.NumberSystemConverter.Roman;

public static class NumeralConstants
{
    private static readonly Dictionary<char, ushort>? _numerals;

    public const ushort D1 = 1;
    public const ushort D5 = 5;
    public const ushort D10 = 10;
    public const ushort D50 = 50;
    public const ushort D100 = 100;
    public const ushort D500 = 500;
    public const ushort D1000 = 1000;

    public const char R1 = 'I';
    public const char R5 = 'V';
    public const char R10 = 'X';
    public const char R50 = 'L';
    public const char R100 = 'C';
    public const char R500 = 'D';
    public const char R1000 = 'M';

    static NumeralConstants()
    {
        _numerals = new()
        {
            { R1, D1 },
            { R5, D5 },
            { R10, D10 },
            { R50, D50 },
            { R100, D100 },
            { R500, D500 },
            { R1000, D1000 },
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