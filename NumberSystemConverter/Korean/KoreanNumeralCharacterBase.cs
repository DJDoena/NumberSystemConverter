using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Korean;

/// <summary>
/// Base class for Korean numeral character sets.
/// Provides common implementation for large unit characters across all Korean variants.
/// </summary>
/// <summary>
/// Base class for Korean numeral character sets.
/// Provides common implementation for large unit characters across all Korean variants.
/// </summary>
public abstract class KoreanNumeralCharacterBase : IEastAsia10p4NumeralCharacters
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
    /// Unit for 1,0000 (만, man) - ten thousand in Myriad system.
    /// <para>Value: 1,0000</para>
    /// </summary>
    public char C1_0000
        => KoreanHangulCharacterConstants.Man;

    /// <summary>
    /// Unit for 1,0000,0000 (억, eok) - hundred million in Myriad system.
    /// <para>Value: 1,0000,0000</para>
    /// </summary>
    public char C1_0000_0000
        => KoreanHangulCharacterConstants.Eok;

    /// <summary>
    /// Unit for 1,0000,0000,0000 (조, jo) - trillion in Myriad system.
    /// <para>Value: 1,0000,0000,0000</para>
    /// </summary>
    public char C1_0000_0000_0000
        => KoreanHangulCharacterConstants.Jo;

    /// <summary>
    /// Unit for 1,0000,0000,0000,0000 (경, gyeong) - ten quadrillion in Myriad system.
    /// <para>Value: 1,0000,0000,0000,0000</para>
    /// </summary>
    public char C1_0000_0000_0000_0000
        => KoreanHangulCharacterConstants.Gyeong;

    /// <summary>
    /// Unit for 1,0000,0000,0000,0000,0000 (해, hae) - hundred quadrillion in Myriad system.
    /// Exceeds ulong maximum value (2^64 - 1).
    /// <para>Value: 1,0000,0000,0000,0000,0000</para>
    /// </summary>
    public char C1_0000_0000_0000_0000_0000
        => '해';
}
