using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Japanese;

/// <summary>
/// Base class for Japanese numeral character sets.
/// Provides common implementation for large unit characters across all Japanese variants.
/// </summary>
public abstract class JapaneseNumeralCharacterBase : IEastAsia10p4NumeralCharacters
{
    /// <summary>
    /// Gets the array of single digit characters (0-9).
    /// </summary>
    public abstract char[] SingleDigits { get; }

    /// <summary>
    /// Gets the character for 10.
    /// </summary>
    public abstract char C10 { get; }

    /// <summary>
    /// Gets the character for 100.
    /// </summary>
    public abstract char C100 { get; }

    /// <summary>
    /// Gets the character for 1000.
    /// </summary>
    public abstract char C1000 { get; }

    /// <summary>
    /// Unit for 1,0000 (万, man) - ten thousand in Myriad system.
    /// <para>Value: 1,0000</para>
    /// </summary>
    public char C1_0000
        => JapaneseCommonCharacterConstants.Man;

    /// <summary>
    /// Unit for 1,0000,0000 (億, oku) - hundred million in Myriad system.
    /// <para>Value: 1,0000,0000</para>
    /// </summary>
    public char C1_0000_0000
        => JapaneseCommonCharacterConstants.Oku;

    /// <summary>
    /// Unit for 1,0000,0000,0000 (兆, chou) - trillion in Myriad system.
    /// <para>Value: 1,0000,0000,0000</para>
    /// </summary>
    public char C1_0000_0000_0000
        => JapaneseCommonCharacterConstants.Chou;

    /// <summary>
    /// Unit for 1,0000,0000,0000,0000 (京, kei) - ten quadrillion in Myriad system.
    /// <para>Value: 1,0000,0000,0000,0000</para>
    /// </summary>
    public char C1_0000_0000_0000_0000
        => JapaneseCommonCharacterConstants.Kei;

    /// <summary>
    /// Unit for 1,0000,0000,0000,0000,0000 (垓, gai) - hundred quadrillion in Myriad system.
    /// Exceeds ulong maximum value (2^64 - 1).
    /// <para>Value: 1,0000,0000,0000,0000,0000</para>
    /// </summary>
    public char C1_0000_0000_0000_0000_0000
        => '垓';
}