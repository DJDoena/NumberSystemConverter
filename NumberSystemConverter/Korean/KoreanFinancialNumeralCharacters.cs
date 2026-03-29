namespace DoenaSoft.NumberSystemConverter.Korean;

/// <summary>
/// Character set for Korean Financial Hanja number system.
/// Provides financial Chinese characters for digits and units.
/// </summary>
public sealed class KoreanFinancialNumeralCharacters : KoreanNumeralCharacterBase
{
    /// <inheritdoc/>
    public override char[] SingleDigits
        =>
        [
            KoreanFinancialCharacterConstants.Zero,
            KoreanFinancialCharacterConstants.One,
            KoreanFinancialCharacterConstants.Two,
            KoreanFinancialCharacterConstants.Three,
            KoreanFinancialCharacterConstants.Four,
            KoreanFinancialCharacterConstants.Five,
            KoreanFinancialCharacterConstants.Six,
            KoreanFinancialCharacterConstants.Seven,
            KoreanFinancialCharacterConstants.Eight,
            KoreanFinancialCharacterConstants.Nine
        ];

    /// <inheritdoc/>
    public override char C10
        => KoreanFinancialCharacterConstants.Ten;

    /// <inheritdoc/>
    public override char C100
        => KoreanFinancialCharacterConstants.Hundred;

    /// <inheritdoc/>
    public override char C1000
        => KoreanFinancialCharacterConstants.Thousand;
}
