namespace DoenaSoft.NumberSystemConverter.Japanese;

/// <summary>
/// Character set for Common Japanese number system.
/// Provides regular Japanese numeral characters.
/// </summary>
public sealed class JapaneseCommonNumeralCharacters : JapaneseNumeralCharacterBase
{
    /// <inheritdoc/>
    public override char[] SingleDigits
        =>
        [
            JapaneseCommonCharacterConstants.Zero,
            JapaneseCommonCharacterConstants.One,
            JapaneseCommonCharacterConstants.Two,
            JapaneseCommonCharacterConstants.Three,
            JapaneseCommonCharacterConstants.Four,
            JapaneseCommonCharacterConstants.Five,
            JapaneseCommonCharacterConstants.Six,
            JapaneseCommonCharacterConstants.Seven,
            JapaneseCommonCharacterConstants.Eight,
            JapaneseCommonCharacterConstants.Nine
        ];

    /// <inheritdoc/>
    public override char C10
        => JapaneseCommonCharacterConstants.Ten;

    /// <inheritdoc/>
    public override char C100
        => JapaneseCommonCharacterConstants.Hundred;

    /// <inheritdoc/>
    public override char C1000
        => JapaneseCommonCharacterConstants.Thousand;
}
