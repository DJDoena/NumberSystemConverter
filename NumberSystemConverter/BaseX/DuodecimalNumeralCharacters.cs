namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Characters used in the duodecimal (base-12) number system.
/// All characters are used for both input (<see cref="INumberSystemConverter.ToULong"/>) and output (<see cref="INumberSystemConverter.FromULong"/>).
/// </summary>
public static class DuodecimalNumeralCharacters
{
    /// <summary>
    /// Digit 0 in duodecimal.
    /// <para>Value: 0</para>
    /// <para>Unicode: U+0030</para>
    /// </summary>
    public const char Zero = '0';

    /// <summary>
    /// Digit 1 in duodecimal.
    /// <para>Value: 1</para>
    /// <para>Unicode: U+0031</para>
    /// </summary>
    public const char One = '1';

    /// <summary>
    /// Digit 2 in duodecimal.
    /// <para>Value: 2</para>
    /// <para>Unicode: U+0032</para>
    /// </summary>
    public const char Two = '2';

    /// <summary>
    /// Digit 3 in duodecimal.
    /// <para>Value: 3</para>
    /// <para>Unicode: U+0033</para>
    /// </summary>
    public const char Three = '3';

    /// <summary>
    /// Digit 4 in duodecimal.
    /// <para>Value: 4</para>
    /// <para>Unicode: U+0034</para>
    /// </summary>
    public const char Four = '4';

    /// <summary>
    /// Digit 5 in duodecimal.
    /// <para>Value: 5</para>
    /// <para>Unicode: U+0035</para>
    /// </summary>
    public const char Five = '5';

    /// <summary>
    /// Digit 6 in duodecimal.
    /// <para>Value: 6</para>
    /// <para>Unicode: U+0036</para>
    /// </summary>
    public const char Six = '6';

    /// <summary>
    /// Digit 7 in duodecimal.
    /// <para>Value: 7</para>
    /// <para>Unicode: U+0037</para>
    /// </summary>
    public const char Seven = '7';

    /// <summary>
    /// Digit 8 in duodecimal.
    /// <para>Value: 8</para>
    /// <para>Unicode: U+0038</para>
    /// </summary>
    public const char Eight = '8';

    /// <summary>
    /// Digit 9 in duodecimal.
    /// <para>Value: 9</para>
    /// <para>Unicode: U+0039</para>
    /// </summary>
    public const char Nine = '9';

    /// <summary>
    /// Digit for 10 (ten) in duodecimal, pronounced "dek".
    /// <para>Value: 10</para>
    /// <para>Unicode: U+218A</para>
    /// </summary>
    public const char Ten = '↊';

    /// <summary>
    /// Digit for 11 (eleven) in duodecimal, pronounced "el".
    /// <para>Value: 11</para>
    /// <para>Unicode: U+218B</para>
    /// </summary>
    public const char Eleven = '↋';
}
