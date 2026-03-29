namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Character set for Financial Simplified Chinese number system.
/// Provides simplified financial characters.
/// </summary>
public sealed class ChineseFinancialSimplifiedNumeralCharacters : ChineseNumeralCharactersBase
{
    /// <inheritdoc/>
    public override char[] SingleDigits
        =>
        [
            ChineseFinancialSimplifiedCharacterConstants.Zero,
            ChineseFinancialSimplifiedCharacterConstants.One,
            ChineseFinancialSimplifiedCharacterConstants.Two,
            ChineseFinancialSimplifiedCharacterConstants.Three,
            ChineseFinancialSimplifiedCharacterConstants.Four,
            ChineseFinancialSimplifiedCharacterConstants.Five,
            ChineseFinancialSimplifiedCharacterConstants.Six,
            ChineseFinancialSimplifiedCharacterConstants.Seven,
            ChineseFinancialSimplifiedCharacterConstants.Eight,
            ChineseFinancialSimplifiedCharacterConstants.Nine
        ];

    /// <inheritdoc/>
    public override char C10
        => ChineseFinancialSimplifiedCharacterConstants.Ten;

    /// <inheritdoc/>
    public override char C100
        => ChineseFinancialSimplifiedCharacterConstants.Hundred;

    /// <inheritdoc/>
    public override char C1000
        => ChineseFinancialSimplifiedCharacterConstants.Thousand;

    /// <inheritdoc/>
    public override char C1_0000
        => ChineseFinancialSimplifiedCharacterConstants.Wan;

    /// <inheritdoc/>
    public override char C1_0000_0000
        => ChineseFinancialSimplifiedCharacterConstants.Yi;
}