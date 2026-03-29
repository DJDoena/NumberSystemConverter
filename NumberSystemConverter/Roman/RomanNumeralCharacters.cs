namespace DoenaSoft.NumberSystemConverter.Roman;

/// <summary>
/// Characters used in the Roman numeral system.
/// All characters are used for both input (<see cref="INumberSystemConverter.ToULong"/>) and output (<see cref="INumberSystemConverter.FromULong"/>).
/// Roman numerals use subtractive notation (e.g., IV = 4, IX = 9, XL = 40, XC = 90, CD = 400, CM = 900).
/// </summary>
public static class RomanNumeralCharacters
{
    /// <summary>
    /// Roman numeral I.
    /// <para>Value: 1</para>
    /// <para>Unicode: U+0049</para>
    /// </summary>
    public const char One = 'I';

    /// <summary>
    /// Roman numeral V.
    /// <para>Value: 5</para>
    /// <para>Unicode: U+0056</para>
    /// </summary>
    public const char Five = 'V';

    /// <summary>
    /// Roman numeral X.
    /// <para>Value: 10</para>
    /// <para>Unicode: U+0058</para>
    /// </summary>
    public const char Ten = 'X';

    /// <summary>
    /// Roman numeral L.
    /// <para>Value: 50</para>
    /// <para>Unicode: U+004C</para>
    /// </summary>
    public const char Fifty = 'L';

    /// <summary>
    /// Roman numeral C.
    /// <para>Value: 100</para>
    /// <para>Unicode: U+0043</para>
    /// </summary>
    public const char Hundred = 'C';

    /// <summary>
    /// Roman numeral D.
    /// <para>Value: 500</para>
    /// <para>Unicode: U+0044</para>
    /// </summary>
    public const char FiveHundred = 'D';

    /// <summary>
    /// Roman numeral M.
    /// <para>Value: 1,000</para>
    /// <para>Unicode: U+004D</para>
    /// </summary>
    public const char Thousand = 'M';
}
