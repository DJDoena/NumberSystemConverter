namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Characters used in the binary (base-2) number system.
/// All characters are used for both input (<see cref="INumberSystemConverter.ToULong"/>) and output (<see cref="INumberSystemConverter.FromULong"/>).
/// </summary>
public static class BinaryNumeralCharacters
{
    /// <summary>
    /// Digit 0 in binary.
    /// <para>Value: 0</para>
    /// <para>Unicode: U+0030</para>
    /// </summary>
    public const char Zero = '0';

    /// <summary>
    /// Digit 1 in binary.
    /// <para>Value: 1</para>
    /// <para>Unicode: U+0031</para>
    /// </summary>
    public const char One = '1';
}
