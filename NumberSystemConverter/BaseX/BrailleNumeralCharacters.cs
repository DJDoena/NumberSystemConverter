namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Characters used in the Braille decimal number system.
/// All characters are used for both input (<see cref="INumberSystemConverter.ToULong"/>) and output (<see cref="INumberSystemConverter.FromULong"/>).
/// Note: Braille digits use a special prefix pattern - the digits a-j represent 0-9 when preceded by the number sign.
/// </summary>
public static class BrailleNumeralCharacters
{
    /// <summary>
    /// Digit 0 in Braille (⠚ - letter j pattern).
    /// <para>Value: 0</para>
    /// <para>Unicode: U+281A</para>
    /// </summary>
    public const char Zero = '⠚';

    /// <summary>
    /// Digit 1 in Braille (⠁ - letter a pattern).
    /// <para>Value: 1</para>
    /// <para>Unicode: U+2801</para>
    /// </summary>
    public const char One = '⠁';

    /// <summary>
    /// Digit 2 in Braille (⠃ - letter b pattern).
    /// <para>Value: 2</para>
    /// <para>Unicode: U+2803</para>
    /// </summary>
    public const char Two = '⠃';

    /// <summary>
    /// Digit 3 in Braille (⠉ - letter c pattern).
    /// <para>Value: 3</para>
    /// <para>Unicode: U+2809</para>
    /// </summary>
    public const char Three = '⠉';

    /// <summary>
    /// Digit 4 in Braille (⠙ - letter d pattern).
    /// <para>Value: 4</para>
    /// <para>Unicode: U+2819</para>
    /// </summary>
    public const char Four = '⠙';

    /// <summary>
    /// Digit 5 in Braille (⠑ - letter e pattern).
    /// <para>Value: 5</para>
    /// <para>Unicode: U+2811</para>
    /// </summary>
    public const char Five = '⠑';

    /// <summary>
    /// Digit 6 in Braille (⠋ - letter f pattern).
    /// <para>Value: 6</para>
    /// <para>Unicode: U+280B</para>
    /// </summary>
    public const char Six = '⠋';

    /// <summary>
    /// Digit 7 in Braille (⠛ - letter g pattern).
    /// <para>Value: 7</para>
    /// <para>Unicode: U+281B</para>
    /// </summary>
    public const char Seven = '⠛';

    /// <summary>
    /// Digit 8 in Braille (⠓ - letter h pattern).
    /// <para>Value: 8</para>
    /// <para>Unicode: U+2813</para>
    /// </summary>
    public const char Eight = '⠓';

    /// <summary>
    /// Digit 9 in Braille (⠊ - letter i pattern).
    /// <para>Value: 9</para>
    /// <para>Unicode: U+280A</para>
    /// </summary>
    public const char Nine = '⠊';
}
