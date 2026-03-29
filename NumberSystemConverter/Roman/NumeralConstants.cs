namespace DoenaSoft.NumberSystemConverter.Roman;

/// <summary>
/// Constants for Roman numeral values and characters.
/// </summary>
public static class NumeralConstants
{
    /// <summary>
    /// Decimal value 1.
    /// </summary>
    public const ushort D1 = 1;
    /// <summary>
    /// Decimal value 5.
    /// </summary>
    public const ushort D5 = 5;
    /// <summary>
    /// Decimal value 10.
    /// </summary>
    public const ushort D10 = 10;
    /// <summary>
    /// Decimal value 50.
    /// </summary>
    public const ushort D50 = 50;
    /// <summary>
    /// Decimal value 100.
    /// </summary>
    public const ushort D100 = 100;
    /// <summary>
    /// Decimal value 500.
    /// </summary>
    public const ushort D500 = 500;
    /// <summary>
    /// Decimal value 1,000.
    /// </summary>
    public const ushort D1000 = 1000;

    /// <summary>
    /// Roman character for 1 (I).
    /// </summary>
    public const char R1 = RomanNumeralCharacters.One;
    /// <summary>
    /// Roman character for 5 (V).
    /// </summary>
    public const char R5 = RomanNumeralCharacters.Five;
    /// <summary>
    /// Roman character for 10 (X).
    /// </summary>
    public const char R10 = RomanNumeralCharacters.Ten;
    /// <summary>
    /// Roman character for 50 (L).
    /// </summary>
    public const char R50 = RomanNumeralCharacters.Fifty;
    /// <summary>
    /// Roman character for 100 (C).
    /// </summary>
    public const char R100 = RomanNumeralCharacters.Hundred;
    /// <summary>
    /// Roman character for 500 (D).
    /// </summary>
    public const char R500 = RomanNumeralCharacters.FiveHundred;
    /// <summary>
    /// Roman character for 1,000 (M).
    /// </summary>
    public const char R1000 = RomanNumeralCharacters.Thousand;

    private static readonly Dictionary<char, ushort>? _numerals = new()
    {
        { R1, D1 },
        { R5, D5 },
        { R10, D10 },
        { R50, D50 },
        { R100, D100 },
        { R500, D500 },
        { R1000, D1000 },
    };

    /// <summary>
    /// Gets the numeric value for a Roman numeral character.
    /// </summary>
    /// <param name="numeral">The Roman numeral character.</param>
    /// <returns>The numeric value of the character.</returns>
    /// <exception cref="InvalidInputException">Thrown when the character is not a valid Roman numeral.</exception>
    public static ushort GetNumber(char numeral)
    {
        if (!_numerals!.TryGetValue(numeral, out var number))
        {
            throw new InvalidInputException($"'{numeral}' is not a roman numeral");
        }

        return number;
    }
}