namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Character set for Financial Traditional Chinese number system.
/// Provides traditional financial characters.
/// </summary>
public sealed class ChineseFinancialTraditionalNumeralCharacters : ChineseNumeralCharactersBase
{
    /// <inheritdoc/>
    public override char[] SingleDigits
        =>
        [
            ChineseFinancialTraditionalCharacterConstants.Zero,
            ChineseFinancialTraditionalCharacterConstants.One,
            ChineseFinancialTraditionalCharacterConstants.Two,
            ChineseFinancialTraditionalCharacterConstants.Three,
            ChineseFinancialTraditionalCharacterConstants.Four,
            ChineseFinancialTraditionalCharacterConstants.Five,
            ChineseFinancialTraditionalCharacterConstants.Six,
            ChineseFinancialTraditionalCharacterConstants.Seven,
            ChineseFinancialTraditionalCharacterConstants.Eight,
            ChineseFinancialTraditionalCharacterConstants.Nine
        ];

    /// <inheritdoc/>
    public override char C10
        => ChineseFinancialTraditionalCharacterConstants.Ten;

    /// <inheritdoc/>
    public override char C100
        => ChineseFinancialTraditionalCharacterConstants.Hundred;

    /// <inheritdoc/>
    public override char C1000
        => ChineseFinancialTraditionalCharacterConstants.Thousand;

    /// <inheritdoc/>
    public override char C1_0000
        => ChineseFinancialTraditionalCharacterConstants.Wan;

    /// <inheritdoc/>
    public override char C1_0000_0000
        => ChineseFinancialTraditionalCharacterConstants.Yi;
}