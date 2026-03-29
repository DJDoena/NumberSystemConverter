using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Base class for Chinese numeral character sets.
/// Provides abstract definitions for all character positions.
/// </summary>
public abstract class ChineseNumeralCharactersBase : IEastAsia10p4NumeralCharacters
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
    /// Gets the character for 1,0000 (ten thousand).
    /// </summary>
    public abstract char C1_0000 { get; }

    /// <summary>
    /// Gets the character for 1,0000,0000 (hundred million).
    /// </summary>
    public abstract char C1_0000_0000 { get; }

    /// <summary>
    /// Unit for 1,0000,0000,0000 (兆, zhào) - trillion in Myriad system.
    /// <para>Value: 1,0000,0000,0000</para>
    /// </summary>
    public char C1_0000_0000_0000
        => ChineseCommonSimplifiedCharacterConstants.Zhao;

    /// <summary>
    /// Unit for 1,0000,0000,0000,0000 (京, jīng) - ten quadrillion in Myriad system.
    /// <para>Value: 1,0000,0000,0000,0000</para>
    /// </summary>
    public char C1_0000_0000_0000_0000
        => ChineseCommonSimplifiedCharacterConstants.Jing;

    /// <summary>
    /// Unit for 1,0000,0000,0000,0000,0000 (垓, gāi) - hundred quadrillion in Myriad system.
    /// Exceeds ulong maximum value (2^64 - 1).
    /// <para>Value: 1,0000,0000,0000,0000,0000</para>
    /// </summary>
    public char C1_0000_0000_0000_0000_0000
        => '垓';
}