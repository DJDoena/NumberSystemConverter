namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Characters used in the hexadecimal (base-16) number system.
/// All characters are used for both input (<see cref="INumberSystemConverter.ToULong"/>) and output (<see cref="INumberSystemConverter.FromULong"/>).
/// Note: Lowercase a-f are also accepted for input but uppercase A-F are always used for output.
/// </summary>
public static class HexadecimalNumeralCharacters
{
    /// <summary>
    /// Digit 0 in hexadecimal.
    /// <para>Value: 0</para>
    /// <para>Unicode: U+0030</para>
    /// </summary>
    public const char Zero = '0';

    /// <summary>
    /// Digit 1 in hexadecimal.
    /// <para>Value: 1</para>
    /// <para>Unicode: U+0031</para>
    /// </summary>
    public const char One = '1';

    /// <summary>
    /// Digit 2 in hexadecimal.
    /// <para>Value: 2</para>
    /// <para>Unicode: U+0032</para>
    /// </summary>
    public const char Two = '2';

    /// <summary>
    /// Digit 3 in hexadecimal.
    /// <para>Value: 3</para>
    /// <para>Unicode: U+0033</para>
    /// </summary>
    public const char Three = '3';

    /// <summary>
    /// Digit 4 in hexadecimal.
    /// <para>Value: 4</para>
    /// <para>Unicode: U+0034</para>
    /// </summary>
    public const char Four = '4';

    /// <summary>
    /// Digit 5 in hexadecimal.
    /// <para>Value: 5</para>
    /// <para>Unicode: U+0035</para>
    /// </summary>
    public const char Five = '5';

    /// <summary>
    /// Digit 6 in hexadecimal.
    /// <para>Value: 6</para>
    /// <para>Unicode: U+0036</para>
    /// </summary>
    public const char Six = '6';

    /// <summary>
    /// Digit 7 in hexadecimal.
    /// <para>Value: 7</para>
    /// <para>Unicode: U+0037</para>
    /// </summary>
    public const char Seven = '7';

    /// <summary>
    /// Digit 8 in hexadecimal.
    /// <para>Value: 8</para>
    /// <para>Unicode: U+0038</para>
    /// </summary>
    public const char Eight = '8';

    /// <summary>
    /// Digit 9 in hexadecimal.
    /// <para>Value: 9</para>
    /// <para>Unicode: U+0039</para>
    /// </summary>
    public const char Nine = '9';

    /// <summary>
    /// Digit A (10 in decimal) in hexadecimal.
    /// <para>Value: 10</para>
    /// <para>Unicode: U+0041</para>
    /// </summary>
    public const char Ten = 'A';

    /// <summary>
    /// Digit B (11 in decimal) in hexadecimal.
    /// <para>Value: 11</para>
    /// <para>Unicode: U+0042</para>
    /// </summary>
    public const char Eleven = 'B';

    /// <summary>
    /// Digit C (12 in decimal) in hexadecimal.
    /// <para>Value: 12</para>
    /// <para>Unicode: U+0043</para>
    /// </summary>
    public const char Twelve = 'C';

    /// <summary>
    /// Digit D (13 in decimal) in hexadecimal.
    /// <para>Value: 13</para>
    /// <para>Unicode: U+0044</para>
    /// </summary>
    public const char Thirteen = 'D';

    /// <summary>
    /// Digit E (14 in decimal) in hexadecimal.
    /// <para>Value: 14</para>
    /// <para>Unicode: U+0045</para>
    /// </summary>
    public const char Fourteen = 'E';

    /// <summary>
    /// Digit F (15 in decimal) in hexadecimal.
    /// <para>Value: 15</para>
    /// <para>Unicode: U+0046</para>
    /// </summary>
    public const char Fifteen = 'F';
}
