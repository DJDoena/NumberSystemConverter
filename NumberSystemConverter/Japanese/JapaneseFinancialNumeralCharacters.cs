namespace DoenaSoft.NumberSystemConverter.Japanese;

/// <summary>
/// Character set for Financial Japanese number system.
/// Provides financial numeral characters.
/// </summary>
public sealed class JapaneseFinancialNumeralCharacters : JapaneseNumeralCharacterBase
{
    /// <inheritdoc/>
    public override char[] SingleDigits
        =>
        [
            JapaneseFinancialCharacterConstants.Zero,
            JapaneseFinancialCharacterConstants.One,
            JapaneseFinancialCharacterConstants.Two,
            JapaneseFinancialCharacterConstants.Three,
            JapaneseFinancialCharacterConstants.Four,
            JapaneseFinancialCharacterConstants.Five,
            JapaneseFinancialCharacterConstants.Six,
            JapaneseFinancialCharacterConstants.Seven,
            JapaneseFinancialCharacterConstants.Eight,
            JapaneseFinancialCharacterConstants.Nine
        ];

    /// <inheritdoc/>
    public override char C10
        => JapaneseFinancialCharacterConstants.Ten;

    /// <inheritdoc/>
    public override char C100
        => JapaneseFinancialCharacterConstants.Hundred;

    /// <inheritdoc/>
    public override char C1000
        => JapaneseFinancialCharacterConstants.Thousand;
}