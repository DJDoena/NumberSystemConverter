namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Character set for Common Simplified Chinese number system.
/// Provides simplified forms: 万 (wàn) and 亿 (yì).
/// </summary>
public sealed class ChineseCommonSimplifiedNumeralCharacters : ChineseCommonNumeralCharactersBase
{
    /// <inheritdoc/>
    public override char C1_0000
        => ChineseCommonSimplifiedCharacterConstants.Wan;

    /// <inheritdoc/>
    public override char C1_0000_0000
        => ChineseCommonSimplifiedCharacterConstants.Yi;
}