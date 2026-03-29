namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Character set for Common Traditional Chinese number system.
/// Provides traditional forms: 萬 (wàn) and 億 (yì).
/// </summary>
public sealed class ChineseCommonTraditionalNumeralCharacters : ChineseCommonNumeralCharactersBase
{
    /// <inheritdoc/>
    public override char C1_0000
        => ChineseCommonTraditionalCharacterConstants.Wan;

    /// <inheritdoc/>
    public override char C1_0000_0000
        => ChineseCommonTraditionalCharacterConstants.Yi;
}