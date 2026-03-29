namespace DoenaSoft.NumberSystemConverter.EastAsia;

/// <summary>
/// Interface for East Asian numeral character sets that use the Myriad (10^4) system.
/// Defines characters for digits and units at powers of 10,000.
/// </summary>
public interface IEastAsia10p4NumeralCharacters
{
    /// <summary>
    /// Gets the array of single digit characters (0-9).
    /// </summary>
    char[] SingleDigits { get; }

    /// <summary>
    /// Gets the character for 10.
    /// </summary>
    char C10 { get; }

    /// <summary>
    /// Gets the character for 100.
    /// </summary>
    char C100 { get; }

    /// <summary>
    /// Gets the character for 1000.
    /// </summary>
    char C1000 { get; }

    /// <summary>
    /// Gets the character for 1,0000 (ten thousand in Myriad system).
    /// </summary>
    char C1_0000 { get; }

    /// <summary>
    /// Gets the character for 1,0000,0000 (hundred million in Myriad system).
    /// </summary>
    char C1_0000_0000 { get; }

    /// <summary>
    /// Gets the character for 1,0000,0000,0000 (trillion in Myriad system).
    /// </summary>
    char C1_0000_0000_0000 { get; }

    /// <summary>
    /// Gets the character for 1,0000,0000,0000,0000 (ten quadrillion in Myriad system).
    /// </summary>
    char C1_0000_0000_0000_0000 { get; }

    /// <summary>
    /// Gets the character for 1,0000,0000,0000,0000,0000 (hundred quadrillion in Myriad system).
    /// </summary>
    char C1_0000_0000_0000_0000_0000 { get; }
}